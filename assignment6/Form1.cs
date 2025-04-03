using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace _2025_3_31_assignment6
{
    using OrderApp;

   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("输入需要删除的id号", "输入需要删除的id号");
            MyClass.orderService.RemoveOrder(int.Parse(input));
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = MyClass.orderService.orders;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = orderService.orders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = MyClass.orderService.orders;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = MyClass.orderService.orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              form2 newForm= new form2();
               newForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
               

                if(comboBox2.SelectedIndex==0)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = MyClass.orderService.orders;
                }
                else if(comboBox2.SelectedIndex==1)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    Comparison<Order> orderComparison = (x, y) => x.Id.CompareTo(y.Id);
                    // 调用 Sort 方法进行排序
                    MyClass.orderService.Sort(orderComparison);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = MyClass.orderService.orders;
                }
                else if(comboBox2.SelectedIndex==2)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    Comparison<Order> orderComparison = (x, y) => x.TotalPrice.CompareTo(y.TotalPrice);
                    // 调用 Sort 方法进行排序
                    MyClass.orderService.Sort(orderComparison);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = MyClass.orderService.orders;
                }
            }
            else
            {
                MessageBox.Show("请选择一个选项");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("提示信息输入", "输入");
            if(comboBox1.SelectedIndex==0)
            {
                Predicate<Order> condition = o => o.Id==int.Parse(input);
                IEnumerable<Order> result =MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView1.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("false id");
                }

            }
            else if(comboBox1.SelectedIndex==1) {
                Predicate<Order> condition = o => o.Customer.Name == input;
                IEnumerable<Order> result = MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView1.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("false customer name");
                }
            }
            else if(comboBox1.SelectedIndex==2) 
            { 
                List<Order>orders = new List<Order>();
                for(int i=0;i<MyClass.orderService.orders.Count;i++)
                {  
                    for(int j=0;j< MyClass.orderService.orders[i].Details.Count;j++)
                    if (MyClass.orderService.orders[i].Details[j].Product.Name==input)
                        {
                            orders.Add(MyClass.orderService.orders[i]);
                            break;
                        }
                }
                if (orders.Any())
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(orders.ToList());
                    dataGridView1.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("false product name");
                }


            }
            else
            {
                Predicate<Order> condition = o => o.TotalPrice ==float.Parse( input);
                IEnumerable<Order> result = MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView1.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("false totoal money");
                }




            }
        }
    }
    public class MyClass
    {
        public static OrderService orderService = new OrderService();
    }
}
