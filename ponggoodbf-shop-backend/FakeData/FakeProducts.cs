using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.FakeData
{
    public class FakeProducts
    {

        public static List<ProductInfomation> ProductList = new List<ProductInfomation>()
        {
            new ProductInfomation()
            {
                title ="好男人需要時我都在衛生紙(10入)",
                productId= "1",
                stock= 60,
                price= 100,
                image="",
                size=new List<string>{"S", "M", "L","XL"}
            },
            new ProductInfomation()
            {
                title ="好男人需要時我都在打氣樁",
                productId= "2",
                stock= 13,
                price= 1080,
                image="",
                
            },

        };
        /*
            title: "好男人需要時我都在衛生紙(10入)",
    productId: 1,
    stock: 60,
    price: 100,
    image: ProductImage,
    size: ["S", "M", "L","XL"] 
         
         
        */

        public static Dictionary<int,List<string>> UserIdCollection=new Dictionary<int, List<string>>()
        {
            {1,new List<string>{"1","2" } } 
            
        };
    }
}
