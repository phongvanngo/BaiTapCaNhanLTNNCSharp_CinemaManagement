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
using CinemaManagement.MyUtilities;
using System.Configuration;
using System.Runtime.InteropServices;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class MoviesManagement : BaseMangementPage
    {
        bool IsEditing = false;
        DataTable dtMovieList = new DataTable();

        public event DataChangeDelegate DataUpdateEvent;

        int IndexRowSelected = -1;
        public MoviesManagement()
        {
            InitializeComponent();
            SetUpTableMovieList();
            RefreshMovieList();
        }
        void SetUpTableMovieList()
        {
            Table_MovieList.Columns.Clear();

            //add column for data table;
            dtMovieList.Columns.Add("MovieId", typeof(string));
            dtMovieList.Columns.Add("Name", typeof(string));
            dtMovieList.Columns.Add("Time", typeof(int));
            dtMovieList.Columns.Add("Classify", typeof(string));
            dtMovieList.Columns.Add("Price", typeof(int));
            dtMovieList.Columns.Add("Image", typeof(string));

            Table_MovieList.DataSource = dtMovieList;

            //reassign column name
            Table_MovieList.Columns["MovieID"].HeaderText = "Mã phim";
            Table_MovieList.Columns["Name"].HeaderText = "Tên phim";
            Table_MovieList.Columns["Time"].HeaderText = "Thời lượng";
            Table_MovieList.Columns["Classify"].HeaderText = "Phân loại";
            Table_MovieList.Columns["Price"].HeaderText = "Giá vé";
            Table_MovieList.Columns["Image"].HeaderText = "Hình ảnh";

            // fix size cho columns
            Table_MovieList.Columns["MovieID"].FillWeight = 10F;
            Table_MovieList.Columns["Name"].FillWeight = 40F;
            Table_MovieList.Columns["Time"].FillWeight = 15F;
            Table_MovieList.Columns["Classify"].FillWeight = 10F;
            Table_MovieList.Columns["Price"].FillWeight = 15F;
            Table_MovieList.Columns["Image"].FillWeight = 10F;

            //disable column sort
            foreach (DataGridViewColumn column in Table_MovieList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        void RefreshMovieList()
        {
            List<MovieModel> movieList = MovieDataAccess.LoadMovies();
            foreach (var movie in movieList)
            {
                dtMovieList.Rows.Add(
                movie.MovieID,
                movie.Name,
                movie.Time,
                movie.Classify,
                movie.Price,
                movie.Image);
            }
        }
        private void button_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_MovieImage.ImageLocation = openFileDialog.FileName;
            }
        }
        
        private void Table_MovieList_MouseDown(object sender, MouseEventArgs e)
        { 
            // user right click to datagridview
            if (e.Button == MouseButtons.Right)
            {
                var hti = Table_MovieList.HitTest(e.X, e.Y);
                Table_MovieList.ClearSelection();
                try
                {
                    Table_MovieList.Rows[hti.RowIndex].Selected = true;
                    IndexRowSelected = hti.RowIndex;
                }
                // user right click outside rows
                catch
                {
                    IndexRowSelected = -1;
                };
            }
        }

        private void EditMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                IsEditing = true;
                textBox_NameOfMovie.Text = dtMovieList.Rows[IndexRowSelected]["Name"].ToString();
                textBox_TicketPrice.Text = dtMovieList.Rows[IndexRowSelected]["Price"].ToString();
                comboBox_Classify.Text = dtMovieList.Rows[IndexRowSelected]["Classify"].ToString();
                pictureBox_MovieImage.ImageLocation = MyFunction.ConvertString(dtMovieList.Rows[IndexRowSelected]["Image"].ToString());

                numericUpDown_Hour.Value = Convert.ToInt32(dtMovieList.Rows[IndexRowSelected]["Time"]) / 60;
                numericUpDown_min.Value = Convert.ToInt32(dtMovieList.Rows[IndexRowSelected]["Time"]) % 60;
            }
        }

        private void ClearInput()
        {
            textBox_NameOfMovie.Text = "";
            textBox_TicketPrice.Text = "";
            comboBox_Classify.Text = "";
            pictureBox_MovieImage.ImageLocation = "";
            numericUpDown_Hour.Value = 0;
            numericUpDown_min.Value = 0;
        }

        private void Button_UpdateMovie_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                dtMovieList.Rows[IndexRowSelected]["Name"] = textBox_NameOfMovie.Text;
                dtMovieList.Rows[IndexRowSelected]["Price"] = textBox_TicketPrice.Text;
                dtMovieList.Rows[IndexRowSelected]["Classify"] = comboBox_Classify.Text;
                dtMovieList.Rows[IndexRowSelected]["Image"] = pictureBox_MovieImage.ImageLocation;
                dtMovieList.Rows[IndexRowSelected]["Time"] = numericUpDown_Hour.Value * 60 + numericUpDown_min.Value;

                MovieModel movie = new MovieModel();

                movie.MovieID = dtMovieList.Rows[IndexRowSelected]["MovieID"].ToString();
                movie.Classify = comboBox_Classify.Text;
                movie.Name = textBox_NameOfMovie.Text;
                movie.Time = Convert.ToInt32(numericUpDown_Hour.Value * 60 + numericUpDown_min.Value);
                movie.Image = pictureBox_MovieImage.ImageLocation == null ? "" : pictureBox_MovieImage.ImageLocation;
                movie.Price = Convert.ToInt32(textBox_TicketPrice.Text);

                MovieDataAccess.UpdateMovie(movie);

                IsEditing = false;
                ClearInput();

                DataUpdateEvent();

            }
        }

        private bool CheckInputValid()
        {
            if (textBox_NameOfMovie.Text == "" || textBox_NameOfMovie == null) return false;
            if (comboBox_Classify.Text == "" || comboBox_Classify == null) return false;
            if (Int32.TryParse(textBox_TicketPrice.Text, out int result) == false) return false;
            return true;
        }
        private void button_AddMovie_Click(object sender, EventArgs e)
        {
            if (IsEditing == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bản chỉnh sửa chưa được cập nhật, Bạn vẫn muốn tiếp tục chứ ?", "thêm phim mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    IsEditing = false;
                    ClearInput();
                    return;
                }
            }

            //kiểm tra input 
            if (CheckInputValid() == false) { MessageBox.Show("Dữ liệu không hợp lệ"); return; }

            //trường hợp không chỉnh sửa phim
            MovieModel movie = new MovieModel();
            movie.MovieID = "MOV" + MyFunction.GenerateCode();
            movie.Classify = comboBox_Classify.Text;
            movie.Name = textBox_NameOfMovie.Text;
            movie.Classify = comboBox_Classify.Text;
            movie.Time = Convert.ToInt32(numericUpDown_Hour.Value * 60 + numericUpDown_min.Value);
            movie.Image = pictureBox_MovieImage.ImageLocation == null ? "" : pictureBox_MovieImage.ImageLocation;
            movie.Price = Convert.ToInt32(textBox_TicketPrice.Text);

            dtMovieList.Rows.Add(
            movie.MovieID,
            movie.Name,
            movie.Time,
            movie.Classify,
            movie.Price,
            movie.Image);

            MovieDataAccess.SaveMovie(movie);

            ClearInput();

            DataUpdateEvent();
        }
        private void DeleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                MovieDataAccess.DeleteMovie((string)dtMovieList.Rows[IndexRowSelected]["MovieID"]);
                dtMovieList.Rows[IndexRowSelected].Delete();

                DataUpdateEvent();
            }
        }
    }
}
