using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services.User
{
    public class OrderService
    {
        public List<OrderInfomation> GetOrdersByUserId(int userId)
        {
            return new List<OrderInfomation>();

        }

        public OrderInfomation GetOrderByRecordcode(string recordcode)
        {
            return new OrderInfomation();
        }

        public OrderInfomation GetOrderByKeyword(string keyword)
        {
            return new OrderInfomation();
        }

        public List<OrderInfomation> DeleteOrder(string recordcode)
        {
            return new List<OrderInfomation>();
        }

        
    }
}
