namespace window_2_23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            Message = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 39);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 0;
            label1.Text = "第一个运算数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 117);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 1;
            label2.Text = "第二个运算数";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 190);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 2;
            label3.Text = "运算符";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 30);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 304);
            label4.Name = "label4";
            label4.Size = new Size(73, 37);
            label4.TabIndex = 6;
            label4.Text = "结果";
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(301, 315);
            Message.Name = "Message";
            Message.Size = new Size(0, 24);
            Message.TabIndex = 7;
            Message.Click += label5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 24);
            linkLabel1.TabIndex = 8;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(564, 264);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 24);
            linkLabel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(555, 254);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 534);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(Message);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label Message;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button button1;
    }
}