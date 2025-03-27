namespace _2025_3_20_assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            List<OrderDetails> orderDetails1 = new List<OrderDetails>
                 { new OrderDetails("商品1", 120), 
                   new OrderDetails("商品2",100)};
            List<OrderDetails> orderDetails2 = new List<OrderDetails>
                 { new OrderDetails("商品1", 120),
                   new OrderDetails("商品2",100),
                  new OrderDetails("商品3", 180)};
            List<OrderDetails> orderDetails3 = new List<OrderDetails>
                 { new OrderDetails("商品5", 120),
                   new OrderDetails("商品6",100),
                  new OrderDetails("商品7", 180)};
            List<Order> orderlist = new List<Order> { 
                new Order("001", "A", orderDetails1),
                new Order("002","B",orderDetails2)
            };
            foreach (var item in orderlist)
            {
                orderService.AddOrder(item);
            }
            Order order3 = new Order("001", "C", orderDetails3);
            orderService.ModifyOrder(order3);
            orderService.SortOrders();
            Console.WriteLine("\n按订单号排序后的订单列表:");
            foreach (var order in orderService.orders)
            {
                Console.WriteLine(order);
            }

            // 自定义排序
            orderService.SortOrders((x, y) => x.TotalMoney().CompareTo(y.TotalMoney()));
            Console.WriteLine("\n按订单总金额排序后的订单列表:");
            foreach (var order in orderService.orders)
            {
                Console.WriteLine(order);
            }

        }
    }
}