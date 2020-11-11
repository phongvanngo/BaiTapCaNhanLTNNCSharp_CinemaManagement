using CinemaManagement.Admin;
using CinemaManagement.CashierPages.BookingDrink;
using CinemaManagement.CashierPages.BookingFood;
using CinemaManagement.CashierPages.BookingMovie;
using CinemaManagement.CashierPages.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class CashierForm : Form
    {

        BookingFoodContainer FoodContainer;
        BookingDrinkContainer DrinkContainer;
        InvoiceView InvoiceContainer;
        BookingMovieContainer MovieContainer;
        ShowTimeContainer StContainer;

        public bool IsFoodBooking { set { IsFoodBooking = value; IsDrinkBooking = !value; IsShowTimeBooking = !value; } }
        public bool IsDrinkBooking { set { IsFoodBooking = !value; IsDrinkBooking = value; IsShowTimeBooking = !value; } }
        public bool IsShowTimeBooking { set { IsFoodBooking = !value; IsDrinkBooking = !value; IsShowTimeBooking = value; } }

        public CashierForm()
        {
            InitializeComponent();
            RefreshPage();
        }

        private void RefreshPage()
        {
            
            FoodContainer = new BookingFoodContainer();
            DrinkContainer = new BookingDrinkContainer();
            InvoiceContainer = new InvoiceView();
            MovieContainer = new BookingMovieContainer();
            StContainer = new ShowTimeContainer();

            InvoiceContainer.Dock = DockStyle.Fill;
            FoodContainer.Dock = DockStyle.Fill;
            DrinkContainer.Dock = DockStyle.Fill;
            MovieContainer.Dock = DockStyle.Fill;
            StContainer.Dock = DockStyle.Fill;

            FoodContainer.ChooseFood += AddItemEvent;
            DrinkContainer.ChooseDrink += AddItemEvent;
            StContainer.ChooseShowTime += AddItemEvent;
            MovieContainer.ChooseMovie += MovieContainer_ChooseMovie;

            panel_BookingContainer.Controls.Clear();
            panel_InvoiceContainer.Controls.Clear();
            panel_ShowTimeContainer.Controls.Clear();

            panel_InvoiceContainer.Controls.Add(InvoiceContainer);

            panel_BookingContainer.Controls.Add(FoodContainer);
            panel_BookingContainer.Controls.Add(DrinkContainer);
            panel_BookingContainer.Controls.Add(MovieContainer);

            panel_ShowTimeContainer.Controls.Add(StContainer);

            panel_BookingContainer.Controls["BookingMovieContainer"].BringToFront();
        }

        private void MovieContainer_ChooseMovie(string MovieID)
        {
            StContainer.ShowTimeList(MovieID);
        }

        private void AddItemEvent(string ID, string Name, int Price)
        {
            InvoiceContainer.AddItemToInvoice(ID, Name, Price);
        }

        private void NaviagationLabel_Hover(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));

        }

        private void NaviagationLabel_MouseOver(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
        }
        private void label_Food_Click(object sender, EventArgs e)
        {
            label_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            panel_BookingContainer.Controls["BookingFoodContainer"].BringToFront();
        }

        private void label_Drink_Click(object sender, EventArgs e)
        {
            label_Drink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            panel_BookingContainer.Controls["BookingDrinkContainer"].BringToFront();
        }

        private void label_ShowTime_Click(object sender, EventArgs e)
        {
            label_ShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            panel_BookingContainer.Controls["BookingMovieContainer"].BringToFront();

        }

        private void label_Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Enabled = false;
            adminForm.FormClosing += AdminForm_FormClosing;
            adminForm.Show();
            ;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            RefreshPage();
        }
    }
}
