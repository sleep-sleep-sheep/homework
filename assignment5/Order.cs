using System;
using System.Collections.Generic;
using System.Linq;


namespace _2025_3_20_assignment5
{
    internal class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderDetails> Details { get; set; }
        public Order(string OrderId, string CustomerName, List<OrderDetails> Details)
        {
            this.OrderId = OrderId;
            this.CustomerName = CustomerName;
            this.Details = Details;
        }
        public double TotalMoney()
        {
            double result=0;
            foreach (var item in Details)
            {
                result += item.Price;
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o!=null&&o.OrderId==OrderId && o.CustomerName==CustomerName;
        }
        public override string ToString()
        {
            string display = "";
            
            foreach(OrderDetails o in Details)
            {
                display += o.ProductName;
                display += " ";
                display += o.Price.ToString();
                display += ";";
            }
            return OrderId.ToString() + " " + CustomerName.ToString() + " " + display;
        }

    }
}
