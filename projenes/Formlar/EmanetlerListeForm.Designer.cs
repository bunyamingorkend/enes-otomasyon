namespace projenes.Formlar
{
    partial class EmanetlerListeForm
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
            emanetDataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)emanetDataGrid).BeginInit();
            SuspendLayout();
            // 
            // emanetDataGrid
            // 
            emanetDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emanetDataGrid.Location = new Point(12, 73);
            emanetDataGrid.Name = "emanetDataGrid";
            emanetDataGrid.Size = new Size(848, 365);
            emanetDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(795, 48);
            label1.TabIndex = 2;
            label1.Text = "GÖRKEN KÜTÜPHANESİ EMANET LİSTESİ";
            // 
            // EmanetlerListeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(label1);
            Controls.Add(emanetDataGrid);
            Name = "EmanetlerListeForm";
            Text = "EmanetlerListeForm";
            Load += EmanetlerListeForm_Load;
            ((System.ComponentModel.ISupportInitialize)emanetDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView emanetDataGrid;
        private Label label1;
    }
}