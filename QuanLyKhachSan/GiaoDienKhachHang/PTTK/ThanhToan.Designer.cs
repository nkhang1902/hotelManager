namespace GiaoDienKhachHang
{
    partial class ThanhToan
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các hóa đơn cần chi trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 38);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 30;
            label5.Text = "Phòng - Đêm";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 138);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 138);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 28;
            label4.Text = "Tổng tiền";
            // 
            // button1
            // 
            button1.Location = new Point(116, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Tra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3 });
            listView1.Location = new Point(432, 70);
            listView1.Name = "listView1";
            listView1.Size = new Size(219, 97);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày";
            columnHeader3.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 34);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 24;
            label3.Text = "Tiền dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 34);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 23;
            label2.Text = "Tiền phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "CMND";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 34);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tiền Mặt", "Chuyển Khoản" });
            comboBox1.Location = new Point(81, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(10, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 163);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thanh Toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 77);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 32;
            label7.Text = "Hình thức";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 38);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 31;
            label6.Text = "CMND";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 35);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(434, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 35);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 34;
            label8.Text = "Ngày";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(492, 77);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 31;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 408);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ThanhToan";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}