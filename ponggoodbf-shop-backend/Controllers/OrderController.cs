using Microsoft.AspNetCore.Mvc;
using ponggoodbf_shop_backend.Services;
using System.Text.Json;

namespace ponggoodbf_shop_backend.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("Order/GetOrders")]
        public IActionResult GetOrders()
        {
            var token = Request.Headers["pong-token"];
            var result = new OrderService().GetOrders(token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpPost]
        [Route("Order/CancelOrder")]
        public IActionResult CancelOrder([FromForm] string recordCode)
        {
            var token = Request.Headers["pong-token"];
            var result = new OrderService().CancelOrder(recordCode,token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

    }
}
