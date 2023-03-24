using ponggoodbf_shop_backend.FakeData;
using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services.User
{
    public class AddressService
    {
        public ResponseModel GetAllAddress(string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }

            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                var list = FakeAddress.AddressList[info.UserId];
                return new ResponseModel() { code = 1, msg = "獲取成功", data = list };
            }

            return new ResponseModel() { code = -1, msg = "請重新登錄" };
        }
        
        public ResponseModel AddNewAddress(AddressInfomation input, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);

            if (info != null)
            {
                var addressList = FakeAddress.AddressList[info.UserId];
                if (addressList.Count == 0)
                {
                    input.id = 1;
                }
                else
                {
                    input.id=addressList.Last().id+1;
                }
                
                addressList.Add(input);
                return new ResponseModel() { code = 1, msg = "新增成功", data = addressList };
            }
            
            return new ResponseModel() { code = -1, msg = "新增失敗" };
        }

        public ResponseModel EditAddress(AddressInfomation input, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }
            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null) 
            {
                var list = FakeAddress.AddressList[info.UserId];
                var editItem = list.FirstOrDefault(o => o.id == input.id);
                if (editItem == null)
                {
                    return new ResponseModel() { code = -1, msg = "修改失敗", data = editItem };
                }

                list.Remove(editItem);
                list.Add(input);
                return new ResponseModel() { code = 1, msg = "修改成功", data = list };
            }

            return new ResponseModel() { code = -1, msg = "修改失敗" };
        }

        public ResponseModel DeleteAddress(int addressId, string? token)
        {
            if (token == null)
            {
                return new ResponseModel() { code = -1, msg = "請重新登錄" };

            }

            FakeAccounts.SessionList.TryGetValue(token, out var info);
            if (info != null)
            {
                var list = FakeAddress.AddressList[info.UserId];
                var delItem =list.FirstOrDefault(o=>o.id== addressId);
                if (delItem == null)
                {
                    return new ResponseModel() { code = 1, msg = "地址已刪除", data = list };
                }

                list.Remove(delItem);
                return new ResponseModel() { code = 1, msg = "刪除成功", data = list };
            }

            return new ResponseModel() { code = -1, msg = "刪除失敗" };
        }
    }
}
