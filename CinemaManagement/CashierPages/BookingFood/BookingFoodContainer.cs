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
using System.Data.Entity.Core.Objects.DataClasses;

namespace CinemaManagement.CashierPages.BookingFood
{
    public partial class BookingFoodContainer : UserControl
    {
        List<FoodModel> ListFood = new List<FoodModel>();

        public event AddItemInvoiceDelegate ChooseFood;
        public BookingFoodContainer()
        {
            InitializeComponent();
            ListFood = FoodDataAccess.LoadFoods();
            foreach (var food in ListFood)
            {
                FoodItem FoodButton = new FoodItem(food);
                FoodButton.MyClick += FoodButton_Click;
                FoodButton.Margin = new System.Windows.Forms.Padding(10);
                flowLayoutPanel_FoodList.Controls.Add(FoodButton);
            }
        }

        private void FoodButton_Click(object sender)
        {
            FoodModel food = (sender as FoodItem).Food;
            ChooseFood(food.FoodID, food.Name, food.Price);
        }
    }
}
