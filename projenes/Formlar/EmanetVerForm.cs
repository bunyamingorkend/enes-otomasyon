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
    public partial class EmanetVerForm : Form
    {
        SqlDbConnection connect;

        public EmanetVerForm()
        {
            InitializeComponent();
        }

        private void EmanetVerForm_Load(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                DataTable dt1 = new DataTable();

                SqlDataAdapter da1 = new SqlDataAdapter("Select DISTINCT TeslimAlanId, TeslimAlan from tbl_Emanet", connect.Connect());
                da1.Fill(dataTable: dt1);

                emanetKisiComboBox.DataSource = dt1;
                emanetKisiComboBox.DisplayMember = "TeslimAlan";
                emanetKisiComboBox.ValueMember = "TeslimAlanId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnKisiEmanetleri_Click(object sender, EventArgs e)
        {

            connect = new SqlDbConnection("LibraryDb");
            try
            {
                if (emanetKisiComboBox.SelectedValue is null)
                {
                    MessageBox.Show("Kitap Seçin.");
                    return;
                }
                DataTable dt1 = new DataTable();

                SqlDataAdapter da1 = new SqlDataAdapter($"SELECT * FROM tbl_Emanet WHERE TeslimAlanId = '{emanetKisiComboBox.SelectedValue}'", connect.Connect());
                da1.Fill(dt1);

                foreach (DataRow row in dt1.Rows)
                {
                    emanetlerListBox.Items.Add(row["KitapAdi"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void iadeAlBtn_Click(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");

            try
            {
                if (emanetlerListBox.SelectedItem is null)
                {
                    MessageBox.Show("Kitap Seçin.");
                    return;
                }
                SqlDataAdapter daInsert = new SqlDataAdapter();
                string command = ($"UPDATE tbl_Emanet SET IadeEdildiMi = 'true' WHERE TeslimAlanId = '{emanetKisiComboBox.SelectedValue}' and KitapAdi = '{emanetlerListBox.SelectedItem}'");
                daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
                daInsert.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Iade Verildi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
