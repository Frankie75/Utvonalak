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

namespace Utvonalak
{
    public partial class frmUj : Form
    {
        static public string ConnectionString;

        public frmUj(string c)
        {
            InitializeComponent();
            ConnectionString = c;
        }

        private void btnUjfelvetele_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            Int32.TryParse(tbId.Text, out int tbid);
            var adapter = new SqlDataAdapter()
            {
                InsertCommand = new SqlCommand(
                    "INSERT INTO turazo VALUES " +
                    $"( {tbid},'{tbVezeteknev.Text}','{tbKeresztnev.Text}', " +
                    $"'{tbVaros.Text}','{tbTelefon.Text}');", conn),
            };
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
            this.Close();   
        }

        private void frmUj_Load(object sender, EventArgs e)
        {

        }
    }
}
