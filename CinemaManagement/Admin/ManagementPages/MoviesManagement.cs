using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.Model;
using CinemaManagement.Database;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class MoviesManagement : BaseMangementPage
    {
        List<MovieModel> movieList = new List<MovieModel>();
        public MoviesManagement()
        {
            InitializeComponent();
            movieList = DataProvider.LoadMovies();


        }
    }
}
