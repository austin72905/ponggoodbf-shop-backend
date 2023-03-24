using Microsoft.AspNetCore.Mvc;
using ponggoodbf_shop_backend.Models;
using ponggoodbf_shop_backend.Services.User;
using System.Text.Json;

namespace ponggoodbf_shop_backend.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Index([FromForm] LoginModel input)
        {
            var token = Request.Headers["pong-token"];
            var result = new LoginService().VerifyAccount(input, token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }
    }
}
