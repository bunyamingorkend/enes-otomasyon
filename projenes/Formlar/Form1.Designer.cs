namespace projenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnUyeListele = new Button();
            btnUyeEkle = new Button();
            groupBox2 = new GroupBox();
            btnEmanet = new Button();
            btnEmanetListele = new Button();
            btnEmanetİşlemleri = new Button();
            groupBox3 = new GroupBox();
            btnKitapListele = new Button();
            btnKitapEkle = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(btnUyeListele);
            groupBox1.Controls.Add(btnUyeEkle);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(71, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            btnUyeListele.Location = new Point(28, 97);
            btnUyeListele.Name = "btnUyeListele";
            btnUyeListele.Size = new Size(301, 38);
            btnUyeListele.TabIndex = 1;
            btnUyeListele.Text = "Üye Listeleme İşlemleri";
            btnUyeListele.UseVisualStyleBackColor = true;
            btnUyeListele.Click += btnUyeListele_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(28, 38);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(301, 38);
            btnUyeEkle.TabIndex = 0;
            btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(btnEmanet);
            groupBox2.Controls.Add(btnEmanetListele);
            groupBox2.Controls.Add(btnEmanetİşlemleri);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(71, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 156);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanet
            // 
            btnEmanet.Location = new Point(40, 24);
            btnEmanet.Name = "btnEmanet";
            btnEmanet.Size = new Size(289, 35);
            btnEmanet.TabIndex = 3;
            btnEmanet.Text = "Kişiye Kitap Verme";
            btnEmanet.UseVisualStyleBackColor = true;
            btnEmanet.Click += btnEmanetVerme_Click;
            // 
            // btnEmanetListele
            // 
            btnEmanetListele.Location = new Point(40, 65);
            btnEmanetListele.Name = "btnEmanetListele";
            btnEmanetListele.Size = new Size(289, 35);
            btnEmanetListele.TabIndex = 2;
            btnEmanetListele.Text = "Emanet Kitap Listeleme İşlemleri";
            btnEmanetListele.UseVisualStyleBackColor = true;
            btnEmanetListele.Click += btnEmanetListele_Click;
            // 
            // btnEmanetİşlemleri
            // 
            btnEmanetİşlemleri.Location = new Point(40, 110);
            btnEmanetİşlemleri.Name = "btnEmanetİşlemleri";
            btnEmanetİşlemleri.Size = new Size(289, 35);
            btnEmanetİşlemleri.TabIndex = 1;
            btnEmanetİşlemleri.Text = "Emanet Kitap Iade İşlemleri\r\n";
            btnEmanetİşlemleri.UseVisualStyleBackColor = true;
            btnEmanetİşlemleri.Click += btnEmanetIadeIslemleri_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ScrollBar;
            groupBox3.Controls.Add(btnKitapListele);
            groupBox3.Controls.Add(btnKitapEkle);
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(617, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 158);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            btnKitapListele.Location = new Point(25, 97);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(301, 38);
            btnKitapListele.TabIndex = 2;
            btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            btnKitapListele.UseVisualStyleBackColor = true;
            btnKitapListele.Click += btnKitapListele_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(25, 38);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(301, 38);
            btnKitapEkle.TabIndex = 1;
            btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(265, 36);
            label1.Name = "label1";
            label1.Size = new Size(469, 48);
            label1.TabIndex = 4;
            label1.Text = "GÖRKEN KÜTÜPHANESİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1023, 569);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Ana Sayfa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnUyeListele;
        private Button btnUyeEkle;
        private Button btnEmanet;
        private Button btnEmanetListele;
        private Button btnEmanetİşlemleri;
        private Button btnKitapListele;
        private Button btnKitapEkle;
        private Label label1;
    }
}
