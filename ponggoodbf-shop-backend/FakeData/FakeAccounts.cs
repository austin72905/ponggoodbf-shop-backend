using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.FakeData
{
    public class FakeAccounts
    {
        public static Dictionary<string, string> AccountList = new Dictionary<string, string>() 
        {
            { "test1","12345"}
        };

        public static Dictionary<string, int> UserIdList = new Dictionary<string, int>()
        {
            { "test1",1}
        };

        public static Dictionary<string, SessionInfo> SessionList = new Dictionary<string, SessionInfo>()
        {
            {"xxx123654a",new SessionInfo()
            { 
                UserId = 1,

            } }
        };

        public static Dictionary<string, string> RandomSession = new Dictionary<string, string>();

        //個人訊息
        public static Dictionary<int, PersonalInfomation> PersoninfoList = new Dictionary<int, PersonalInfomation>() 
        {
            { 1,new PersonalInfomation
            { 
                name ="王大明",
                phoneNumber="8789456123",
                email="DaLaoUr@mail",
                sex="男",
            } }
        };
    }
}
