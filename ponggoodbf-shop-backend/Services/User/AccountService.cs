using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services.User
{
    public class AccountService
    {
        public ResponseModel GetUserInfo(string? token)
        {
            if (token == null)
            {
                return new ResponseModel() {code=-1,msg="請重新登錄" };
            }

            return new ResponseModel() { code = 1, msg = "獲取成功" };
        }
    }
}
