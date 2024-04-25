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
    public partial class UyeListeForm : Form
    {
        SqlDbConnection connect;
        public UyeListeForm()
        {
            InitializeComponent();
        }

        private void UyeListeForm_Load(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Uye", connect.Connect());
                da.Fill(dataTable: dt);
                uyelerDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }
    }
}
