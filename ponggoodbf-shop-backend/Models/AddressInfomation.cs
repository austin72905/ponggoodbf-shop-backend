namespace ponggoodbf_shop_backend.Models
{
    public class AddressInfomation
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? phoneNumber { get; set; }
        public string? mail { get; set; }
        public string? recieverAddress { get; set; }
        public bool isDefaultAddress { get; set; }

    }
}
