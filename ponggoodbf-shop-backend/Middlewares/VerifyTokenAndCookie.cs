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
            var s=context.Request.Cookies["aaa"];
            
            var cookieOption = new CookieOptions
            {
                Path = "/",
                HttpOnly = true,
            };
            context.Response.Cookies.Append("pong-cookie", "jjjwwwqq", cookieOption);
            await _next(context);
        }
    }
}
