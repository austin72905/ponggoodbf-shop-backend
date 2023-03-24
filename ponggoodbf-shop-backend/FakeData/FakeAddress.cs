using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.FakeData
{
    public class FakeAddress
    {
        public static Dictionary<int, List<AddressInfomation>> AddressList = new Dictionary<int, List<AddressInfomation>>()
        {
            {
                1,new List<AddressInfomation>()
                {
                    new AddressInfomation
                    {
                        id=1,
                        name="王大陸",
                        phoneNumber= "0945864315",
                        mail= "Laopigu@gmail.com",
                        recieverAddress= "台中市南區三民西路377號西川一路1號",
                        isDefaultAddress= false,
                    }
                }
            }
        };
    }
}
