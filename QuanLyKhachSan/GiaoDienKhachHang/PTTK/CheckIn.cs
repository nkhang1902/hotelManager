using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTK
{
    public partial class CheckIn : Form
    {
        int a;
        public CheckIn()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madp = textBox1.Text.Trim();
            string cmnd = textBox3.Text.Trim();
            string nvci = textBox5.Text.Trim();
            if (string.IsNullOrEmpty(madp) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(nvci))
            {
                MessageBox.Show("Vui long dien du thong tin (CMND, Ma dat phong, Nhan vien check in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string connectionString = Program.exactly_server_name;
                string query = "SET IDENTITY_INSERT PhieuDangKyCheckIn ON insert into PhieuDangKyCheckIn(MAPDKC,CMND,MaNV,YeuCau,NgayNhanPhong,VanChuyen, MaDP) values (dbo.TaoMaPDKCheckIn(),'" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + a + "','" + textBox1.Text + "') SET IDENTITY_INSERT PhieuDangKyCheckIn OFF";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show($"Ma dat phong {madp} check in thanh cong.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Loi check in ma dat phong {madp}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            textBox2.Text = formattedDate;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.exactly_server_name;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string selectQuery = "Select * from DatPhong where MaDP = ('" + textBox1.Text + "')";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Co")
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
        }
    }
}