using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.Database;
using CinemaManagement.Models;
using System.Reflection;
using CinemaManagement.Database.DataProvider;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class MoviesManagement : BaseMangementPage
    {
        List<MovieModel> movieList = new List<MovieModel>();
        public MoviesManagement()
        {
            InitializeComponent();
            RefreshMovieList();
            
        }
        void RefreshMovieList()
        {
            MovieList = MovieDataAccess.LoadMovies();
            var bindinglist = new BindingList<MovieModel>(MovieList);
            var source = new BindingSource(bindinglist, null);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = source;
            dataGridView1.Columns["MovieID"].HeaderText = "Mã phim";
            dataGridView1.Columns["Name"].HeaderText = "Tên phim";
            dataGridView1.Columns["Time"].HeaderText = "Thời lượng";
            dataGridView1.Columns["Classify"].HeaderText = "Phân loại";
            dataGridView1.Columns["Price"].HeaderText = "Giá vé";
            dataGridView1.Columns["Image"].HeaderText = "Hình ảnh"; 
            
            dataGridView1.Columns["MovieID"].FillWeight = 10F;
            dataGridView1.Columns["Name"].FillWeight = 40F;
            dataGridView1.Columns["Time"].FillWeight = 15F;
            dataGridView1.Columns["Classify"].FillWeight = 10F;
            dataGridView1.Columns["Price"].FillWeight = 15F;
            dataGridView1.Columns["Image"].FillWeight = 10F;
        }

        public List<MovieModel> MovieList { get => movieList; set => movieList = value; }
    }
}
