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
    public partial class FormFilmSil : Form
    {
        private readonly FilmService _filmService;
        public FormFilmSil()
        {
            _filmService = new FilmService(new SinemaContext());
            InitializeComponent();
        }
        private void LoadFilms()
        {
            try
            {
                List<Film> films = _filmService.GetAllFilm();
                dgvFilmler.DataSource = films;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata, {ex.Message}");
            }
        }


        private void FormFilmSil_Load(object sender, EventArgs e)
        {
            LoadFilms();
        }

        private void dgvFilmler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvFilmler.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show($"{_filmService.GetFilmById(id).Ad} isimli filmi silmek istediğinizden emin misiniz?", "Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _filmService.DeleteFilm(id);
            }
        }

    }
}
