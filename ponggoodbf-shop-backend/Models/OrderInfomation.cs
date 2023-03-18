namespace ponggoodbf_shop_backend.Models
{
    public class OrderInfomation
    {
        public string? recordCode { get; set; }
        public string? productName { get; set; }

        public int prouctPrice { get; set; }

        public int orderPrice { get; set; }

        public int cargoPrice { get; set; }

        public string? size { get; set; }

        public int count { get; set; }
        public string? status { get; set; }
        public string? payWay { get; set; }

        public OrderAddress? address { get; set; }

        public CargoInfomation[]? cargoInfomation { get; set; }
        public OrderStepInfomation[]? orderStepInfomation { get; set; }

    }

    public class OrderAddress
    {
        public string? receiver { get; set; }
        public string? phoneNumber { get; set; }
        public string? cargoAddress { get; set; }

    }

    public class CargoInfomation
    {
        public string? description { get; set; }
        public string? date { get; set; }

    }

    public class OrderStepInfomation
    {
        public string? unachieveDescription { get; set; }
        public string? achieveDescription { get; set; }
        public string? date { get; set; }

    }


}
