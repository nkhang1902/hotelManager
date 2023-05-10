namespace PTTK
{
    partial class CheckIn
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 48);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 30);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 5;
            label3.Text = "Ma dat phong";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 92);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 7;
            label5.Text = "CMND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 162);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 8;
            label6.Text = "Yeu cau";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(198, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 39);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(417, 26);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 12;
            button1.Text = "Kiem tra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1069, 522);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 13;
            button2.Text = "Xac nhan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1114, 185);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 92);
            label7.Name = "label7";
            label7.Size = new Size(219, 32);
            label7.TabIndex = 15;
            label7.Text = "Nhan vien check in";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(807, 85);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 159);
            label8.Name = "label8";
            label8.Size = new Size(0, 32);
            label8.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Co", "Khong" });
            comboBox2.Location = new Point(846, 151);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 40);
            comboBox2.TabIndex = 22;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 151);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 23;
            label1.Text = "Van chuyen hanh ly";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(951, 12);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 24;
            label4.Text = "Time";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1069, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 39);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // CheckIn
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 604);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "CheckIn";
            Text = "Phieu Check-In";
            Load += CheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private ComboBox comboBox2;
        private Label label1;
        private Label label4;
        private TextBox textBox2;
    }
}