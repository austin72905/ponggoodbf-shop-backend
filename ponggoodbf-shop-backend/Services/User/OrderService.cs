using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.Services.User
{
    public class OrderService
    {
        public List<OrderInfomation> GetOrdersByUserId(int userId)
        {
            return new List<OrderInfomation>();

        }

        public OrderInfomation GetOrderByRecordcode(string recordcode, int userId)
        {
            return new OrderInfomation();
        }

        public OrderInfomation GetOrderByKeyword(string keyword, int userId)
        {
            return new OrderInfomation();
        }

        public List<OrderInfomation> CancelOrder(string recordcode,int userId)
        {
            return new List<OrderInfomation>();
        }

        
    }
}
