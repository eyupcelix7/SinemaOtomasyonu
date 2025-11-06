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
    public partial class FormFilmGuncelle : Form
    {
        private FilmService _filmService;
        public FormFilmGuncelle()
        {
            _filmService = new FilmService(new SinemaContext());
            InitializeComponent();
        }

        private void FormFilmGuncelle_Load(object sender, EventArgs e)
        {
            var filmler = _filmService.GetAllFilm();
            cboFilmSeciniz.DataSource = filmler;
            cboFilmSeciniz.DisplayMember = "Ad";
            cboFilmSeciniz.ValueMember = "Id";
        }

        private void cboFilmSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilmSeciniz.SelectedItem != null && cboFilmSeciniz.SelectedIndex != -1)
            {
                Film secilenFilm = cboFilmSeciniz.SelectedItem as Film;
                txtFilmAdi.Text = secilenFilm.Ad;
                txtFilmTuru.Text = secilenFilm.Tur;
                nudFilmSuresi.Value = secilenFilm.Sure;
                dteFilmTarihi.DateTime = secilenFilm.YayinlanmaTarihi;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Film secilenFilm = cboFilmSeciniz.SelectedItem as Film;
            if (secilenFilm != null)
            {
                secilenFilm.Ad = txtFilmAdi.Text;
                secilenFilm.Tur = txtFilmTuru.Text;
                secilenFilm.Sure = Convert.ToInt32(nudFilmSuresi.Value);
                secilenFilm.YayinlanmaTarihi = dteFilmTarihi.DateTime;
                var sex = secilenFilm;
                _filmService.UpdateFilm(secilenFilm);
                MessageBox.Show("Film Güncellendi","Bilgi");
            }
        }
    }
}
