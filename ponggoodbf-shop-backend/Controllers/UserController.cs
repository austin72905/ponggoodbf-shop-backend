using Microsoft.AspNetCore.Mvc;
using ponggoodbf_shop_backend.Models;
using ponggoodbf_shop_backend.Services.User;
using System.Text.Json;

namespace ponggoodbf_shop_backend.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("User/GetUserInfo")]
        public IActionResult GetUserInfo()
        {
            
            var token = Request.Headers["pong-token"];
            var result = new AccountService().GetUserInfo(token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }
    }
}
