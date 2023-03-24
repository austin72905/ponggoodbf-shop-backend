using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services
{
    public class ProductService
    {
        public ResponseModel GetProducts(string category)
        {
            var products = new List<ProductInfomation>();
            products.Add(new ProductInfomation());

            return new ResponseModel() { code=1,msg="獲取成功",data= products };
        }

        public ResponseModel GetProductById(string productId)
        {
            var product = new ProductInfomation();
            return new ResponseModel() { code = 1, msg = "獲取成功", data = product };
        }
    }
}
