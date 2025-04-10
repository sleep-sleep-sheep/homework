using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_3_31_assignment6
{
    using OrderApp;
    
    public partial class form2 : Form
    {
       
        public List<Product> list = new List<Product>();
        public form2()
        {
            InitializeComponent();
            list.Add(new Product(1, "苹果", 8));
            list.Add(new Product(2, "香蕉", 6));
            list.Add(new Product(3, "橘子", 4));
            list.Add(new Product(4, "虾", 30));
            list.Add(new Product(5, "螃蟹", 30));
            list.Add(new Product(6, "白菜", 3));
            list.Add(new Product(7, "羊肉", 35));
       
            foreach (Product p in list)
            {
                checkedListBox1.Items.Add(p);
 
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(int.Parse(textBox1.Text),textBox2.Text);
            List<OrderDetail> orderDetails = new List<OrderDetail>();
           
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {   
                if (checkedListBox1.GetItemChecked(i))
                {
                    Control[] controls = this.Controls.Find(list[i].Name +"数量", true);
                    if (controls.Length > 0 && controls[0] is TextBox)
                    {
                        TextBox foundTextBox = (TextBox)controls[0];
                        string textBoxValue = foundTextBox.Text;
                        orderDetails.Add(new OrderDetail(list[i], int.Parse(textBoxValue)));
                    }
                   
                }
            }
           
           if( orderDetails.Count!=0)
            {
                
                if(!MyClass.orderService.orders.Any())
                {
                    Order order = new Order(1, customer, DateTime.Now);
                    foreach (OrderDetail detail in orderDetails)
                    {
                        order.AddDetails(detail);
                    }
                    MyClass.orderService.orders.Add(order);   
                }
                else 
                {
                    int maxId = MyClass.orderService.orders.Max(o => (int?)o.Id) ?? 0;

                    // 计算新订单的 Id
                    int newOrderId = maxId + 1;

                    // 创建新订单
                    Order order = new Order(newOrderId, customer, DateTime.Now);
                    foreach (OrderDetail detail in orderDetails)
                    {
                        order.AddDetails(detail);
                    }
                    MyClass.orderService.orders.Add(order);
                }
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("false");
            }

        }
    }
}
