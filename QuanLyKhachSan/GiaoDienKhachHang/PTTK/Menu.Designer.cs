namespace PTTK
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 109);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(169, 22);
            button1.TabIndex = 0;
            button1.Text = "Check In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 76);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(169, 22);
            button2.TabIndex = 1;
            button2.Text = "Dịch vụ khách sạn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(97, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng ký thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(58, 94);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(169, 22);
            button4.TabIndex = 3;
            button4.Text = "Nhập thông tin đoàn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 60);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(169, 22);
            button3.TabIndex = 2;
            button3.Text = "Nhập thông tin khách hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(60, 40);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(169, 22);
            button5.TabIndex = 4;
            button5.Text = "Đặt phòng";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(434, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 192);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dành cho khách hàng";
            // 
            // button6
            // 
            button6.Location = new Point(60, 142);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(169, 22);
            button6.TabIndex = 5;
            button6.Text = "Check Out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GiaoDienKhachHang.Properties.Resources.khachsann;
            ClientSize = new Size(824, 439);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button5;
        private Button button4;
        private GroupBox groupBox2;
        private Button button6;
    }
}