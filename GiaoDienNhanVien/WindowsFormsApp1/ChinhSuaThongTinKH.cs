using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachHang
{

    public partial class ChinhSuaThongTin : Form
    {
        public string Doan = "null";
        public ChinhSuaThongTin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            string CMND = "Select CMND from KhachHang where CMND = '" + textBox2.Text + "'";
            string bufferCMND = Connection.GetFieldValues(CMND).Trim();
            if (bufferCMND != "")
            {
                MessageBox.Show("Mã CMND đã tồn tại !!!");
            }
            else
            {
                string sql1 = "Select CMND from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql2 = "Select HoTenKH from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql3 = "Select DiaChiKH from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql4 = "Select EmailKH from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql5 = "Select NgaySinhKH from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql7 = "Select SdtKH from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql6 = "Select SoFAX from KhachHang where CMND = '" + textBox9.Text + "'";
                string sql8 = "Select MaDoan from KhachHang where CMND = '" + textBox9.Text + "'";
                textBox1.Text = Connection.GetFieldValues(sql1).Trim();
                textBox2.Text = Connection.GetFieldValues(sql2).Trim();
                textBox3.Text = Connection.GetFieldValues(sql3).Trim();
                textBox4.Text = Connection.GetFieldValues(sql4).Trim();
                textBox5.Text = Connection.GetFieldValues(sql5).Trim();
                textBox6.Text = Connection.GetFieldValues(sql6).Trim();
                textBox7.Text = Connection.GetFieldValues(sql7).Trim();
                textBox8.Text = Connection.GetFieldValues(sql8).Trim();
                Doan = Connection.GetFieldValues(sql8).Trim();
                Connection.Disconnect();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            string MaDoan = "Select MaDoan from Doan where MaDoan = '" + textBox8.Text + "'";
            string bufferDoan = Connection.GetFieldValues(MaDoan).Trim();
            if (textBox1.Text != textBox9.Text)
            {
                MessageBox.Show("Không được thay đổi CMND");
                textBox1.Text = textBox9.Text;
            }
            else if (bufferDoan == "" && textBox8.Text != "")
            {
                MessageBox.Show("Mã Đoàn không tồn tại !!!");
                textBox8.Text = Doan;
            }
            else
            {
                Doan = bufferDoan;
                if (Doan == "")
                {
                    string sql = ("update KhachHang set HoTenKH = '" + textBox2.Text + "', DiaChiKH = '" + textBox3.Text + "', EmailKH = '" + textBox4.Text + "', NgaySinhKH = '" + textBox5.Text + "', SdtKH = '" + textBox7.Text + "',SoFAX = '" + textBox6.Text + "'where CMND = '" + textBox9.Text + "'");
                    Connection.RunSQL(sql);
                    MessageBox.Show("Update thàng thành công");
                }
                else
                {
                    string sql = "update KhachHang set HoTenKH='" + textBox2.Text + "', DiaChiKH='" + textBox3.Text + "', EmailKH='" + textBox4.Text + "', NgaySinhKH= '" + textBox5.Text + "', SdtKH='" + textBox7.Text + "',SoFAX= '" + textBox6.Text + "', MaDoan='" + textBox8.Text + "' where CMND = '" + textBox9.Text + "'";
                    Connection.RunSQL(sql);
                    MessageBox.Show("Update thàng thành công");
                }
            }
        }
    }
}
