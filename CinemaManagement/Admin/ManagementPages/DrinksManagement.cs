using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.Database;
using CinemaManagement.Models;
using System.Reflection;
using CinemaManagement.Database.DataProvider;
using CinemaManagement.MyUtilities;
using System.Configuration;
using System.Runtime.InteropServices;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class DrinksManagement : BaseMangementPage
    {
        bool IsEditing = false;
        DataTable dtFoodList = new DataTable();

        int IndexRowSelected = -1;
        public DrinksManagement()
        {
            InitializeComponent();
            SetUpTableFoodList();
            RefreshFoodList();
        }
        void SetUpTableFoodList()
        {
            Table_FoodList.Columns.Clear();

            //add column for data table;
            dtFoodList.Columns.Add("DrinkId", typeof(string));
            dtFoodList.Columns.Add("Name", typeof(string));
            dtFoodList.Columns.Add("Price", typeof(int));
            dtFoodList.Columns.Add("Image", typeof(string));

            Table_FoodList.DataSource = dtFoodList;

            //reassign column name
            Table_FoodList.Columns["DrinkID"].HeaderText = "Mã đồ uống";
            Table_FoodList.Columns["Name"].HeaderText = "Tên đồ uống";
            Table_FoodList.Columns["Price"].HeaderText = "Giá";
            Table_FoodList.Columns["Image"].HeaderText = "Hình ảnh";

            // fix size cho columns
            Table_FoodList.Columns["DrinkID"].FillWeight = 10F;
            Table_FoodList.Columns["Name"].FillWeight = 60F;
            Table_FoodList.Columns["Price"].FillWeight = 15F;
            Table_FoodList.Columns["Image"].FillWeight = 15F;

            //disable column sort
            foreach (DataGridViewColumn column in Table_FoodList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        void RefreshFoodList()
        {
            List<DrinkModel> drinkList = DrinkDataAccess.LoadDrinks();
            foreach (var drink in drinkList)
            {
                dtFoodList.Rows.Add(
                drink.DrinkID,
                drink.Name,
                drink.Price,
                drink.Image);
            }
        }
        private void button_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_DrinkImage.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Table_FoodList_MouseDown(object sender, MouseEventArgs e)
        {
            // user right click to datagridview
            if (e.Button == MouseButtons.Right)
            {
                var hti = Table_FoodList.HitTest(e.X, e.Y);
                Table_FoodList.ClearSelection();
                try
                {
                    Table_FoodList.Rows[hti.RowIndex].Selected = true;
                    IndexRowSelected = hti.RowIndex;
                }
                // user right click outside rows
                catch
                {
                    IndexRowSelected = -1;
                };
            }
        }

        private void EditFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (IndexRowSelected != -1)
            {
                IsEditing = true;
                textBox_NameOfDrink.Text = dtFoodList.Rows[IndexRowSelected]["Name"].ToString();
                textBox_Price.Text = dtFoodList.Rows[IndexRowSelected]["Price"].ToString();
                pictureBox_DrinkImage.ImageLocation = MyFunction.ConvertString(dtFoodList.Rows[IndexRowSelected]["Image"].ToString());

            }
        }

        private void ClearInput()
        {
            textBox_NameOfDrink.Text = "";
            textBox_Price.Text = "";
            pictureBox_DrinkImage.ImageLocation = "";
        }

        private void Button_UpdateFood_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                dtFoodList.Rows[IndexRowSelected]["Name"] = textBox_NameOfDrink.Text;
                dtFoodList.Rows[IndexRowSelected]["Price"] = textBox_Price.Text;
                dtFoodList.Rows[IndexRowSelected]["Image"] = pictureBox_DrinkImage.ImageLocation;

                DrinkModel drink = new DrinkModel();

                drink.DrinkID = dtFoodList.Rows[IndexRowSelected]["DrinkID"].ToString();
                drink.Name = textBox_NameOfDrink.Text;
                drink.Image = pictureBox_DrinkImage.ImageLocation == null ? "" : pictureBox_DrinkImage.ImageLocation;
                drink.Price = Convert.ToInt32(textBox_Price.Text);

                DrinkDataAccess.UpdateDrink(drink);

                IsEditing = false;
                ClearInput();

            }
        }

        private bool CheckInputValid()
        {
            if (textBox_NameOfDrink.Text == "" || textBox_NameOfDrink == null) return false;
            if (Int32.TryParse(textBox_Price.Text, out int result) == false) return false;
            return true;
        }
        private void button_AddFood_Click(object sender, EventArgs e)
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
            DrinkModel drink = new DrinkModel();
            drink.DrinkID = "DRK" + MyFunction.GenerateCode();
            drink.Name = textBox_NameOfDrink.Text;
            drink.Image = pictureBox_DrinkImage.ImageLocation == null ? "" : pictureBox_DrinkImage.ImageLocation;
            drink.Price = Convert.ToInt32(textBox_Price.Text);

            dtFoodList.Rows.Add(
            drink.DrinkID,
            drink.Name,
            drink.Price,
            drink.Image);

            DrinkDataAccess.SaveDrink(drink);

            ClearInput();
        }
        private void DeleteFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                try
                {
                    FoodDataAccess.DeleteFood((string)dtFoodList.Rows[IndexRowSelected]["DrinkID"]);
                    dtFoodList.Rows[IndexRowSelected].Delete();
                }
                catch { };
            }
        }
    }
}
