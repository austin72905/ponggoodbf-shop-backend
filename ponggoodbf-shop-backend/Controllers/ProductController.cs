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
        public IActionResult GetItemInfo(int productId)
        {
            return Content($"id={productId}");
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

        public class Tmp
        {
            public string? category { get;set; }

            public string? userid { get;set; }
        }
    }
}
