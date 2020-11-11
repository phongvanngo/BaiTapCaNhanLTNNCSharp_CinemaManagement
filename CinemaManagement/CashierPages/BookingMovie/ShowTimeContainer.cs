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
    public partial class ShowTimeContainer : UserControl
    {
        string MovieID;
        List<ShowTimeModel> ListShowTime = new List<ShowTimeModel>();
        public ShowTimeContainer()
        {
            InitializeComponent();
        }
        public event AddItemInvoiceDelegate ChooseShowTime;
        public void ShowTimeList(string movieID)
        {
            MovieModel MovieSelected = MovieDataAccess.GetMovie(movieID);
            label_MovieName.Text = MovieSelected.Name + $" ({MovieSelected.Classify})";
            label_MovieTime.Text = $"Thời lượng: {MovieSelected.Time/60} tiếng {MovieSelected.Time % 60} phút";
            label_MoviePrice.Text = MovieSelected.Price.ToString();
            

            ListShowTime = ShowTimeDataAccess.LoadShowTimesDepentMovieID(movieID);
            flowLayoutPanel_ShowTimeList.Controls.Clear();
            foreach (var item in ListShowTime)
            {
                ButtonShowTime showtimeBtn = new ButtonShowTime(item);
                showtimeBtn.Margin = new Padding(7,7,7,7);
                showtimeBtn.AddShowTime += ShowtimeBtn_AddShowTime;
                flowLayoutPanel_ShowTimeList.Controls.Add(showtimeBtn);
            }
            
        }

        private void ShowtimeBtn_AddShowTime(string ID, string Name, int Price)
        {
            Name = label_MovieName.Text + " " + Name;
            Price = Convert.ToInt32(label_MoviePrice.Text);
            ChooseShowTime(ID,Name,Price);

        }
    }
}
