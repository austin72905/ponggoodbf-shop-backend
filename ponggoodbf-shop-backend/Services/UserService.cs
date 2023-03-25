using ponggoodbf_shop_backend.FakeData;
using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services
{
    public class UserService
    {
        public PersonalInfomation EditPersonalInfomation(PersonalInfomation info,int userId)
        {
            return new PersonalInfomation();
        }

        public ResponseModel EditPassword(PasswordVerify password,string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }

            FakeAccounts.SessionList.TryGetValue(token, out var info);

            if (info == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };
            }

            var userName=FakeAccounts.UserIdList.FirstOrDefault(o=>o.Value==info.UserId).Key;
            if (password.newPassword != null)
            {
                FakeAccounts.AccountList[userName] = password.newPassword;
                return new ResponseModel() { code = 1, msg = "修改成功" };
            }



            return new ResponseModel() { code = -1, msg = "修改失敗" };
        }

        public AddressInfomation AddNewAddress(AddressInfomation addressInfomation, int userId)
        {
            return new AddressInfomation();
        }

        public AddressInfomation EditNewAddress(AddressInfomation addressInfomation, int userId)
        {
            return new AddressInfomation();
        }
    }
}
