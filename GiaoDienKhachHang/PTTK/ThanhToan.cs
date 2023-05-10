using PTTK_GIaoDien;
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

namespace GiaoDienKhachHang
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Connect();

            String cmnd = textBox2.Text.Trim();
            String cmnd_check = "SELECT COUNT(*) FROM DatPhong WHERE CMND = '" + cmnd + "'";
            SqlCommand c1 = new SqlCommand(cmnd_check, Connection.Con);
            int count = (int)c1.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Khách hàng không đặt phòng.");
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuDangKyDichVu WHERE CMND = '" + textBox2.Text.Trim() + "'", Connection.Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            listView1.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["PhiTamThoi"].ToString());
                item.SubItems.Add(row["NgayDangKy"].ToString());
                listView1.Items.Add(item);
            }
            listView1.FullRowSelect = true;

            int sum = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                int value;
                if (int.TryParse(item.SubItems[0].Text, out value))
                {
                    sum += value;
                }
            }

            cmd = new SqlCommand("SELECT * FROM DatPhong WHERE CMND = '" + textBox2.Text.Trim() + "'", Connection.Con);
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);

            string x = table.Rows[0]["SoDemLuuTru"].ToString();
            string maPhong = table.Rows[0]["MaPhong"].ToString();

            cmd = new SqlCommand("SELECT * FROM Phong WHERE MaPhong = '" + maPhong + "'", Connection.Con);
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);

            label5.Text = "Phòng " + maPhong + " - " + x + " Ngày";

            string giaPhong = table.Rows[0]["giaPhong"].ToString();

            float tienPhong = float.Parse(x) * float.Parse(giaPhong);

            textBox1.AppendText(tienPhong.ToString());

            textBox3.AppendText((sum + tienPhong).ToString());

            Connection.Disconnect();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.Connect();

            DateTime dat = dateTimePicker1.Value;
            String ngay = dat.ToString("yyyy-MM-dd");

            String query = "INSERT INTO ThanhToan(CMND,SoTienTT,NgayTT,PhuongThucTT) VALUES (@cmnd, @tien, @ngay, @hinhthuc);";
            // Create a SqlCommand object with the SQL statement and connection
            SqlCommand cmd = new SqlCommand(query, Connection.Con);

            // Add the parameters and their values
            cmd.Parameters.AddWithValue("@cmnd", textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@tien", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@hinhthuc", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@ngay", ngay);

            // Execute the command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thanh toán.");
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            Connection.Disconnect();
        }
    }
}
