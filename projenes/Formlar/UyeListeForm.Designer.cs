namespace projenes.Formlar
{
    partial class UyeListeForm
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
            uyelerDataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)uyelerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // uyelerDataGrid
            // 
            uyelerDataGrid.AllowUserToAddRows = false;
            uyelerDataGrid.AllowUserToDeleteRows = false;
            uyelerDataGrid.AllowUserToOrderColumns = true;
            uyelerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uyelerDataGrid.Location = new Point(12, 60);
            uyelerDataGrid.Name = "uyelerDataGrid";
            uyelerDataGrid.ReadOnly = true;
            uyelerDataGrid.Size = new Size(964, 453);
            uyelerDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(712, 48);
            label1.TabIndex = 1;
            label1.Text = "GÖRKEN KÜTÜPHANESİ ÜYE LİSTESİ";
            // 
            // UyeListeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 525);
            Controls.Add(label1);
            Controls.Add(uyelerDataGrid);
            Name = "UyeListeForm";
            Text = "UyeListeForm";
            Load += UyeListeForm_Load;
            ((System.ComponentModel.ISupportInitialize)uyelerDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView uyelerDataGrid;
        private Label label1;
    }
}