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

        public bool IsDataUpdate {set { RefreshMovieAndTheaterNameCombobox(); } }

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
    }
}
