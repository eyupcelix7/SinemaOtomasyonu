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
    public partial class FormMusteriEkle : Form
    {
        private readonly MusteriService _musteriService;
        public FormMusteriEkle()
        {
            _musteriService = new MusteriService(new SinemaContext());
            InitializeComponent();
        }

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            {
                Ad = txtMusteriAdi.Text,
                Soyad = txtMusteriSoyadi.Text,
                Telefon = txtTelefonNumarasi.Text,
                Email = txtEmail.Text
            };
            _musteriService.AddCustomer(musteri);
            MessageBox.Show("Müşteri başarıyla eklendi");
        }
    }
}
