namespace _2025_3_31_assignment6
{
    using OrderApp;
    partial class form2
    {  
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.香蕉数量 = new System.Windows.Forms.TextBox();
            this.苹果数量 = new System.Windows.Forms.TextBox();
            this.橘子数量 = new System.Windows.Forms.TextBox();
            this.虾数量 = new System.Windows.Forms.TextBox();
            this.螃蟹数量 = new System.Windows.Forms.TextBox();
            this.白菜数量 = new System.Windows.Forms.TextBox();
            this.羊肉数量 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单创建界面";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.羊肉数量);
            this.groupBox2.Controls.Add(this.白菜数量);
            this.groupBox2.Controls.Add(this.螃蟹数量);
            this.groupBox2.Controls.Add(this.虾数量);
            this.groupBox2.Controls.Add(this.橘子数量);
            this.groupBox2.Controls.Add(this.苹果数量);
            this.groupBox2.Controls.Add(this.香蕉数量);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1257, 731);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkedListBox1);
            this.groupBox4.Location = new System.Drawing.Point(721, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 650);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选择商品";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(303, 623);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(0, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息填写";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "名字";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "身份证id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 28);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 28);
            this.textBox2.TabIndex = 1;
            // 
            // 香蕉数量
            // 
            this.香蕉数量.Location = new System.Drawing.Point(1085, 129);
            this.香蕉数量.Name = "香蕉数量";
            this.香蕉数量.Size = new System.Drawing.Size(100, 28);
            this.香蕉数量.TabIndex = 3;
            this.香蕉数量.Text = "香蕉树量";
            // 
            // 苹果数量
            // 
            this.苹果数量.Location = new System.Drawing.Point(1085, 105);
            this.苹果数量.Name = "苹果数量";
            this.苹果数量.Size = new System.Drawing.Size(100, 28);
            this.苹果数量.TabIndex = 4;
            this.苹果数量.Text = "苹果数量";
            // 
            // 橘子数量
            // 
            this.橘子数量.Location = new System.Drawing.Point(1085, 154);
            this.橘子数量.Name = "橘子数量";
            this.橘子数量.Size = new System.Drawing.Size(100, 28);
            this.橘子数量.TabIndex = 5;
            this.橘子数量.Text = "橘子数量";
            this.橘子数量.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // 虾数量
            // 
            this.虾数量.Location = new System.Drawing.Point(1085, 176);
            this.虾数量.Name = "虾数量";
            this.虾数量.Size = new System.Drawing.Size(100, 28);
            this.虾数量.TabIndex = 6;
            this.虾数量.Text = "虾数量";
            // 
            // 螃蟹数量
            // 
            this.螃蟹数量.Location = new System.Drawing.Point(1085, 201);
            this.螃蟹数量.Name = "螃蟹数量";
            this.螃蟹数量.Size = new System.Drawing.Size(100, 28);
            this.螃蟹数量.TabIndex = 7;
            this.螃蟹数量.Text = "螃蟹数量";
            // 
            // 白菜数量
            // 
            this.白菜数量.Location = new System.Drawing.Point(1085, 222);
            this.白菜数量.Name = "白菜数量";
            this.白菜数量.Size = new System.Drawing.Size(100, 28);
            this.白菜数量.TabIndex = 8;
            this.白菜数量.Text = "白菜数量";
            // 
            // 羊肉数量
            // 
            this.羊肉数量.Location = new System.Drawing.Point(1085, 247);
            this.羊肉数量.Name = "羊肉数量";
            this.羊肉数量.Size = new System.Drawing.Size(100, 28);
            this.羊肉数量.TabIndex = 9;
            this.羊肉数量.Text = "羊肉数量";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1140, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 869);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form2";
            this.Text = "form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox 苹果数量;
        private System.Windows.Forms.TextBox 香蕉数量;
        private System.Windows.Forms.TextBox 橘子数量;
        private System.Windows.Forms.TextBox 羊肉数量;
        private System.Windows.Forms.TextBox 白菜数量;
        private System.Windows.Forms.TextBox 螃蟹数量;
        private System.Windows.Forms.TextBox 虾数量;
        private System.Windows.Forms.Button button1;
    }
}