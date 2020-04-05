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
using AtYarisiYeni.Helpers;

namespace AtYarisiYeni
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectionHelper connection = new ConnectionHelper();
            string sqlDurum = "SELECT * FROM dbo.Durum WITH(NOLOCK)";
            string sqlBahisciler = "SELECT * FROM dbo.Bahisciler WITH(NOLOCK)";
            SqlDataAdapter sqlDataDurum = new SqlDataAdapter(sqlDurum, connection.con);
            DataTable durumDataTable = new DataTable();
            sqlDataDurum.Fill(durumDataTable);
            dtDurum.DataSource = durumDataTable;

            SqlDataAdapter sqlDataBahisciler = new SqlDataAdapter(sqlBahisciler, connection.con);
            DataTable bahiscilerDataTable = new DataTable();
            sqlDataBahisciler.Fill(bahiscilerDataTable);
            dtBahisciler.DataSource = bahiscilerDataTable;

        }
    }
}
