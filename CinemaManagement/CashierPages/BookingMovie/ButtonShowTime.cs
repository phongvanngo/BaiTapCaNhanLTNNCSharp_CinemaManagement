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
    public partial class ButtonShowTime : UserControl
    {
        public event AddItemInvoiceDelegate AddShowTime;
        public ShowTimeModel showtime;
        public ButtonShowTime(ShowTimeModel showtime)
        {
            InitializeComponent();
            this.showtime = showtime;
            label_Date.Text = showtime.DateStart;
            label_Time.Text = showtime.TimeStart.ToString();
            int MaxSeats = TheaterDataAccess.GetTheaterSeats(showtime.TheaterID);
            label_Seats.Text = $"Reserved: {MaxSeats - showtime.RemainingSeats}/{MaxSeats}";
            label_Theater.Text = $"Rạp: {TheaterDataAccess.GetTheaterName(showtime.TheaterID)}";
        }

        private void label_Time_Click(object sender, EventArgs e)
        {
            AddShowTime(showtime.ShowTimeID,$" Ngày: {label_Date.Text} Giờ: {label_Time.Text} {label_Theater.Text} ",0);

        }
    }
}
