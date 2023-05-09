namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "Phương thức thanh toán";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(134, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 4;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(254, 48);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 5;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(155, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 50);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(275, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 50);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 10;
            label4.Text = "Tên người sở hữu thẻ";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(435, 80);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 12;
            label5.Text = "Ngày hết hạn";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(435, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 14;
            label3.Text = "Mã thẻ";
            label3.Click += label3_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 142);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(170, 23);
            maskedTextBox1.TabIndex = 15;
            maskedTextBox1.TextAlign = HorizontalAlignment.Right;
            maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(339, 338);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 16;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 18;
            label1.Text = "CMND";
            label1.Click += label1_Click_2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 212);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 19;
            label6.Text = "Số Phòng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 321);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(18, 303);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 24;
            label8.Text = "Mã Đặt Phòng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(433, 124);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 25;
            label9.Text = "Mã Trả Phòng";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(435, 142);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(433, 186);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(102, 23);
            textBox7.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(435, 168);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 28;
            label10.Text = "Mã Phiếu DKDV";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(433, 230);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(102, 23);
            textBox8.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(435, 212);
            label11.Name = "label11";
            label11.Size = new Size(153, 15);
            label11.TabIndex = 30;
            label11.Text = "Mã Nhân Viên Thanh Toánn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(12, 256);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 31;
            label12.Text = "Số Tiền Thanh Toán";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(880, 390);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox8;
        private Label label11;
        private Label label12;
    }
}