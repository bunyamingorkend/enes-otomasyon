using projenes.Connection;
using System.Data.SqlClient;

namespace projenes;

public partial class UyeEkleForm : Form
{
    SqlDbConnection connect;
    public UyeEkleForm()
    {
        InitializeComponent();
    }

    private void UyeEkleForm_Load(object sender, EventArgs e)
    {

    }

    private void btnUyeEkle_Click(object sender, EventArgs e)
    {
        connect = new SqlDbConnection("LibraryDb");
        try
        {
            string Id = Guid.NewGuid().ToString();
            SqlDataAdapter daInsert = new SqlDataAdapter();
            string command = ($"INSERT INTO tbl_Uye (Id,Tc, AdSoyad, Yas, Cinsiyet, Telefon, Adres,EPosta,OkunanKitap) VALUES ('{Id}','{txtTc.Text}', '{txtAdSoyad.Text}', '{txtYas.Text}', '{comboCinsiyet.SelectedItem}','{txtTelefon.Text}','{txtAdres.Text}','{txtEmail.Text}','{txtOkunanSayi.Text}' )");
            daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
            daInsert.InsertCommand.ExecuteNonQuery();//yazılan sorgu çalıştırıldı
            MessageBox.Show("Kayıt Başarılı, Giriiş Yapabilirsiniz.");

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
