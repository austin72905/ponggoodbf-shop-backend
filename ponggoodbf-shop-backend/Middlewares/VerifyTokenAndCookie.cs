using System.Text.Json;
using static ponggoodbf_shop_backend.Controllers.ProductController;

namespace ponggoodbf_shop_backend.Middlewares
{
    public class VerifyTokenAndCookie
    {
        private readonly RequestDelegate _next;

        public VerifyTokenAndCookie(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            context.Request.Headers.Add("x-user-id", "123456");
            var s = context.Request.Cookies["aaa"];
            //response body 不可讀，需要先把他提取出來


            var cookieOption = new CookieOptions
            {
                Path = "/",
                HttpOnly = true,
            };

            var originRespBody = context.Response.Body;

            var readableStream = new MemoryStream();

            //response 先改他個值
            context.Response.Body = readableStream;


            context.Response.OnStarting(async o =>
            {
                if (o is HttpContext ctx)
                {
                    readableStream.Seek(0, SeekOrigin.Begin);
                    using var respReader = new StreamReader(readableStream, leaveOpen: true);

                    string responseBody = respReader.ReadToEnd();
                    var result = JsonSerializer.Deserialize<Tmp>(responseBody);
                    if (result != null && result.category == "aaa")
                    {
                        Console.WriteLine($"這是-----------------------------------{result.category}");
                    }
                    else
                    {
                        Console.WriteLine($"這是-----------------------------------{result.userid}");
                    }

                    readableStream.Seek(0, SeekOrigin.Begin);
                    ctx.Response.Cookies.Append("pong-cookie", "jjjwwwqq", cookieOption);

                    /*
                        1. readableStream.CopyTo(response.Body);
                            如果使用這個而不是非同步，會有 content-lengh mistach 的報錯，估計可能是同步沒等，還沒寫進去就往下跑了
                        2. set cookie 的行為要寫在  CopyToAsync 前 ， 否則會報 Header is read only, the response started

                        3. OnStarting 寫法 特別
                    */
                    await readableStream.CopyToAsync(originRespBody);
                    //readableStream.CopyTo(response.Body);

                    ctx.Response.Body = originRespBody;
                    readableStream.Dispose();
                    
                }
            }, context);






            await _next(context);









        }
    }
}
