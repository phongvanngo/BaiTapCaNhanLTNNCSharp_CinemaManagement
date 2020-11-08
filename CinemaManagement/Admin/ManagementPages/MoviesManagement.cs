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

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class MoviesManagement : BaseMangementPage
    {
        List<MovieModel> movieList = new List<MovieModel>();
        bool IsEditing = false;


        int IndexRowSelected = -1;
        public MoviesManagement()
        {
            InitializeComponent();
            RefreshMovieList();
        }

        void RefreshMovieList()
        {
            movieList = MovieDataAccess.LoadMovies();
            //var bindinglist = new BindingList<MovieModel>(movieList);
            //var source = new BindingSource(bindinglist, null);
            Table_MovieList.Columns.Clear();
            Table_MovieList.DataSource = MovieList;
            Table_MovieList.Columns["MovieID"].HeaderText = "Mã phim";
            Table_MovieList.Columns["Name"].HeaderText = "Tên phim";
            Table_MovieList.Columns["Time"].HeaderText = "Thời lượng";
            Table_MovieList.Columns["Classify"].HeaderText = "Phân loại";
            Table_MovieList.Columns["Price"].HeaderText = "Giá vé";
            Table_MovieList.Columns["Image"].HeaderText = "Hình ảnh";

            Table_MovieList.Columns["MovieID"].FillWeight = 10F;
            Table_MovieList.Columns["Name"].FillWeight = 40F;
            Table_MovieList.Columns["Time"].FillWeight = 15F;
            Table_MovieList.Columns["Classify"].FillWeight = 10F;
            Table_MovieList.Columns["Price"].FillWeight = 15F;
            Table_MovieList.Columns["Image"].FillWeight = 10F;
        }

        public List<MovieModel> MovieList { get => movieList; set => movieList = value; }

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
            if (e.Button == MouseButtons.Right)
            {
                var hti = Table_MovieList.HitTest(e.X, e.Y);
                Table_MovieList.ClearSelection();
                try
                {
                    Table_MovieList.Rows[hti.RowIndex].Selected = true;
                    IndexRowSelected = hti.RowIndex;
                }
                catch
                {
                    IndexRowSelected = -1;
                };
                //int a = Table_MovieList.Rows.GetRowCount(DataGridViewElementStates.Selected);
                //Table_MovieList.Rows.RemoveAt(this.Table_MovieList.SelectedRows[0].Index);
            }
        }


        private void EditMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (IndexRowSelected != -1)
            {
                IsEditing = true;
                textBox_NameOfMovie.Text = Table_MovieList.Rows[IndexRowSelected].Cells["Name"].Value.ToString();
                textBox_TicketPrice.Text = Table_MovieList.Rows[IndexRowSelected].Cells["Price"].Value.ToString();
                comboBox_Classify.Text = Table_MovieList.Rows[IndexRowSelected].Cells["Classify"].Value.ToString();
                pictureBox_MovieImage.ImageLocation = MyFunction.ConvertString(Table_MovieList.Rows[IndexRowSelected].Cells["Image"].Value);

                numericUpDown_Hour.Value = Convert.ToInt32(Table_MovieList.Rows[IndexRowSelected].Cells["Time"].Value) / 60;
                numericUpDown_min.Value = Convert.ToInt32(Table_MovieList.Rows[IndexRowSelected].Cells["Time"].Value) % 60;
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
                Table_MovieList.Rows[IndexRowSelected].Cells["Name"].Value = textBox_NameOfMovie.Text;
                Table_MovieList.Rows[IndexRowSelected].Cells["Price"].Value = textBox_TicketPrice.Text;
                Table_MovieList.Rows[IndexRowSelected].Cells["Classify"].Value = comboBox_Classify.Text;
                Table_MovieList.Rows[IndexRowSelected].Cells["Image"].Value = pictureBox_MovieImage.ImageLocation;
                Table_MovieList.Rows[IndexRowSelected].Cells["Time"].Value = numericUpDown_Hour.Value * 60 + numericUpDown_min.Value;

                MovieModel movie = new MovieModel();
                movie.MovieID = Table_MovieList.Rows[IndexRowSelected].Cells["MovieID"].Value.ToString();
                movie.Classify = comboBox_Classify.Text;
                movie.Name = textBox_NameOfMovie.Text;
                movie.Classify = comboBox_Classify.Text;
                movie.Time = Convert.ToInt32(numericUpDown_Hour.Value * 60 + numericUpDown_min.Value);
                movie.Image = pictureBox_MovieImage.ImageLocation == null ? "" : pictureBox_MovieImage.ImageLocation;
                movie.Price = Convert.ToInt32(textBox_TicketPrice.Text);
                MovieDataAccess.UpdateMovies(movie);

                IsEditing = false;
                ClearInput();

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
            movie.MovieID = "fasdf";
            movie.Classify = comboBox_Classify.Text;
            movie.Name = textBox_NameOfMovie.Text;
            movie.Classify = comboBox_Classify.Text;
            movie.Time = Convert.ToInt32(numericUpDown_Hour.Value * 60 + numericUpDown_min.Value);
            movie.Image = pictureBox_MovieImage.ImageLocation == null ? "" : pictureBox_MovieImage.ImageLocation;
            movie.Price = Convert.ToInt32(textBox_TicketPrice.Text);

            //Table_MovieList.Rows.Add(
            //    movie.MovieID,
            //    movie.Name,
            //    movie.Price,
            //    movie.Classify,
            //    movie.Image,
            //    movie.Time);

            MovieList.Add(movie);
            MessageBox.Show(MovieList.Count() + "");
            Table_MovieList.Columns.Clear();
            var bindinglist = new BindingList<MovieModel>(movieList);
            var source = new BindingSource(bindinglist, null);
            Table_MovieList.DataSource = source;






        }
    }
}
