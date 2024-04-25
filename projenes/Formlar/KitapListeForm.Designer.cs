namespace projenes.Formlar
{
    partial class KitapListeForm
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
            kitapListeDataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kitapListeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // kitapListeDataGrid
            // 
            kitapListeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitapListeDataGrid.Location = new Point(14, 108);
            kitapListeDataGrid.Name = "kitapListeDataGrid";
            kitapListeDataGrid.Size = new Size(474, 250);
            kitapListeDataGrid.TabIndex = 0;
            kitapListeDataGrid.CellContentClick += kitapListeDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(480, 96);
            label1.TabIndex = 2;
            label1.Text = "GÖRKEN KÜTÜPHANESİ \r\n        KİTAP  LİSTESİ";
            // 
            // KitapListeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 378);
            Controls.Add(label1);
            Controls.Add(kitapListeDataGrid);
            Name = "KitapListeForm";
            Text = "KitapListeForm";
            Load += KitapListeForm_Load;
            ((System.ComponentModel.ISupportInitialize)kitapListeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView kitapListeDataGrid;
        private Label label1;
    }
}