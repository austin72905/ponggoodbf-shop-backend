using ponggoodbf_shop_backend.FakeData;
using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services
{
    public class OrderService
    {

        public ResponseModel GetOrders(string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                var orderList = FakeOrdes.UseridOrderList[info.UserId];
                return new ResponseModel() { code = 1, msg = "獲取成功", data = orderList };
            }

            return new ResponseModel() { code = -1, msg = "獲取失敗" };
        }

        public ResponseModel CancelOrder(string recordCode, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null) 
            {
                var orderList = FakeOrdes.UseridOrderList[info.UserId];
                foreach (var item in orderList)
                {
                    if(item.recordCode== recordCode)
                    {
                        item.status = "2";
                    }
                    
                }
                return new ResponseModel() { code = 1, msg = "修改成功" };
            }

            return new ResponseModel() { code = -1, msg = "修改失敗" };
        }

        /*
            後面還需要增加 修改物流 步驟、整的訂單步驟 等 從 cms 操作的接口 
         
        */
    }
}
