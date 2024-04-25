namespace projenes.Formlar
{
    partial class KitapEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnİptal = new Button();
            btnKitapEkle = new Button();
            label2 = new Label();
            label1 = new Label();
            txtYazar = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            comboKategori = new ComboBox();
            SuspendLayout();
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(132, 151);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 34);
            btnİptal.TabIndex = 35;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(28, 151);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(75, 34);
            btnKitapEkle.TabIndex = 34;
            btnKitapEkle.Text = "Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 27;
            label2.Text = "Yazarı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 26;
            label1.Text = "Kitap Adı";
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtYazar.ForeColor = SystemColors.ScrollBar;
            txtYazar.Location = new Point(104, 62);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(180, 25);
            txtYazar.TabIndex = 19;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAd.ForeColor = SystemColors.ScrollBar;
            txtAd.Location = new Point(104, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 25);
            txtAd.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 106);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 37;
            label4.Text = "Cinsiyet";
            // 
            // comboKategori
            // 
            comboKategori.Items.AddRange(new object[] { "Roman", "Polisiye/Gizem", "Bilim Kurgu", "Korku/Gerilim", "Biyografi/Otomobil", "Tarih", "Felsefe", "Psikoloji", "Bilim ve Teknoloji", "Edebiyat Eleştirisi", "Macera", "Fantastik", "Genç Yetişkin", "Çocuk Kitapları", "İş ve Kariye" });
            comboKategori.Location = new Point(104, 103);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(201, 23);
            comboKategori.SelectedIndex = 0;
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKategori.TabIndex = 36;
            // 
            // KitapEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(334, 450);
            Controls.Add(label4);
            Controls.Add(comboKategori);
            Controls.Add(btnİptal);
            Controls.Add(btnKitapEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYazar);
            Controls.Add(txtAd);
            Name = "KitapEkleForm";
            Text = "KitapEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnİptal;
        private Button btnKitapEkle;
        private Label label2;
        private Label label1;
        private TextBox txtYazar;
        private TextBox txtAd;
        private Label label4;
        private ComboBox comboKategori;
    }
}