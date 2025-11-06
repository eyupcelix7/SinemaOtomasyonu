namespace SinemaOtomasyonu.UI.Forms.MusteriForms
{
    partial class FormMusteriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriGuncelle));
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtTelefonNumarasi = new DevExpress.XtraEditors.TextEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            txtMusteriSoyadi = new DevExpress.XtraEditors.TextEdit();
            txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            lblMusteriEmail = new DevExpress.XtraEditors.LabelControl();
            lblMusteriTelefon = new DevExpress.XtraEditors.LabelControl();
            lblMusteriSoyadi = new DevExpress.XtraEditors.LabelControl();
            lblMusteriAdi = new DevExpress.XtraEditors.LabelControl();
            cboMusteriSeciniz = new System.Windows.Forms.ComboBox();
            lblMusteriSeciniz = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefonNumarasi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMusteriSoyadi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMusteriAdi.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(149, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(125, 20);
            txtEmail.TabIndex = 30;
            // 
            // txtTelefonNumarasi
            // 
            txtTelefonNumarasi.Location = new System.Drawing.Point(149, 113);
            txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            txtTelefonNumarasi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            txtTelefonNumarasi.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d-\\d\\d");
            txtTelefonNumarasi.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            txtTelefonNumarasi.Size = new System.Drawing.Size(125, 20);
            txtTelefonNumarasi.TabIndex = 29;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKaydet.ImageOptions.SvgImage");
            btnKaydet.Location = new System.Drawing.Point(12, 185);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(262, 36);
            btnKaydet.TabIndex = 28;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtMusteriSoyadi
            // 
            txtMusteriSoyadi.Location = new System.Drawing.Point(149, 81);
            txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            txtMusteriSoyadi.Size = new System.Drawing.Size(125, 20);
            txtMusteriSoyadi.TabIndex = 27;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new System.Drawing.Point(149, 49);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new System.Drawing.Size(125, 20);
            txtMusteriAdi.TabIndex = 26;
            // 
            // lblMusteriEmail
            // 
            lblMusteriEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblMusteriEmail.Appearance.Options.UseFont = true;
            lblMusteriEmail.Location = new System.Drawing.Point(12, 143);
            lblMusteriEmail.Name = "lblMusteriEmail";
            lblMusteriEmail.Size = new System.Drawing.Size(109, 19);
            lblMusteriEmail.TabIndex = 25;
            lblMusteriEmail.Text = "E-Posta Adresi:";
            // 
            // lblMusteriTelefon
            // 
            lblMusteriTelefon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblMusteriTelefon.Appearance.Options.UseFont = true;
            lblMusteriTelefon.Location = new System.Drawing.Point(12, 111);
            lblMusteriTelefon.Name = "lblMusteriTelefon";
            lblMusteriTelefon.Size = new System.Drawing.Size(131, 19);
            lblMusteriTelefon.TabIndex = 24;
            lblMusteriTelefon.Text = "Telefon Numarası:";
            // 
            // lblMusteriSoyadi
            // 
            lblMusteriSoyadi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblMusteriSoyadi.Appearance.Options.UseFont = true;
            lblMusteriSoyadi.Location = new System.Drawing.Point(12, 79);
            lblMusteriSoyadi.Name = "lblMusteriSoyadi";
            lblMusteriSoyadi.Size = new System.Drawing.Size(109, 19);
            lblMusteriSoyadi.TabIndex = 23;
            lblMusteriSoyadi.Text = "Müşteri Soyadı:";
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblMusteriAdi.Appearance.Options.UseFont = true;
            lblMusteriAdi.Location = new System.Drawing.Point(12, 47);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new System.Drawing.Size(86, 19);
            lblMusteriAdi.TabIndex = 22;
            lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // cboMusteriSeciniz
            // 
            cboMusteriSeciniz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMusteriSeciniz.FormattingEnabled = true;
            cboMusteriSeciniz.Location = new System.Drawing.Point(149, 8);
            cboMusteriSeciniz.Name = "cboMusteriSeciniz";
            cboMusteriSeciniz.Size = new System.Drawing.Size(125, 23);
            cboMusteriSeciniz.TabIndex = 32;
            cboMusteriSeciniz.SelectedIndexChanged += cboMusteriSeciniz_SelectedIndexChanged;
            // 
            // lblMusteriSeciniz
            // 
            lblMusteriSeciniz.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblMusteriSeciniz.Appearance.Options.UseFont = true;
            lblMusteriSeciniz.Location = new System.Drawing.Point(12, 8);
            lblMusteriSeciniz.Name = "lblMusteriSeciniz";
            lblMusteriSeciniz.Size = new System.Drawing.Size(110, 19);
            lblMusteriSeciniz.TabIndex = 31;
            lblMusteriSeciniz.Text = "Müşteri Seçiniz:";
            // 
            // FormMusteriGuncelle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cboMusteriSeciniz);
            Controls.Add(lblMusteriSeciniz);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefonNumarasi);
            Controls.Add(btnKaydet);
            Controls.Add(txtMusteriSoyadi);
            Controls.Add(txtMusteriAdi);
            Controls.Add(lblMusteriEmail);
            Controls.Add(lblMusteriTelefon);
            Controls.Add(lblMusteriSoyadi);
            Controls.Add(lblMusteriAdi);
            Name = "FormMusteriGuncelle";
            Text = "Müşteri Düzenle";
            Load += FormMusteriGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefonNumarasi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMusteriSoyadi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMusteriAdi.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtTelefonNumarasi;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtMusteriSoyadi;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private DevExpress.XtraEditors.LabelControl lblMusteriEmail;
        private DevExpress.XtraEditors.LabelControl lblMusteriTelefon;
        private DevExpress.XtraEditors.LabelControl lblMusteriSoyadi;
        private DevExpress.XtraEditors.LabelControl lblMusteriAdi;
        private System.Windows.Forms.ComboBox cboMusteriSeciniz;
        private DevExpress.XtraEditors.LabelControl lblMusteriSeciniz;
    }
}