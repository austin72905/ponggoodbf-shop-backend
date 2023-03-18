namespace ponggoodbf_shop_backend.Models
{
    public class ProductInfomation
    {
        public string? title { get; set; }

        public string? productId { get; set; }

        public string? image { get; set; }

        public int stock { get; set; }

        public decimal price { get; set; }

        public List<string>? size { get; set; }

        public string? description { get; set; }

    }
}
