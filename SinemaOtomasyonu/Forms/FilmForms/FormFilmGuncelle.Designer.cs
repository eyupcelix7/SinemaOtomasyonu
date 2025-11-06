namespace SinemaOtomasyonu.UI.Forms
{
    partial class FormFilmGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmGuncelle));
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            txtFilmTuru = new DevExpress.XtraEditors.TextEdit();
            txtFilmAdi = new DevExpress.XtraEditors.TextEdit();
            lblFilmTarihi = new DevExpress.XtraEditors.LabelControl();
            lblFilmSuresi = new DevExpress.XtraEditors.LabelControl();
            lblFilmTuru = new DevExpress.XtraEditors.LabelControl();
            lblFilmAdi = new DevExpress.XtraEditors.LabelControl();
            nudFilmSuresi = new System.Windows.Forms.NumericUpDown();
            lblFilmSeciniz = new DevExpress.XtraEditors.LabelControl();
            dteFilmTarihi = new DevExpress.XtraEditors.DateEdit();
            cboFilmSeciniz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtFilmTuru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFilmAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFilmSuresi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dteFilmTarihi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dteFilmTarihi.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnGuncelle.Appearance.Options.UseFont = true;
            btnGuncelle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnGuncelle.ImageOptions.SvgImage");
            btnGuncelle.Location = new System.Drawing.Point(12, 196);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(213, 36);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtFilmTuru
            // 
            txtFilmTuru.Location = new System.Drawing.Point(102, 92);
            txtFilmTuru.Name = "txtFilmTuru";
            txtFilmTuru.Size = new System.Drawing.Size(123, 20);
            txtFilmTuru.TabIndex = 14;
            // 
            // txtFilmAdi
            // 
            txtFilmAdi.Location = new System.Drawing.Point(102, 57);
            txtFilmAdi.Name = "txtFilmAdi";
            txtFilmAdi.Size = new System.Drawing.Size(123, 20);
            txtFilmAdi.TabIndex = 13;
            // 
            // lblFilmTarihi
            // 
            lblFilmTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmTarihi.Appearance.Options.UseFont = true;
            lblFilmTarihi.Location = new System.Drawing.Point(12, 154);
            lblFilmTarihi.Name = "lblFilmTarihi";
            lblFilmTarihi.Size = new System.Drawing.Size(82, 19);
            lblFilmTarihi.TabIndex = 12;
            lblFilmTarihi.Text = "Film Tarihi:";
            // 
            // lblFilmSuresi
            // 
            lblFilmSuresi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmSuresi.Appearance.Options.UseFont = true;
            lblFilmSuresi.Location = new System.Drawing.Point(12, 122);
            lblFilmSuresi.Name = "lblFilmSuresi";
            lblFilmSuresi.Size = new System.Drawing.Size(84, 19);
            lblFilmSuresi.TabIndex = 11;
            lblFilmSuresi.Text = "Film Süresi:";
            // 
            // lblFilmTuru
            // 
            lblFilmTuru.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmTuru.Appearance.Options.UseFont = true;
            lblFilmTuru.Location = new System.Drawing.Point(12, 90);
            lblFilmTuru.Name = "lblFilmTuru";
            lblFilmTuru.Size = new System.Drawing.Size(75, 19);
            lblFilmTuru.TabIndex = 10;
            lblFilmTuru.Text = "Film Türü:";
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmAdi.Appearance.Options.UseFont = true;
            lblFilmAdi.Location = new System.Drawing.Point(12, 58);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new System.Drawing.Size(65, 19);
            lblFilmAdi.TabIndex = 9;
            lblFilmAdi.Text = "Film Adı:";
            // 
            // nudFilmSuresi
            // 
            nudFilmSuresi.Location = new System.Drawing.Point(102, 122);
            nudFilmSuresi.Name = "nudFilmSuresi";
            nudFilmSuresi.Size = new System.Drawing.Size(123, 23);
            nudFilmSuresi.TabIndex = 18;
            // 
            // lblFilmSeciniz
            // 
            lblFilmSeciniz.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFilmSeciniz.Appearance.Options.UseFont = true;
            lblFilmSeciniz.Location = new System.Drawing.Point(5, 12);
            lblFilmSeciniz.Name = "lblFilmSeciniz";
            lblFilmSeciniz.Size = new System.Drawing.Size(89, 19);
            lblFilmSeciniz.TabIndex = 20;
            lblFilmSeciniz.Text = "Film Seçiniz:";
            // 
            // dteFilmTarihi
            // 
            dteFilmTarihi.EditValue = null;
            dteFilmTarihi.Location = new System.Drawing.Point(102, 156);
            dteFilmTarihi.Name = "dteFilmTarihi";
            dteFilmTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dteFilmTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dteFilmTarihi.Size = new System.Drawing.Size(123, 20);
            dteFilmTarihi.TabIndex = 23;
            // 
            // cboFilmSeciniz
            // 
            cboFilmSeciniz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilmSeciniz.FormattingEnabled = true;
            cboFilmSeciniz.Location = new System.Drawing.Point(102, 13);
            cboFilmSeciniz.Name = "cboFilmSeciniz";
            cboFilmSeciniz.Size = new System.Drawing.Size(123, 23);
            cboFilmSeciniz.TabIndex = 24;
            cboFilmSeciniz.SelectedIndexChanged += cboFilmSeciniz_SelectedIndexChanged;
            // 
            // FormFilmGuncelle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cboFilmSeciniz);
            Controls.Add(dteFilmTarihi);
            Controls.Add(lblFilmSeciniz);
            Controls.Add(nudFilmSuresi);
            Controls.Add(btnGuncelle);
            Controls.Add(txtFilmTuru);
            Controls.Add(txtFilmAdi);
            Controls.Add(lblFilmTarihi);
            Controls.Add(lblFilmSuresi);
            Controls.Add(lblFilmTuru);
            Controls.Add(lblFilmAdi);
            Name = "FormFilmGuncelle";
            Text = "Film Güncelle";
            Load += FormFilmGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)txtFilmTuru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFilmAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFilmSuresi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dteFilmTarihi.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dteFilmTarihi.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.TextEdit txtFilmTuru;
        private DevExpress.XtraEditors.TextEdit txtFilmAdi;
        private DevExpress.XtraEditors.LabelControl lblFilmTarihi;
        private DevExpress.XtraEditors.LabelControl lblFilmSuresi;
        private DevExpress.XtraEditors.LabelControl lblFilmTuru;
        private DevExpress.XtraEditors.LabelControl lblFilmAdi;
        private System.Windows.Forms.NumericUpDown nudFilmSuresi;
        private DevExpress.XtraEditors.LabelControl lblFilmSeciniz;
        private DevExpress.XtraEditors.DateEdit dteFilmTarihi;
        private System.Windows.Forms.ComboBox cboFilmSeciniz;
    }
}