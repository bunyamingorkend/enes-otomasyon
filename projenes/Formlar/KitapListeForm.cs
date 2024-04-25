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
    public partial class KitapListeForm : Form
    {
        SqlDbConnection connect;
        public KitapListeForm()
        {
            InitializeComponent();
        }

        private void KitapListeForm_Load(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Kitap", connect.Connect());
                da.Fill(dataTable: dt);
                kitapListeDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void kitapListeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
