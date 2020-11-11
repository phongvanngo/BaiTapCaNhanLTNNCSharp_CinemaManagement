using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.Models;

namespace CinemaManagement.CashierPages.BookingMovie
{
    public partial class MoviePosterComponent : UserControl
    {
        MovieModel Movie;
        public event ChooseMovieDelegate PosterClick;
        public MoviePosterComponent(MovieModel movie)
        {
            InitializeComponent();
            Movie = movie;
            pictureBox_MovieImage.ImageLocation = movie.Image;
            label_MovieClassify.Text = movie.Classify;
            label_MovieName.Text = movie.Name;
        }

        private void pictureBox_MovieImage_Click(object sender, EventArgs e)
        {
            PosterClick(Movie.MovieID);
        }
    }
}
