using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PTTK
{
    internal class Program
    {
        public static string exactly_server_name = @"Data Source=DESKTOP-T10JEVT\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}