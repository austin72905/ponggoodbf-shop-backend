using ponggoodbf_shop_backend.FakeData;
using ponggoodbf_shop_backend.Models;
using System.Text.Json;
using static ponggoodbf_shop_backend.Controllers.ProductController;
using static ponggoodbf_shop_backend.Services.User.LoginService;

namespace ponggoodbf_shop_backend.Middlewares
{
    public class VerifyTokenAndCookie
    {
        private readonly RequestDelegate _next;

        public VerifyTokenAndCookie(RequestDelegate next)
        {
            _next = next;

        }

        public static List<string> _needTokenUrl = new List<string> 
        {
            "/User/GetUserInfo"
        };

        public static List<string> _dontNeedTokenUrl = new List<string> 
        {
            "/Product/Index"
        };

        public async Task Invoke(HttpContext context)
        {
            var url = context.Request.Path.ToString();
            //這個之後可以刪掉
            context.Request.Headers.Append("pong-token", "66666");
            if (_needTokenUrl.Contains(url))
            {
                //教驗token
                context.Request.Headers.TryGetValue("pong-token", out var token);
                
                if (string.IsNullOrEmpty(token.ToString()))
                {
                    var resp = new ResponseModel() { code = -1, msg = "請重新登錄" };
                    await context.Response.WriteAsJsonAsync(resp);
                    return;
                }

                context.Request.Cookies.TryGetValue("pong-cookie", out var cookie);

                if (string.IsNullOrEmpty(cookie))
                {
                    var resp = new ResponseModel() { code = -1, msg = "請重新登錄" };
                    await context.Response.WriteAsJsonAsync(resp);
                    return;
                }
            }

            
            

            var cookieOption = new CookieOptions
            {
                Path = "/",
                HttpOnly = true,
            };
            //response body 不可讀，需要先把他提取出來
            var originRespBody = context.Response.Body;

            var readableStream = new MemoryStream();

            //response 先改他個值
            context.Response.Body = readableStream;


            context.Response.OnStarting(async o =>
            {
                if (o is HttpContext ctx)
                {
                    readableStream.Seek(0, SeekOrigin.Begin);
                    //C#8 有語法 using var ，可以取代之前 using block 的寫法，在離開作用域時自動dispose
                    using var respReader = new StreamReader(readableStream, leaveOpen: true);

                    string responseBody = respReader.ReadToEnd();
                    //Console.WriteLine(responseBody);
                    var result = JsonSerializer.Deserialize<LoginResp>(responseBody);
                    readableStream.Seek(0, SeekOrigin.Begin);
                    //Console.WriteLine(JsonSerializer.Serialize(result));
                    if (result != null && result.code == 1)
                    {
                        if (result.RandomStr != null)
                        {
                            
                            var token = FakeAccounts.RandomSession[result.RandomStr];
                            ctx.Response.Headers.Append("pong-token", token);
                            ctx.Response.Cookies.Append("pong-cookie", result.RandomStr, cookieOption);
                        }
                        
                        
                    }

                    
                    

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
