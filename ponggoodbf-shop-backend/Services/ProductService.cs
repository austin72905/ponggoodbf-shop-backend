using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services
{
    public class ProductService
    {
        public IEnumerable<ProductInfomation> GetProducts(string category)
        {
            var products = new List<ProductInfomation>();
            products.Add(new ProductInfomation());
            return products;
        }

        public ProductInfomation GetProductById(string productId)
        {
            return new ProductInfomation();
        }
    }
}
