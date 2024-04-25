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
    public partial class KitapEkleForm : Form
    {
        SqlDbConnection connect;

        public KitapEkleForm()
        {
            InitializeComponent();
        }


        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                string Id = Guid.NewGuid().ToString();
                SqlDataAdapter daInsert = new SqlDataAdapter();
                string command = ($"INSERT INTO tbl_Kitap (Id, KitapAdi, Yazar, Kategori) VALUES ('{Id}','{txtAd.Text}', '{txtYazar.Text}', '{comboKategori.SelectedItem}')");
                daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
                daInsert.InsertCommand.ExecuteNonQuery();//yazılan sorgu çalıştırıldı
                MessageBox.Show("Kayıt Başarılı.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
