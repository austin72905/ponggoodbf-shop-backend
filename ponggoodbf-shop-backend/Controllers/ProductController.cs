using Microsoft.AspNetCore.Mvc;
using ponggoodbf_shop_backend.Services;
using System.Text.Json;

namespace ponggoodbf_shop_backend.Controllers
{
    [ApiController]
    public class ProductController: ControllerBase
    {
        [HttpGet]
        [Route("Product/Index")]
        public IActionResult Index([FromQuery] string category)
        {
            var result = new ProductService().GetProducts(category);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpGet]
        [Route("Product/{productId}")]
        public IActionResult GetItemInfo(string productId)
        {
            var result = new ProductService().GetProductById(productId);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpGet]
        [Route("Product")]
        public IActionResult GetItemCategory([FromQuery]string category)
        {
            var temp = new Tmp()
            {
                category = category,
                userid = Request.Headers["x-user-id"],

            };
            return Content(JsonSerializer.Serialize(temp));
        }

        [HttpGet]
        [Route("Product/GetCollection")]
        public IActionResult GetCollection()
        {
            var token = Request.Headers["pong-token"];
            var result = new ProductService().GetCollection(token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpPost]
        [Route("Product/AddCollection")]
        public IActionResult AddCollection([FromForm] string productId)
        {
            var token = Request.Headers["pong-token"];
            var result = new ProductService().AddCollection(productId,token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        [HttpPost]
        [Route("Product/DeleteCollection")]
        public IActionResult DeleteCollection([FromForm] string productId)
        {
            var token = Request.Headers["pong-token"];
            var result = new ProductService().DeleteCollection(productId,token);
            return Content(JsonSerializer.Serialize(result), contentType: "application/json");
        }

        public class Tmp
        {
            public string? category { get;set; }

            public string? userid { get;set; }
        }
    }
}
