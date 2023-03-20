using Microsoft.AspNetCore.Mvc;

namespace ponggoodbf_shop_backend.Controllers
{
    [ApiController]
    public class ProductController: ControllerBase
    {
        [HttpGet]
        [Route("Product/Index")]
        public IActionResult Index()
        {
            return Content("OK");
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
            return Content($"category={category},userid={Request.Headers["x-user-id"]}");
        }
    }
}
