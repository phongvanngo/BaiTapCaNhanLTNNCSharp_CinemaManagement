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

namespace CinemaManagement.CashierPages.BookingDrink
{
    public partial class BookingDrinkContainer : UserControl
    {
        List<DrinkModel> ListDrink = new List<DrinkModel>();

        public event AddItemInvoiceDelegate ChooseDrink;
        public BookingDrinkContainer()
        {
            InitializeComponent();
            ListDrink = DrinkDataAccess.LoadDrinks();
            foreach (var drink in ListDrink)
            {
                DrinkItem DrinkButton = new DrinkItem(drink);
                DrinkButton.MyClick += DrinkButton_Click;
                DrinkButton.Margin = new System.Windows.Forms.Padding(10);
                flowLayoutPanel_DrinkList.Controls.Add(DrinkButton);
            }
        }

        private void DrinkButton_Click(object sender)
        {
            DrinkModel drink = (sender as DrinkItem).Drink;
            ChooseDrink(drink.DrinkID, drink.Name, drink.Price);
        }
    }
}
