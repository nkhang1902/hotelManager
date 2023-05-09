using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTTK
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void AddCartCollumn()
        {
            dataGridView3.Columns.Add("MaDV", "MaDV");
            dataGridView3.Columns.Add("TenDichVu", "TenDichVu");
            dataGridView3.Columns.Add("GiaDV", "GiaDV");
        }

        private void updateTotalPrice()
        {
            decimal totalPrice = 0;

            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                decimal price;
                if (decimal.TryParse(row.Cells["GiaDV"].Value.ToString(), out price))
                {
                    totalPrice += price;
                }
            }

            textBox3.Text = totalPrice.ToString(); ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Program.exactly_server_name;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (comboBox1.SelectedItem.ToString() == "TatCa")
            {
                string selectQuery = "Select * from DichVu";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
                connection.Close();
            }
            if (comboBox1.SelectedItem.ToString() == "DVKhachSan")
            {
                string selectQuery = "Select * from DichVu where LoaiDV = 0";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
                connection.Close();
            }
            if (comboBox1.SelectedItem.ToString() == "DVDoiTac")
            {
                string selectQuery = "Select * from DichVu where LoaiDV = 1";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
                connection.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.exactly_server_name;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string selectQuery = "Select dvp.MaDV, dv.TenDichVu, dv.Mota from DVPhong dvp, DichVu dv where dvp.MaDV=dv.MaDV and MaPhong = ('" + textBox1.Text + "')";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Create a new row in the cart data grid view
                DataGridViewRow newRow = new DataGridViewRow();

                // Set the values of the new row's cells to match the selected row from the menu data grid view
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells["MaDV"].Value });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells["TenDichVu"].Value });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells["GiaDV"].Value });

                // Add the new row to the cart data grid view
                dataGridView3.Rows.Add(newRow);
            }
            updateTotalPrice();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            AddCartCollumn();
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            textBox2.Text = formattedDate;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];

                // Remove the selected row from the cart data grid view
                dataGridView3.Rows.Remove(selectedRow);

                // Recalculate the total price
                updateTotalPrice();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            updateTotalPrice();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ngaydangki = textBox2.Text.Trim();
            string cmnd = textBox5.Text.Trim();
            string nvdkdv = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(nvdkdv))
            {
                MessageBox.Show("Vui long dien du thong tin (CMND, Nhan vien dang ky dich vu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string connectionString = Program.exactly_server_name;
                string query = "SET IDENTITY_INSERT PhieuDangKyDichVu ON " + 
                    "DECLARE @newID INT "+ "SET @newID = dbo.TaoMaPDKDichVu() " +
                    "insert into PhieuDangKyDichVu(MAPDKDV,CMND,MaNV,PhiTamThoi,NgayDangKy) values (@newID,'" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "') SET IDENTITY_INSERT PhieuDangKyDichVu OFF ";
                string query2 ="DECLARE @newID INT " +
                           "SET @newID = dbo.TaoMaPDKDichVu() - 1 "
                           + "INSERT INTO ChiTietDichVuDangKy (MAPDKDV, MaDV, GiaDV) VALUES (@newID, @MaDV, @GiaDV)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(query2, conn))
                    {
                        // Add parameters to the command object
                        command.Parameters.Add("@MaDV", SqlDbType.NVarChar);
                        command.Parameters.Add("@GiaDV", SqlDbType.Decimal);

                        // Loop through each row in the cart data grid view
                        for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                        {
                            // Get the ID and Price values from the current row
                            string ID = dataGridView3.Rows[i].Cells["MaDV"].Value.ToString();
                            decimal Price = decimal.Parse(dataGridView3.Rows[i].Cells["GiaDV"].Value.ToString());

                            // Set the parameter values for the current row
                            command.Parameters["@MaDV"].Value = ID;
                            command.Parameters["@GiaDV"].Value = Price;

                            // Execute the SQL command
                            command.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
                
                MessageBox.Show($"Dang dich vu thanh cong.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
