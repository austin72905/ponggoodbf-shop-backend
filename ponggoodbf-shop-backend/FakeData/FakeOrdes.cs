using ponggoodbf_shop_backend.Models;

namespace ponggoodbf_shop_backend.FakeData
{
    public class FakeOrdes
    {
        public static Dictionary<int, List<OrderInfomation>> UseridOrderList = new Dictionary<int, List<OrderInfomation>>()
        {
            {
                1,new List<OrderInfomation>()
                {
                    new OrderInfomation()
                    {
                        recordCode= "TX20230122063253",
                        productName= "好男人需要時我都在衛生紙(10入)",
                        prouctPrice= 100,
                        orderPrice= 139,
                        count= 1,
                        size= "標準規格",
                        address=new OrderAddress
                        {
                            receiver= "王大明",
                            phoneNumber= "(+886)964816276",
                            cargoAddress= "7-11 雅典門市 台中市南區三民西路377號西川一路1號 店號950963"
                        },
                        cargoInfomation= new List<CargoInfomation>
                        {
                            new CargoInfomation
                            {
                                description= "買家取件成功",
                                date= "2022-12-20 10:10:09"
                            },
                            new CargoInfomation
                            {
                                description= "包裹已送達",
                                date= "2022-12-18 01:30:33"
                            },
                            new CargoInfomation
                            {
                                description= "包裹寄送中",
                                date= "2022-12-16 08:01:55"
                            },
                            new CargoInfomation
                            {
                                description= "已寄件",
                                date= "2022-12-15 00:10:16"
                            }
                        },
                        orderStepInfomation= new List<OrderStepInfomation>
                        {
                            new OrderStepInfomation
                            {
                            unachieveDescription= "訂單未成立",
                            achieveDescription= "訂單已成立",
                            date= "2022-12-10 13:10:16"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "未收到款項",
                                achieveDescription= "已收款",
                                date= "2022-12-14 00:01:55"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "尚未出貨",
                                achieveDescription= "已出貨",
                                date="2022-12-15 08:30:33"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "尚未完成訂單",
                                achieveDescription= "已完成訂單",
                                date="2022-12-22 10:10:09"
                            },
                        },
                        status= "1",
                        cargoPrice= 39,
                        payWay= "LinePay"
                    },
                    new OrderInfomation()
                    {
                        recordCode= "TX20230122063253",
                        productName= "好男人需要時我都在衛生紙(10入)",
                        prouctPrice= 100,
                        orderPrice= 139,
                        count= 1,
                        size= "標準規格",
                        address=new OrderAddress
                        {
                            receiver= "王大明",
                            phoneNumber= "(+886)964816276",
                            cargoAddress= "7-11 雅典門市 台中市南區三民西路377號西川一路1號 店號950963"
                        },
                        cargoInfomation= new List<CargoInfomation>
                        {
                            new CargoInfomation
                            {
                                description= "買家取件成功",
                                date= "2022-12-20 10:10:09"
                            },
                            new CargoInfomation
                            {
                                description= "包裹已送達",
                                date= "2022-12-18 01:30:33"
                            },
                            new CargoInfomation
                            {
                                description= "包裹寄送中",
                                date= "2022-12-16 08:01:55"
                            },
                            new CargoInfomation
                            {
                                description= "已寄件",
                                date= "2022-12-15 00:10:16"
                            }
                        },
                        orderStepInfomation= new List<OrderStepInfomation>
                        {
                            new OrderStepInfomation
                            {
                            unachieveDescription= "訂單未成立",
                            achieveDescription= "訂單已成立",
                            date= "2022-12-10 13:10:16"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "未收到款項",
                                achieveDescription= "已收款",
                                date= "2022-12-14 00:01:55"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "尚未出貨",
                                achieveDescription= "已出貨",
                                date="2022-12-15 08:30:33"
                            },
                            new OrderStepInfomation
                            {
                                unachieveDescription= "尚未完成訂單",
                                achieveDescription= "已完成訂單",
                                date="2022-12-22 10:10:09"
                            },
                        },
                        status= "2",
                        cargoPrice= 39,
                        payWay= "LinePay"
                    }
                } 
            }
        };
    }
}
