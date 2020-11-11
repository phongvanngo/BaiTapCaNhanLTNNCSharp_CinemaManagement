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
using CinemaManagement.Database.DataProvider;

namespace CinemaManagement.CashierPages.BookingMovie
{
    public partial class BookingMovieContainer : UserControl
    {
        List<MovieModel> MovieList;
        public event ChooseMovieDelegate ChooseMovie;
        public BookingMovieContainer()
        {
            InitializeComponent();
            MovieList = MovieDataAccess.LoadMovies();
            foreach (var movie in MovieList)
            {
                MoviePosterComponent MoviePoster = new MoviePosterComponent(movie);
                MoviePoster.PosterClick += MoviePoster_PosterClick;
                MoviePoster.Margin = new System.Windows.Forms.Padding(20);
                flowLayoutPanel_MovieList.Controls.Add(MoviePoster);
            }
            
        }

        private void MoviePoster_PosterClick(string MovieID)
        {
            ChooseMovie(MovieID);
        }
    }
}
