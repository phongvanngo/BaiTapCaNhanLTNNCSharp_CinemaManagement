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
using CinemaManagement.MyUtilities;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class ShowTimeManagement : BaseMangementPage
    {
        bool IsEditing = false;
        DataTable dtShowTimeList = new DataTable();
        int IndexRowSelected = -1;
        List<ShowTimeModel> showTimeList = new List<ShowTimeModel>();

        List<MovieModel> movieList = new List<MovieModel>();
        List<TheaterModel> theaterList = new List<TheaterModel>();

        public bool IsDataUpdate {set { RefreshMovieAndTheaterNameCombobox();RefreshShowTimeList(); } }

        public ShowTimeManagement()
        {
            InitializeComponent();
            SetUpTableShowTimeList();
            RefreshShowTimeList();
            RefreshMovieAndTheaterNameCombobox();

            dateTimePicker_Date.Value = DateTime.Now;
            dateTimePicker_TimeStart.Value = DateTime.Now;


        }

        public void RefreshMovieAndTheaterNameCombobox()
        {
            movieList = MovieDataAccess.CustomeQuery("select MovieID,Name from Movie");
            theaterList = TheaterDataAccess.CustomeQuery("select TheaterID, Name from Theater");
            
            comboBox_NameOfMovie.DataSource = null;
            comboBox_NameOfMovie.DataSource = movieList;
            comboBox_NameOfMovie.DisplayMember = "Name";            
            
            comboBox_NameOfTheater.DataSource = null;
            comboBox_NameOfTheater.DataSource = theaterList;
            comboBox_NameOfTheater.DisplayMember = "Name";

        }

        void SetUpTableShowTimeList()
        {
            Table_ShowTimeList.Columns.Clear();

            //add column for data table;
            dtShowTimeList.Columns.Add("ShowTimeID", typeof(string));
            dtShowTimeList.Columns.Add("MovieName", typeof(string));
            dtShowTimeList.Columns.Add("TheaterName", typeof(string));
            dtShowTimeList.Columns.Add("DateStart", typeof(string));
            dtShowTimeList.Columns.Add("TimeStart", typeof(string));
            dtShowTimeList.Columns.Add("RemainingSeats", typeof(int));


            Table_ShowTimeList.DataSource = dtShowTimeList;

            //reassign column name
            Table_ShowTimeList.Columns["ShowTimeID"].HeaderText = "Mã suất chiếu";
            Table_ShowTimeList.Columns["MovieName"].HeaderText = "Tên phim";
            Table_ShowTimeList.Columns["TheaterName"].HeaderText = "Tên rạp";
            Table_ShowTimeList.Columns["DateStart"].HeaderText = "Ngày chiếu";
            Table_ShowTimeList.Columns["TimeStart"].HeaderText = "Thời gian chiếu";
            Table_ShowTimeList.Columns["RemainingSeats"].HeaderText = "Số chỗ ngồi còn lại";


            // fix size cho columns
            Table_ShowTimeList.Columns["ShowTimeID"].FillWeight = 10F;
            Table_ShowTimeList.Columns["MovieName"].FillWeight = 30F;
            Table_ShowTimeList.Columns["TheaterName"].FillWeight = 15F;
            Table_ShowTimeList.Columns["DateStart"].FillWeight = 20F;
            Table_ShowTimeList.Columns["TimeStart"].FillWeight = 15F;
            Table_ShowTimeList.Columns["RemainingSeats"].FillWeight = 10F;


            //disable column sort
            foreach (DataGridViewColumn column in Table_ShowTimeList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        void RefreshShowTimeList()
        {
            showTimeList = ShowTimeDataAccess.LoadShowTimes();
            foreach (var showTime in showTimeList)
            {
                showTime.MovieName = MovieDataAccess.GetMovieName(showTime.MovieID);
                showTime.TheaterName = TheaterDataAccess.GetTheaterName(showTime.TheaterID);
                //showTime.RemainingSeats = TheaterDataAccess.GetTheaterSeats(showTime.TheaterID);
                
                dtShowTimeList.Rows.Add(
                showTime.ShowTimeID,
                showTime.MovieName,
                showTime.TheaterName,
                showTime.DateStart,
                showTime.TimeStart,
                showTime.RemainingSeats);
            }
        }

        //----
        private void Table_ShowTimeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = Table_ShowTimeList.HitTest(e.X, e.Y);
                Table_ShowTimeList.ClearSelection();
                try
                {
                    Table_ShowTimeList.Rows[hti.RowIndex].Selected = true;
                    IndexRowSelected = hti.RowIndex;
                }
                // user right click outside rows
                catch
                {
                    IndexRowSelected = -1;
                };
            }
        }

        private void ClearInput()
        {
            //textBox_NameOfShowTime.Text = "";
            //numericUpDown_Seats.Value = 50;
        }

        private bool CheckInputValid()
        {
            //if (textBox_NameOfShowTime.Text == "" || textBox_NameOfShowTime == null) return false;
            return true;
        }

        private void button_AddShowTime_Click(object sender, EventArgs e)
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
            ShowTimeModel showTime = new ShowTimeModel();

            showTime.ShowTimeID = "ST" + MyFunction.GenerateCode();

            MovieModel SelectedMovie = comboBox_NameOfMovie.SelectedItem as MovieModel;
            TheaterModel SelectedTheater = comboBox_NameOfTheater.SelectedItem as TheaterModel;

            showTime.MovieID = SelectedMovie.MovieID;
            showTime.MovieName = SelectedMovie.Name;            
            showTime.TheaterID = SelectedTheater.TheaterID;
            showTime.TheaterName = SelectedTheater.Name;
            showTime.DateStart = dateTimePicker_Date.Value.ToString("dd-MM-yy");
            showTime.TimeStart = dateTimePicker_TimeStart.Value.ToString("HH:mm");
            showTime.RemainingSeats = TheaterDataAccess.GetTheaterSeats(showTime.TheaterID);

            //truong hop suat chieu bị trùng 
            if (ShowTimeDataAccess.CheckValidNewShowTime(showTime) == false)
            {
                MessageBox.Show("Suất chiếu bị trùng");
                return;
            }

                dtShowTimeList.Rows.Add(
            showTime.ShowTimeID,
            showTime.MovieName,
            showTime.TheaterName,
            showTime.DateStart,
            showTime.TimeStart,
            showTime.RemainingSeats);

            ShowTimeDataAccess.SaveShowTime(showTime);

            ClearInput();

        }

        private void button_UpdateShowTime_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                ShowTimeModel showTime = new ShowTimeModel();

                showTime.ShowTimeID = dtShowTimeList.Rows[IndexRowSelected]["ShowTimeID"].ToString();
                showTime.MovieID = (comboBox_NameOfMovie.SelectedItem as MovieModel).MovieID;
                showTime.TheaterID = (comboBox_NameOfTheater.SelectedItem as TheaterModel).TheaterID;
                showTime.DateStart = dateTimePicker_Date.Text;
                showTime.TimeStart = dateTimePicker_TimeStart.Text;

                dtShowTimeList.Rows[IndexRowSelected]["MovieName"] = comboBox_NameOfMovie.Text;
                dtShowTimeList.Rows[IndexRowSelected]["TheaterName"] = comboBox_NameOfTheater.Text;
                dtShowTimeList.Rows[IndexRowSelected]["DateStart"] = showTime.DateStart;
                dtShowTimeList.Rows[IndexRowSelected]["TimeStart"] = showTime.TimeStart;

                ShowTimeDataAccess.UpdateShowTime(showTime);

                IsEditing = false;
                ClearInput();
            }
        }
        private void editShowTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                IsEditing = true;
                comboBox_NameOfMovie.Text = dtShowTimeList.Rows[IndexRowSelected]["MovieName"].ToString();
                comboBox_NameOfTheater.Text = dtShowTimeList.Rows[IndexRowSelected]["TheaterName"].ToString();
                dateTimePicker_Date.Text = dtShowTimeList.Rows[IndexRowSelected]["DateStart"].ToString();
                dateTimePicker_TimeStart.Text = dtShowTimeList.Rows[IndexRowSelected]["TimeStart"].ToString();
            }
        }
        private void deleteShowTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                ShowTimeDataAccess.DeleteShowTime((string)dtShowTimeList.Rows[IndexRowSelected]["ShowTimeID"]);
                dtShowTimeList.Rows[IndexRowSelected].Delete();
            }
        }

        //----
    }
}
