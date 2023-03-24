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

        [HttpPost]
        [Route("User/UpdateUserInfo")]
        public IActionResult UpdateUserInfo([FromForm] PersonalInfomation input)
        {
            var token = Request.Headers["pong-token"];
            var result = new AccountService().UpdateUserInfo(input, token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpGet]
        [Route("User/GetAllAddress")]
        public IActionResult GetAllAddress()
        {

            var token = Request.Headers["pong-token"];
            var result = new AddressService().GetAllAddress(token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }


        [HttpPost]
        [Route("User/AddNewAddress")]
        public IActionResult AddNewAddress([FromForm] AddressInfomation input)
        {

            var token = Request.Headers["pong-token"];
            var result = new AddressService().AddNewAddress(input,token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpPost]
        [Route("User/EditAddress")]
        public IActionResult EditAddress([FromForm] AddressInfomation input)
        {

            var token = Request.Headers["pong-token"];
            var result = new AddressService().EditAddress(input, token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpPost]
        [Route("User/DeleteAddress")]
        public IActionResult DeleteAddress([FromForm] int addressId)
        {

            var token = Request.Headers["pong-token"];
            var result = new AddressService().DeleteAddress(addressId, token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

    }
}
