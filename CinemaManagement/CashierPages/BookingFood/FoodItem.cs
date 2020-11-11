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

namespace CinemaManagement.CashierPages.BookingFood
{
    public partial class FoodItem : UserControl
    {
        FoodModel food = new FoodModel();
        public event UserControlClickDelegate MyClick;
        public FoodItem(FoodModel f)
        {
            InitializeComponent();
            food = f;
            pictureBox_FoodImage.ImageLocation = food.Image;
            label_FoodName.Text = food.Name;
            label_FoodPrice.Text = food.Price.ToString();
        }
        internal FoodModel Food { get => food; set => food = value; }

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
