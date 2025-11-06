namespace SinemaOtomasyonu.UI.Forms.MusteriForms
{
    partial class FormMusteriListesi
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
            dgvMusteriler = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMusteriler.Location = new System.Drawing.Point(0, 0);
            dgvMusteriler.MainView = gridView1;
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new System.Drawing.Size(800, 450);
            dgvMusteriler.TabIndex = 0;
            dgvMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dgvMusteriler;
            gridView1.Name = "gridView1";
            // 
            // FormMusteriListesi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvMusteriler);
            Name = "FormMusteriListesi";
            Text = "Müşteriler Listesi";
            Load += FormMusteriListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}