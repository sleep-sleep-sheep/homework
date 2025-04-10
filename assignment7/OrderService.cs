using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MySql.Data.EntityFramework;
namespace OrderApp
{
    public class OrderService : DbContext
    {
        public DbSet<Order> orders { get; set; }

        public OrderService() : base("name=OrderDBConnection")
        {
        }

        // 添加订单
        public void AddOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder != null)
            {
                MessageBox.Show($"the order {order.Id} already exists!");
                throw new System.ApplicationException($"the order {order.Id} already exists!");
            }
            orders.Add(order);
            SaveChanges();
        }

        // 更新订单
        public void UpdateOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder == null)
            {
                MessageBox.Show($"the order {order.Id} doesn't exist!");
                throw new System.ApplicationException($"the order {order.Id} doesn't exist!");
            }
            // 更新属性
            existingOrder.Customer.Name = order.Customer.Name;
          
            // 其他属性更新...
            SaveChanges();
        }

        // 根据Id查询订单
        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        // 根据Id删除订单
        public void RemoveOrder(int orderId)
        {
            var orderToRemove = orders.FirstOrDefault(o => o.Id == orderId);
            if (orderToRemove != null)
            {
                orders.Remove(orderToRemove);
                SaveChanges();
                MessageBox.Show("删除成功");
            }
        }

        // 查询所有订单
        public List<Order> QueryAll()
        {
            return orders.ToList();
        }

        // 根据客户名查询
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.Customer.Name == customerName)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 根据货物名查询
        public List<Order> QueryByProductName(string productName)
        {
            var query = orders.Where(
              o => o.Details.Any(d => d.Product.Name == productName))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 根据总价查询
        public List<Order> QueryByTotalPrice(float totalPrice)
        {
            var query = orders.Where(o => o.TotalPrice >= totalPrice)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 对orders中的数据进行排序
        public void Sort(Comparison<Order> comparison)
        {
            var orderList = orders.ToList();
            orderList.Sort(comparison);
            // 这里如果需要更新数据库中的顺序，可能需要更复杂的操作
        }

        // 根据传入的条件进行查询
        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders.Where(o => condition(o)).OrderBy(o => o.TotalPrice);
        }
    }
}