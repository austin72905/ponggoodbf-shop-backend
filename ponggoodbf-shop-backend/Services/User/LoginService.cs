using ponggoodbf_shop_backend.FakeData;
using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services.User
{
    public class LoginService
    {
        public LoginResp VerifyAccount(LoginModel input,string? token)
        {
            string? userName = input.userName;
            if (userName!=null && FakeAccounts.AccountList.ContainsKey(userName))
            {
                string? password = FakeAccounts.AccountList[userName];
                // 驗證密碼正確
                if (password!=null && password == input.password)
                {
                    var resp = new LoginResp() { code = 1, msg = "登陸成功" };
                    string random=addToken(resp,userName);
                    resp.RandomStr = random;
                    return resp;
                }

                return new LoginResp() { code = -1, msg = "密碼錯誤" };
            }
            return new LoginResp() { code=-1,msg="用戶不存在"};
        }

        public string addToken(LoginResp response,string userName)
        {
            
            if (response.code == 1)
            {
                string random=GenerateRandomStr();

                FakeAccounts.SessionList.Add(random, new SessionInfo 
                { 
                    UserId = FakeAccounts.UserIdList[userName],
                    RandomStr= random
                } );

                FakeAccounts.RandomSession.Add(random, random);
                return random;
            }
            return string.Empty;
        }

        public static string GenerateRandomStr()
        {
            //宣告陣列
            string[] strings = new string[6];
            //希望的文字組合
            string[] str = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                    "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                    "0","1","2","3","4","5","6","7","8","9"};
            //隨機
            Random r = new Random();
            string randomstr = "";
            for (int i = 0; i < 6; i++)
            {
                randomstr += str[r.Next(str.Length)];
            }
            return randomstr;
        }

        public class LoginResp : ResponseModel
        {
            public string? RandomStr { get; set; }
        }

        //public class LoginResp
        //{
        //    public int code { get; set; }

        //    public string? msg { get; set; }

        //    public object? data { get; set; }

        //    public string? RandomStr { get; set; }
        //}

    }
}
