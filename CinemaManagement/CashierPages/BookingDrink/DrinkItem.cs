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

namespace CinemaManagement.CashierPages.BookingDrink
{
    public partial class DrinkItem : UserControl
    {
        DrinkModel drink = new DrinkModel();
        public event UserControlClickDelegate MyClick;
        public DrinkItem(DrinkModel f)
        {
            InitializeComponent();
            drink = f;
            pictureBox_FoodImage.ImageLocation = drink.Image;
            label_FoodName.Text = drink.Name;
            label_FoodPrice.Text = drink.Price.ToString();
        }
        internal DrinkModel Drink { get => drink; set => drink = value; }

        private void FoodItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            MyClick(this);
        }

        private void FoodItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        
    }
}
