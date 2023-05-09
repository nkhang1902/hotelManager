using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Project
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(224, 224, 224); // this should be pink-ish


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "data source=DESKTOP-43417JJ\\SQLEXPRESS;initial catalog=QLKhachSan;trusted_connection=true";
                string Name = textBox1.Text;
                string CMND = textBox2.Text;
                string PaymentSum = textBox4.Text;
                string CheckInCode = textBox5.Text;
                string CheckOutCode = textBox6.Text;
                string ServiceCode = textBox7.Text;
                string PaymentEmpCode = textBox8.Text;
                String query = "SET IDENTITY_INSERT HoaDon ON\r\n\r\nINSERT INTO HoaDon \r\n    (MaHD, CMND, MaNV, TienThanhToan, MaDP, MATP, MAPDKDV)\r\nVALUES \r\n    ('1','"+CMND+"','"+PaymentEmpCode+"','"+PaymentSum+"','"+CheckInCode+"','"+CheckOutCode+"','"+ServiceCode+"')\r\n\r\nSET IDENTITY_INSERT HoaDon OFF";
                //String query = "SET IDENTITY_INSERT HoaDon ON\r\n\r\nINSERT INTO HoaDon \r\n    (MaHD, CMND, MaNV, TienThanhToan, MaDP, MATP, MAPDKDV)\r\nVALUES \r\n    ('1','1','1','110000','1','1','1')\r\n\r\nSET IDENTITY_INSERT HoaDon OFF";
                String query2 = "";
                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);


                con.Open();

                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh Toán Hoàn Tất");
                con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}