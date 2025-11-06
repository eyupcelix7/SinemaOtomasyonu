using DevExpress.XtraEditors;
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

namespace SinemaOtomasyonu.UI.Forms
{
    public partial class FormFilmEkle : Form
    {
        private FilmService _filmService;
        public FormFilmEkle()
        {
            _filmService = new FilmService(new SinemaContext());
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film
                {
                    Ad = txtFilmAdi.Text,
                    Tur = txtFilmTuru.Text,
                    Sure = Convert.ToInt32(nudFilmSuresi.Value),
                    YayinlanmaTarihi = dtpFilmTarihi.Value,
                    Rezervasyonlar = new List<Rezervasyon>()
                };

                _filmService.AddFilm(film);
                XtraMessageBox.Show("Başarılı!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Hata, {ex.Message}");
            }
        }
    }
}
