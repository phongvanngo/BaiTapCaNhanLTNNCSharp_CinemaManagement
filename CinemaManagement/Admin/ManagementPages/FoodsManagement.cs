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
    public partial class FoodsManagement : BaseMangementPage
    {
        bool IsEditing = false;
        DataTable dtFoodList = new DataTable();

        int IndexRowSelected = -1;
        public FoodsManagement()
        {
            InitializeComponent();
            SetUpTableFoodList();
            RefreshFoodList();
        }
        void SetUpTableFoodList()
        {
            Table_FoodList.Columns.Clear();

            //add column for data table;
            dtFoodList.Columns.Add("FoodId", typeof(string));
            dtFoodList.Columns.Add("Name", typeof(string));
            dtFoodList.Columns.Add("Price", typeof(int));
            dtFoodList.Columns.Add("Image", typeof(string));

            Table_FoodList.DataSource = dtFoodList;

            //reassign column name
            Table_FoodList.Columns["FoodID"].HeaderText = "Mã món ăn";
            Table_FoodList.Columns["Name"].HeaderText = "Tên món ăn";
            Table_FoodList.Columns["Price"].HeaderText = "Giá";
            Table_FoodList.Columns["Image"].HeaderText = "Hình ảnh";

            // fix size cho columns
            Table_FoodList.Columns["FoodID"].FillWeight = 10F;
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
            List<FoodModel> foodList = FoodDataAccess.LoadFoods();
            foreach (var food in foodList)
            {
                dtFoodList.Rows.Add(
                food.FoodID,
                food.Name,
                food.Price,
                food.Image);
            }
        }
        private void button_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_FoodImage.ImageLocation = openFileDialog.FileName;
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
                textBox_NameOfFood.Text = dtFoodList.Rows[IndexRowSelected]["Name"].ToString();
                textBox_Price.Text = dtFoodList.Rows[IndexRowSelected]["Price"].ToString();
                pictureBox_FoodImage.ImageLocation = MyFunction.ConvertString(dtFoodList.Rows[IndexRowSelected]["Image"].ToString());

            }
        }

        private void ClearInput()
        {
            textBox_NameOfFood.Text = "";
            textBox_Price.Text = "";
            pictureBox_FoodImage.ImageLocation = "";
        }

        private void Button_UpdateFood_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                dtFoodList.Rows[IndexRowSelected]["Name"] = textBox_NameOfFood.Text;
                dtFoodList.Rows[IndexRowSelected]["Price"] = textBox_Price.Text;
                dtFoodList.Rows[IndexRowSelected]["Image"] = pictureBox_FoodImage.ImageLocation;

                FoodModel food = new FoodModel();

                food.FoodID = dtFoodList.Rows[IndexRowSelected]["FoodID"].ToString();
                food.Name = textBox_NameOfFood.Text;
                food.Image = pictureBox_FoodImage.ImageLocation == null ? "" : pictureBox_FoodImage.ImageLocation;
                food.Price = Convert.ToInt32(textBox_Price.Text);

                FoodDataAccess.UpdateFood(food);

                IsEditing = false;
                ClearInput();

            }
        }

        private bool CheckInputValid()
        {
            if (textBox_NameOfFood.Text == "" || textBox_NameOfFood == null) return false;
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
            FoodModel food = new FoodModel();
            food.FoodID = "FOD" + MyFunction.GenerateCode();
            food.Name = textBox_NameOfFood.Text;
            food.Image = pictureBox_FoodImage.ImageLocation == null ? "" : pictureBox_FoodImage.ImageLocation;
            food.Price = Convert.ToInt32(textBox_Price.Text);

            dtFoodList.Rows.Add(
            food.FoodID,
            food.Name,
            food.Price,
            food.Image);

            FoodDataAccess.SaveFood(food);

            ClearInput();
        }
        private void DeleteFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                try
                {
                    FoodDataAccess.DeleteFood((string)dtFoodList.Rows[IndexRowSelected]["FoodID"]);
                    dtFoodList.Rows[IndexRowSelected].Delete();

                }
                catch { }
            }
        }
    }
}
