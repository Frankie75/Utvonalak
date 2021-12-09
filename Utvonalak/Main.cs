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
    public partial class Main : Form
    {
        static public string ConnectionString = @"Data source=(localdb)\MSSQLLocalDB;Initial Catalog = C:\USERS\FRANKIE\SOURCE\REPOS\UTVONALAK\UTVONALAK\TURAUTVONALAK.MDF";

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        void refreshDGV()
        {
            dgvMain.Rows.Clear();
            var conn = new SqlConnection(ConnectionString);
            var command = new SqlCommand("select * from turazo;", conn);
            conn.Open();
            var r = command.ExecuteReader();
            while (r.Read())
            {

                dgvMain.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
            }
            r.Close();
            conn.Close();
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvMain.SelectedRows[0].Cells[0].Value;
            frmKivalasztott frm = new frmKivalasztott(ConnectionString,id); 
         
            frm.Show();

            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            refreshDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUj f = new frmUj(ConnectionString);
            f.Show();
        }
    }
}
