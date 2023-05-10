using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_GIaoDien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "" || guna2TextBox6.Text == "" || guna2TextBox7.Text == "" || guna2DateTimePicker1.Text.Length == 0)
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin");
            }
            else
            {
                Connection.Connect();
                //string sql = "insert into KhachHang(CMND, DiaChiKH, EmailKH, HoTenKH, NgaySinhKH, SdtKH, SoFAX) values('" + guna2TextBox7.Text + "', '" + guna2TextBox4.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox1.Text + "', CONVERT(DATE,'" + guna2DateTimePicker1.Text + "' ,105)" + ", " + guna2TextBox2.Text + ", " + guna2TextBox6.Text + ");";
                try
                {
                    //sql = "IF EXISTS(SELect 1 FROM Doan WHERE MaDoan = '" + 1 + "' SELECT 'MaDoan exists.'ELSE SELECT 'MaDoan does not exist.'; ";
                    string sql = "select * from Doan where MaDoan = '" + guna2TextBox5.Text + "';";
                    Connection.RunSQL(sql);
                    if (guna2TextBox5.Text == "")
                    {
                        try
                        {
                            sql = "insert into KhachHang(CMND, DiaChiKH, EmailKH, HoTenKH, NgaySinhKH, SdtKH, SoFAX) values('" + guna2TextBox7.Text + "', '" + guna2TextBox4.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox1.Text + "', CONVERT(DATE,'" + guna2DateTimePicker1.Text + "' ,105)" + ", " + guna2TextBox2.Text + ", " + guna2TextBox6.Text + ");";
                            Connection.RunSQL(sql);
                            MessageBox.Show("Them du lieu thanh cong");
                        }
                        catch
                        {
                            MessageBox.Show("Them du lieu khong thanh cong");
                        }
                    }
                    else
                    {
                        if (Connection.GetFieldValues(sql) == "")
                        {
                            MessageBox.Show("Ma Doan khong ton tai");
                        }
                        else
                        {
                            try
                            {
                                sql = "insert into KhachHang(CMND, DiaChiKH, EmailKH, HoTenKH, NgaySinhKH, SdtKH, SoFAX) values('" + guna2TextBox7.Text + "', '" + guna2TextBox4.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox1.Text + "', CONVERT(DATE,'" + guna2DateTimePicker1.Text + "' ,105)" + ", " + guna2TextBox2.Text + ", " + guna2TextBox6.Text + ", " + guna2TextBox5.Text + ");";
                                Connection.RunSQL(sql);
                                MessageBox.Show("Them du lieu thanh cong");
                            }
                            catch
                            {
                                MessageBox.Show("Them du lieu khong thanh cong");
                            }
                        }
                    }
                }
                catch
                {



                }
            }
        }
    }
}
