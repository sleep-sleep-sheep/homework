using System;
using System.Collections.Generic;
using System.Linq;


namespace _2025_3_20_assignment5
{
    internal class OrderDetails
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public OrderDetails(string productName, double price)
        {
            this.ProductName = productName; 
            this.Price = price;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
            OrderDetails other = obj as OrderDetails;
            return other != null &&other.ProductName==this.ProductName&&other.Price==this.Price;
        }

    }
}
