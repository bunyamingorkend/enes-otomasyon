namespace projenes.Formlar
{
    partial class EmanetTeslimForm
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
            uyelerComboBox = new ComboBox();
            kitaplarComboBox = new ComboBox();
            verilmeTarihiDatePicker = new DateTimePicker();
            btnİptal = new Button();
            btnEmanetVer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            teslimSureNumeric = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)teslimSureNumeric).BeginInit();
            SuspendLayout();
            // 
            // uyelerComboBox
            // 
            uyelerComboBox.FormattingEnabled = true;
            uyelerComboBox.Location = new Point(145, 27);
            uyelerComboBox.Name = "uyelerComboBox";
            uyelerComboBox.Size = new Size(297, 23);
            uyelerComboBox.TabIndex = 0;
            // 
            // kitaplarComboBox
            // 
            kitaplarComboBox.FormattingEnabled = true;
            kitaplarComboBox.Location = new Point(145, 69);
            kitaplarComboBox.Name = "kitaplarComboBox";
            kitaplarComboBox.Size = new Size(298, 23);
            kitaplarComboBox.TabIndex = 1;
            // 
            // verilmeTarihiDatePicker
            // 
            verilmeTarihiDatePicker.Location = new Point(146, 106);
            verilmeTarihiDatePicker.Name = "verilmeTarihiDatePicker";
            verilmeTarihiDatePicker.Size = new Size(297, 23);
            verilmeTarihiDatePicker.TabIndex = 2;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(253, 210);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 34);
            btnİptal.TabIndex = 37;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnEmanetVer
            // 
            btnEmanetVer.Location = new Point(117, 210);
            btnEmanetVer.Name = "btnEmanetVer";
            btnEmanetVer.Size = new Size(75, 34);
            btnEmanetVer.TabIndex = 36;
            btnEmanetVer.Text = "Ekle";
            btnEmanetVer.UseVisualStyleBackColor = true;
            btnEmanetVer.Click += btnEmanetVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 38;
            label1.Text = "Teslim Edilen Kişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(74, 67);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 39;
            label2.Text = "Kitap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(74, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 40;
            label3.Text = "Tarih";
            // 
            // teslimSureNumeric
            // 
            teslimSureNumeric.Location = new Point(146, 145);
            teslimSureNumeric.Name = "teslimSureNumeric";
            teslimSureNumeric.Size = new Size(298, 23);
            teslimSureNumeric.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 145);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 42;
            label4.Text = "Teslim Süresi";
            // 
            // EmanetTeslimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(482, 450);
            Controls.Add(label4);
            Controls.Add(teslimSureNumeric);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnEmanetVer);
            Controls.Add(verilmeTarihiDatePicker);
            Controls.Add(kitaplarComboBox);
            Controls.Add(uyelerComboBox);
            ForeColor = SystemColors.InfoText;
            Name = "EmanetTeslimForm";
            Text = "EmanetTeslimForm";
            Load += EmanetTeslimForm_Load;
            ((System.ComponentModel.ISupportInitialize)teslimSureNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox uyelerComboBox;
        private ComboBox kitaplarComboBox;
        private DateTimePicker verilmeTarihiDatePicker;
        private Button btnİptal;
        private Button btnEmanetVer;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown teslimSureNumeric;
        private Label label4;
    }
}