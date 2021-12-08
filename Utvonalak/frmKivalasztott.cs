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
    public partial class frmKivalasztott : Form
    {
        static public string ConnectionString;
        public int tid;
        public frmKivalasztott(string c, int id)
        {
            InitializeComponent();
            ConnectionString= c;  
            tid= id;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            int osszeskilometer = 0;

            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var sqlCommand = new SqlCommand(
                "select honnan, hova, km " +
                "from utvonal " +
                $"where turazoID={tid}", conn);
            var r=sqlCommand.ExecuteReader();

            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2]);
                osszeskilometer += (int)r[2];
            }
            r.Close();
            conn.Close();
            osszesKm.Text = osszeskilometer.ToString();
            jutalompontOsszeg.Text = (osszeskilometer/20).ToString();  
        }
    }
}
