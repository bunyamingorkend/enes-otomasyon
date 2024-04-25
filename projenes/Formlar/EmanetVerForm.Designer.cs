namespace projenes.Formlar
{
    partial class EmanetVerForm
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
            emanetKisiComboBox = new ComboBox();
            label1 = new Label();
            btnKisiEmanetleri = new Button();
            emanetlerListBox = new ListBox();
            label2 = new Label();
            iadeAlBtn = new Button();
            iptalBtn = new Button();
            SuspendLayout();
            // 
            // emanetKisiComboBox
            // 
            emanetKisiComboBox.FormattingEnabled = true;
            emanetKisiComboBox.Location = new Point(115, 22);
            emanetKisiComboBox.Name = "emanetKisiComboBox";
            emanetKisiComboBox.Size = new Size(273, 23);
            emanetKisiComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Teslim Eden Kişi";
            // 
            // btnKisiEmanetleri
            // 
            btnKisiEmanetleri.BackColor = SystemColors.Info;
            btnKisiEmanetleri.Location = new Point(413, 21);
            btnKisiEmanetleri.Name = "btnKisiEmanetleri";
            btnKisiEmanetleri.Size = new Size(149, 23);
            btnKisiEmanetleri.TabIndex = 2;
            btnKisiEmanetleri.Text = "Kişideki Kitapları Göster";
            btnKisiEmanetleri.UseVisualStyleBackColor = false;
            btnKisiEmanetleri.Click += btnKisiEmanetleri_Click;
            // 
            // emanetlerListBox
            // 
            emanetlerListBox.FormattingEnabled = true;
            emanetlerListBox.ItemHeight = 15;
            emanetlerListBox.Location = new Point(12, 102);
            emanetlerListBox.Name = "emanetlerListBox";
            emanetlerListBox.Size = new Size(548, 139);
            emanetlerListBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 69);
            label2.Name = "label2";
            label2.Size = new Size(234, 30);
            label2.TabIndex = 4;
            label2.Text = "Kişideki Emanet Kitaplar";
            // 
            // iadeAlBtn
            // 
            iadeAlBtn.Location = new Point(127, 259);
            iadeAlBtn.Name = "iadeAlBtn";
            iadeAlBtn.Size = new Size(75, 23);
            iadeAlBtn.TabIndex = 5;
            iadeAlBtn.Text = "Iade Al";
            iadeAlBtn.UseVisualStyleBackColor = true;
            iadeAlBtn.Click += iadeAlBtn_Click;
            // 
            // iptalBtn
            // 
            iptalBtn.Location = new Point(346, 259);
            iptalBtn.Name = "iptalBtn";
            iptalBtn.Size = new Size(75, 23);
            iptalBtn.TabIndex = 6;
            iptalBtn.Text = "Iptal";
            iptalBtn.UseVisualStyleBackColor = true;
            iptalBtn.Click += iptalBtn_Click;
            // 
            // EmanetVerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(579, 450);
            Controls.Add(iptalBtn);
            Controls.Add(iadeAlBtn);
            Controls.Add(label2);
            Controls.Add(emanetlerListBox);
            Controls.Add(btnKisiEmanetleri);
            Controls.Add(label1);
            Controls.Add(emanetKisiComboBox);
            Name = "EmanetVerForm";
            Text = "EmanetVerForm";
            Load += EmanetVerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox emanetKisiComboBox;
        private Label label1;
        private Button btnKisiEmanetleri;
        private ListBox emanetlerListBox;
        private Label label2;
        private Button iadeAlBtn;
        private Button iptalBtn;
    }
}