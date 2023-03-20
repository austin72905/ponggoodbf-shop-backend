using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services
{
    public class UserService
    {
        public PersonalInfomation EditPersonalInfomation(PersonalInfomation info,int userId)
        {
            return new PersonalInfomation();
        }

        public PasswordVerify EditPassword(PasswordVerify password, int userId)
        {
            return new PasswordVerify();
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
