namespace SinemaOtomasyonu.UI.Forms
{
    partial class FormFilmEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmEkle));
            lblFilmAdi = new DevExpress.XtraEditors.LabelControl();
            lblFilmTuru = new DevExpress.XtraEditors.LabelControl();
            lblFilmSuresi = new DevExpress.XtraEditors.LabelControl();
            lblFilmTarihi = new DevExpress.XtraEditors.LabelControl();
            txtFilmAdi = new DevExpress.XtraEditors.TextEdit();
            txtFilmTuru = new DevExpress.XtraEditors.TextEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            nudFilmSuresi = new System.Windows.Forms.NumericUpDown();
            dtpFilmTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)txtFilmAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFilmTuru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFilmSuresi).BeginInit();
            SuspendLayout();
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmAdi.Appearance.Options.UseFont = true;
            lblFilmAdi.Location = new System.Drawing.Point(12, 13);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new System.Drawing.Size(65, 19);
            lblFilmAdi.TabIndex = 0;
            lblFilmAdi.Text = "Film Adı:";
            // 
            // lblFilmTuru
            // 
            lblFilmTuru.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmTuru.Appearance.Options.UseFont = true;
            lblFilmTuru.Location = new System.Drawing.Point(12, 45);
            lblFilmTuru.Name = "lblFilmTuru";
            lblFilmTuru.Size = new System.Drawing.Size(75, 19);
            lblFilmTuru.TabIndex = 1;
            lblFilmTuru.Text = "Film Türü:";
            // 
            // lblFilmSuresi
            // 
            lblFilmSuresi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmSuresi.Appearance.Options.UseFont = true;
            lblFilmSuresi.Location = new System.Drawing.Point(12, 77);
            lblFilmSuresi.Name = "lblFilmSuresi";
            lblFilmSuresi.Size = new System.Drawing.Size(84, 19);
            lblFilmSuresi.TabIndex = 2;
            lblFilmSuresi.Text = "Film Süresi:";
            // 
            // lblFilmTarihi
            // 
            lblFilmTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmTarihi.Appearance.Options.UseFont = true;
            lblFilmTarihi.Location = new System.Drawing.Point(12, 109);
            lblFilmTarihi.Name = "lblFilmTarihi";
            lblFilmTarihi.Size = new System.Drawing.Size(82, 19);
            lblFilmTarihi.TabIndex = 3;
            lblFilmTarihi.Text = "Film Tarihi:";
            // 
            // txtFilmAdi
            // 
            txtFilmAdi.Location = new System.Drawing.Point(102, 13);
            txtFilmAdi.Name = "txtFilmAdi";
            txtFilmAdi.Size = new System.Drawing.Size(123, 20);
            txtFilmAdi.TabIndex = 4;
            // 
            // txtFilmTuru
            // 
            txtFilmTuru.Location = new System.Drawing.Point(102, 44);
            txtFilmTuru.Name = "txtFilmTuru";
            txtFilmTuru.Size = new System.Drawing.Size(123, 20);
            txtFilmTuru.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKaydet.ImageOptions.SvgImage");
            btnKaydet.Location = new System.Drawing.Point(12, 151);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(213, 36);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // nudFilmSuresi
            // 
            nudFilmSuresi.Location = new System.Drawing.Point(102, 77);
            nudFilmSuresi.Name = "nudFilmSuresi";
            nudFilmSuresi.Size = new System.Drawing.Size(123, 23);
            nudFilmSuresi.TabIndex = 9;
            // 
            // dtpFilmTarihi
            // 
            dtpFilmTarihi.Location = new System.Drawing.Point(100, 109);
            dtpFilmTarihi.Name = "dtpFilmTarihi";
            dtpFilmTarihi.Size = new System.Drawing.Size(125, 23);
            dtpFilmTarihi.TabIndex = 10;
            // 
            // FormFilmEkle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dtpFilmTarihi);
            Controls.Add(nudFilmSuresi);
            Controls.Add(btnKaydet);
            Controls.Add(txtFilmTuru);
            Controls.Add(txtFilmAdi);
            Controls.Add(lblFilmTarihi);
            Controls.Add(lblFilmSuresi);
            Controls.Add(lblFilmTuru);
            Controls.Add(lblFilmAdi);
            Name = "FormFilmEkle";
            Text = "Film Ekle";
            ((System.ComponentModel.ISupportInitialize)txtFilmAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilmTuru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFilmSuresi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblFilmAdi;
        private DevExpress.XtraEditors.LabelControl lblFilmTuru;
        private DevExpress.XtraEditors.LabelControl lblFilmSuresi;
        private DevExpress.XtraEditors.LabelControl lblFilmTarihi;
        private DevExpress.XtraEditors.TextEdit txtFilmAdi;
        private DevExpress.XtraEditors.TextEdit txtFilmTuru;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.NumericUpDown nudFilmSuresi;
        private System.Windows.Forms.DateTimePicker dtpFilmTarihi;
    }
}