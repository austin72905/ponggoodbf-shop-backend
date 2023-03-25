using ponggoodbf_shop_backend.FakeData;
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

        public ResponseModel GetCollection(string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                var productIdlist=FakeProducts.UserIdCollection[info.UserId];
                var productList=FakeProducts.ProductList.Where(p=> productIdlist.Contains(p.productId)).Select(p => p);
                return new ResponseModel() { code = 1, msg = "獲取成功", data = productList };
            }

            return new ResponseModel() { code = -1, msg = "獲取失敗" };
        }

        public ResponseModel AddCollection(string productId, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                FakeProducts.UserIdCollection[info.UserId].Add(productId);
                return new ResponseModel() { code = 1, msg = "修改成功"};
            }

            return new ResponseModel() { code = -1, msg = "修改失敗" };
        }

        public ResponseModel DeleteCollection(string productId, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                FakeProducts.UserIdCollection[info.UserId].Remove(productId);
                return new ResponseModel() { code = 1, msg = "修改成功" };
            }
            return new ResponseModel() { code = -1, msg = "修改失敗" };
        }
    }
}
