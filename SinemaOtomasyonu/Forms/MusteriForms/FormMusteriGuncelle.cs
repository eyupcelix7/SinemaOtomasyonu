using SinemaOtomasyonu.DataAccess;
using SinemaOtomasyonu.DataAccess.Services;
using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SinemaOtomasyonu.UI.Forms.MusteriForms
{
    public partial class FormMusteriGuncelle : Form
    {
        private readonly MusteriService _musteriService;
        public FormMusteriGuncelle()
        {
            _musteriService = new MusteriService(new SinemaContext());
            InitializeComponent();
        }

        private void FormMusteriGuncelle_Load(object sender, EventArgs e)
        {
            var musteriler = _musteriService.GetAllCustomers();
            cboMusteriSeciniz.DataSource = musteriler;
            cboMusteriSeciniz.DisplayMember = "Ad";
            cboMusteriSeciniz.ValueMember = "Id";
        }

        private void cboMusteriSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMusteriSeciniz.SelectedItem != null)
            {
                Musteri musteri = cboMusteriSeciniz.SelectedItem as Musteri;
                if(musteri != null)
                {
                    txtMusteriAdi.Text = musteri.Ad;
                    txtMusteriSoyadi.Text = musteri.Soyad;
                    txtTelefonNumarasi.Text = musteri.Telefon;
                    txtEmail.Text = musteri.Email;
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = cboMusteriSeciniz.SelectedItem as Musteri;
            if(musteri != null)
            {
                DialogResult dialogResult = MessageBox.Show($"{musteri.Ad} isimli müşteriyi güncellemek istediğinize emin misiniz?","Müşteri Güncelleme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    musteri.Ad = txtMusteriAdi.Text;
                    musteri.Soyad = txtMusteriSoyadi.Text;
                    musteri.Telefon = txtTelefonNumarasi.Text;
                    musteri.Email = txtEmail.Text;
                    _musteriService.UpdateCustomer(musteri);
                    MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgi");
                }
            }
        }

    }
}
