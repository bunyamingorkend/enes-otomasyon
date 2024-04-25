using projenes.Connection;
using System.Data.SqlClient;
using System.Data;

namespace projenes.Formlar
{
    public partial class EmanetTeslimForm : Form
    {
        SqlDbConnection connect;

        public EmanetTeslimForm()
        {
            InitializeComponent();
            this.Load += EmanetTeslimForm_Load;

        }

        private void EmanetTeslimForm_Load(object sender, EventArgs e)
        {
            DataDoldur();
        }

        public void DataDoldur()
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Kitap", connect.Connect());
                da.Fill(dataTable: dt);
                kitaplarComboBox.DataSource = dt;
                kitaplarComboBox.DisplayMember = "KitapAdi";
                kitaplarComboBox.ValueMember = "Id";

                DataTable dt1 = new DataTable();

                SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_Uye", connect.Connect());
                da1.Fill(dataTable: dt1);

                uyelerComboBox.DataSource = dt1;
                uyelerComboBox.DisplayMember = "AdSoyad";
                uyelerComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            connect = new SqlDbConnection("LibraryDb");
            try
            {
                string Id = Guid.NewGuid().ToString();
                SqlDataAdapter daInsert = new SqlDataAdapter();
                string command = ($"INSERT INTO tbl_Emanet (Id, TeslimAlan, TeslimAlanId, KitapAdi, KitapId, TeslimTarihi, IadeEdildiMi,TeslimSuresi) VALUES ('{Id}','{uyelerComboBox.Text}', '{uyelerComboBox.SelectedValue}', '{kitaplarComboBox.Text}','{kitaplarComboBox.SelectedValue}','{verilmeTarihiDatePicker.Value}','{false}','{teslimSureNumeric.Value}')");
                daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
                daInsert.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Emanet Verildi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
