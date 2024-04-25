using projenes.Connection;
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

namespace projenes.Formlar
{
    public partial class EmanetlerListeForm : Form
    {
        SqlDbConnection connect;

        public EmanetlerListeForm()
        {
            InitializeComponent();
        }

        private void EmanetlerListeForm_Load(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Emanet", connect.Connect());
                da.Fill(dataTable: dt);
                emanetDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }
    }
}
