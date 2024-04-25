using projenes.Formlar;

namespace projenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkleForm form = new UyeEkleForm();
            form.Show();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListeForm form = new UyeListeForm();
            form.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleForm form = new KitapEkleForm();
            form.Show();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListeForm form = new KitapListeForm();
            form.Show();
        }

        private void btnEmanetIadeIslemleri_Click(object sender, EventArgs e)
        {
            EmanetVerForm form = new EmanetVerForm();
            form.Show();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetlerListeForm form = new EmanetlerListeForm();
            form.Show();
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {
            EmanetTeslimForm form = new EmanetTeslimForm();
            form.Show();
        }
    }
}
