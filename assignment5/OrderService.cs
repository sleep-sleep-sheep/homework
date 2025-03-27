using System;
using System.Collections.Generic;
using System.Linq;


namespace _2025_3_20_assignment5
{
    internal class OrderService
    {
       public List<Order>orders= new List<Order>();
       public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                return;
            orders.Add(order);
        }
        public void DeleteOrder(Order order)
        {
            if(!orders.Contains(order)) return;
            orders.Remove(order);
        }
        public void ModifyOrder(Order order)
        {
            var orderToModify = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (orderToModify == null)
            {
                throw new Exception($"未找到订单号为 {order.OrderId} 的订单，修改失败。");
            }
            orderToModify.CustomerName = order.CustomerName;
            orderToModify.Details = order.Details;
        }
        public void SortOrders()
        {
            orders = orders.OrderBy(o => o.OrderId).ToList();
        }

        public void SortOrders(Func<Order, Order, int> comparison)
        {
            orders.Sort((x, y) => comparison(x, y));
        }

        //查询操作
        //按照订单id查询
        public List<Order> CheckById(string id)
        {
            return orders.Where(o => o.OrderId == id).OrderBy<Order,double>(o => o.TotalMoney()).ToList();
        }
        public List<Order> CheckByCustomerName(string customerName)
        {
            return orders.Where(o => o.CustomerName == customerName).OrderBy(o => o.TotalMoney()).ToList();
        }
        public List<Order> CheckByTotalMoney()
        {
            return orders.OrderBy(o=>o.TotalMoney()).ToList();
        }
        public List<Order> CheckByProduceName(string productName)
        {
            return orders.Where(o => o.Details.Any(od => od.ProductName == productName)).OrderBy(o => o.TotalMoney()).ToList();
        }
    }
    
}
