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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class QuanLyDatPhong : Form
    {
        public QuanLyDatPhong()
        {
            InitializeComponent();
            layDatPhong();
        }
        private void layDatPhong()
        {
            Connection.Connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DatPhong", Connection.Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            listView1.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["CMND"].ToString());
                item.SubItems.Add(row["MaPhong"].ToString());
                item.SubItems.Add(row["SoLuongNguoi"].ToString());
                item.SubItems.Add(row["SoDemLuuTru"].ToString());
                item.SubItems.Add(row["NgayDP"].ToString());
                item.SubItems.Add(row["TienCoc"].ToString());
                listView1.Items.Add(item);
            }
            listView1.FullRowSelect = true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyPhong phong = new QuanLyPhong();
            if (phong.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Connection.Connect();
                string cmnd = listView1.SelectedItems[0].SubItems[0].Text;
                string phong = listView1.SelectedItems[0].SubItems[1].Text;
                string query = "DELETE FROM DatPhong WHERE CMND = @cmnd AND MaPhong = @phong";
                SqlCommand cmd = new SqlCommand(query, Connection.Con);
                cmd.Parameters.AddWithValue("@cmnd", cmnd);
                cmd.Parameters.AddWithValue("@phong", phong);

                try
                {
                    
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đã xóa đặt phòng.");
                        // remove the selected item from the listView
                        listView1.SelectedItems[0].Remove();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Connection.Connect();

            string ngayDat = listView1.SelectedItems[0].SubItems[4].Text;
            DateTime dat = DateTime.Parse(ngayDat);
            ngayDat = dat.ToString("yyyy-MM-dd");

            string soNgay = listView1.SelectedItems[0].SubItems[3].Text;
            int soNgayInt = int.Parse(soNgay);

            DateTime tra = dat.AddDays(soNgayInt);
            string ngayTra = tra.ToString("yyyy-MM-dd");

            if (dat.Year > tra.Year || (dat.Year == tra.Year && dat.Month > tra.Month) || (dat.Year == tra.Year && dat.Month == tra.Month && dat.Day > tra.Day))
            {
                MessageBox.Show("Ngày đặt và trả không hợp lệ.");
                return;
            }


            String time_check = "SELECT COUNT(*) FROM KhachDat WHERE (NgayTra > '" + ngayDat + "' AND MaPhongDat ='" + listView1.SelectedItems[0].SubItems[1].Text + "')";
            SqlCommand timecheck = new SqlCommand(time_check, Connection.Con);
            int count = (int)timecheck.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Đã có khách đặt chưa trả phòng vào ngày này.");
                return;
            }

            String cmnd = listView1.SelectedItems[0].SubItems[0].Text;
            String cmnd_check = "SELECT COUNT(*) FROM KhachHang WHERE CMND = '" + cmnd + "'";
            SqlCommand c1 = new SqlCommand(cmnd_check, Connection.Con);
            count = (int)c1.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("CMND của khách hàng không tồn tại.");
                return;
            }

            String phong = listView1.SelectedItems[0].SubItems[1].Text;
            String phong_check = "SELECT COUNT(*) FROM Phong WHERE MaPhong = '" + phong + "'";
            SqlCommand c2 = new SqlCommand(cmnd_check, Connection.Con);
            count = (int)c2.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Phòng không tồn tại.");
                return;
            }


            String query = "INSERT INTO KhachDat(CMND,MaPhongDat,NgayDat,NgayTra) VALUES (@cmnd, @phong, @ngaydat, @ngaytra);";
            // Create a SqlCommand object with the SQL statement and connection
            SqlCommand cmd = new SqlCommand(query, Connection.Con);

            // Add the parameters and their values
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@phong", phong);
            cmd.Parameters.AddWithValue("@ngaydat", ngayDat);
            cmd.Parameters.AddWithValue("@ngaytra", ngayTra);

            // Execute the command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xếp phòng thành công!!");
            Connection.Disconnect();
        }
    }
}
