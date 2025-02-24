namespace window_2_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message.Text = string.Empty;
            string word1;
            double OperandOne, OperandTwo;
            word1 = textBox1.Text;
            OperandOne = double.Parse(word1);
            word1 = textBox2.Text;
            OperandTwo = double.Parse(word1);
            word1 = textBox3.Text;
            switch (word1)
            {
                case "+": { Message.Text += (OperandTwo + OperandOne).ToString(); break; }
                case "-": { Message.Text += (OperandTwo - OperandOne).ToString(); break; }
                case "*": { Message.Text += (OperandTwo * OperandOne).ToString(); break; }
                case "/": { Message.Text += (OperandTwo / OperandOne).ToString(); break; }
                case "%": { Message.Text += (OperandTwo % OperandOne).ToString(); break; }
                default: { Message.Text += "Sorry,don't have this operator symbol!"; break; }
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}