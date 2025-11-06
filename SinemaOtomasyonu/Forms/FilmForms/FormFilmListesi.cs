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

namespace SinemaOtomasyonu.UI
{
    public partial class FormFilmListesi : Form
    {
        private readonly FilmService _filmService;

        public FormFilmListesi()
        {
            _filmService = new FilmService(new SinemaContext());

            InitializeComponent();
        }
        private void LoadFilms()
        {
            try
            {
                List<Film> films = _filmService.GetAllFilm();
                gridControl1.DataSource = films;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata, {ex.Message}");
            }
        }

        private void FormFilmListesi_Load(object sender, EventArgs e)
        {
            LoadFilms();

        }
    }
}
