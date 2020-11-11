using CinemaManagement.Admin.ManagementPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.Admin
{
    public partial class AdminForm : Form
    {
        DrinksManagement DrinkPage = new DrinksManagement();
        FoodsManagement FoodPage = new FoodsManagement();
        MoviesManagement MoviePage = new MoviesManagement();
        ShowTimeManagement ShowTimePage = new ShowTimeManagement();
        TheatersManagement TheaterPage = new TheatersManagement();
        public AdminForm()
        {
            InitializeComponent();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            DrinkPage.Dock = DockStyle.Fill;
            FoodPage.Dock = DockStyle.Fill;
            MoviePage.Dock = DockStyle.Fill;
            TheaterPage.Dock = DockStyle.Fill;
            ShowTimePage.Dock = DockStyle.Fill;

            MovieManagementTabPage.Controls.Add(MoviePage);
            TheaterManagementTabPage.Controls.Add(TheaterPage);
            ShowTimeManagementTabPage.Controls.Add(ShowTimePage);
            FoodsManagementTabPage.Controls.Add(FoodPage);
            DrinksManagementTabPage.Controls.Add(DrinkPage);

            MoviePage.DataUpdateEvent += Event_DataUpdateEvent;
            TheaterPage.DataUpdateEvent += Event_DataUpdateEvent;
            
            
        }

        private void Event_DataUpdateEvent()
        {
            ShowTimePage.IsDataUpdate = true;
        }
    }
}
