using ponggoodbf_shop_backend.FakeData;
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

            FakeAccounts.SessionList.TryGetValue(token, out var info);

            if (info == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };
            }

            

            return new ResponseModel() { code = 1, msg = "獲取成功",data= FakeAccounts.PersoninfoList[info.UserId] };
        }

        public ResponseModel UpdateUserInfo(PersonalInfomation input,string? token)
        {
            if (token == null)
            {
                
                return new ResponseModel() { code = -1, msg = "請重新登錄" };
            }

            var info=UpdateUserInfomation(input, token);
            if (info == null)
            {
                return new ResponseModel() { code = -1, msg = "修改異常", data = info };
            }
            return new ResponseModel() { code = 1, msg = "修改成功",data= info };
        }

        public PersonalInfomation? UpdateUserInfomation(PersonalInfomation input, string token)
        {
            FakeAccounts.SessionList.TryGetValue(token, out var info);

            if (info != null)
            {
                FakeAccounts.PersoninfoList[info.UserId]= input;
                return FakeAccounts.PersoninfoList[info.UserId];
            }

            return null;
        }
    }
}
