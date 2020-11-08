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
using CinemaManagement.MyUtilities;

namespace CinemaManagement.Admin.ManagementPages
{
    public partial class TheatersManagement : BaseMangementPage
    {
        bool IsEditing = false;
        DataTable dtTheaterList = new DataTable();
        int IndexRowSelected = -1;

        public TheatersManagement()
        {
            InitializeComponent();
            SetUpTableTheaterList();
            RefreshTheaterList();
        }

        void SetUpTableTheaterList()
        {
            Table_TheaterList.Columns.Clear();

            //add column for data table;
            dtTheaterList.Columns.Add("TheaterId", typeof(string));
            dtTheaterList.Columns.Add("Name", typeof(string));
            dtTheaterList.Columns.Add("Seats", typeof(int));


            Table_TheaterList.DataSource = dtTheaterList;

            //reassign column name
            Table_TheaterList.Columns["TheaterID"].HeaderText = "Mã rạp";
            Table_TheaterList.Columns["Name"].HeaderText = "Tên rạp";
            Table_TheaterList.Columns["Seats"].HeaderText = "Số chỗ ngồi";


            // fix size cho columns
            Table_TheaterList.Columns["TheaterID"].FillWeight = 10F;
            Table_TheaterList.Columns["Name"].FillWeight = 70F;
            Table_TheaterList.Columns["Seats"].FillWeight = 20F;


            //disable column sort
            foreach (DataGridViewColumn column in Table_TheaterList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        void RefreshTheaterList()
        {
            List<TheaterModel> theaterList = TheaterDataAccess.LoadTheaters();
            foreach (var theater in theaterList)
            {
                dtTheaterList.Rows.Add(
                theater.TheaterID,
                theater.Name,
                theater.Seats);
            }
        }
        private void Table_TheaterList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = Table_TheaterList.HitTest(e.X, e.Y);
                Table_TheaterList.ClearSelection();
                try
                {
                    Table_TheaterList.Rows[hti.RowIndex].Selected = true;
                    IndexRowSelected = hti.RowIndex;
                }
                // user right click outside rows
                catch
                {
                    IndexRowSelected = -1;
                };
            }
        }

        private void ClearInput()
        {
            textBox_NameOfTheater.Text = "";
            numericUpDown_Seats.Value = 50;
        }

        private bool CheckInputValid()
        {
            if (textBox_NameOfTheater.Text == "" || textBox_NameOfTheater == null) return false;
            return true;
        }

        private void button_AddTheater_Click(object sender, EventArgs e)
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
            TheaterModel theater = new TheaterModel();
            theater.TheaterID = "THR" + MyFunction.GenerateCode();
            theater.Name = textBox_NameOfTheater.Text;
            theater.Seats = (int)numericUpDown_Seats.Value;

            dtTheaterList.Rows.Add(
            theater.TheaterID,
            theater.Name,
            theater.Seats);

            TheaterDataAccess.SaveTheater(theater);

            ClearInput();
        }

        private void button_UpdateTheater_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                dtTheaterList.Rows[IndexRowSelected]["Name"] = textBox_NameOfTheater.Text;
                dtTheaterList.Rows[IndexRowSelected]["Seats"] = numericUpDown_Seats.Value;

                TheaterModel theater = new TheaterModel();

                theater.TheaterID = dtTheaterList.Rows[IndexRowSelected]["TheaterID"].ToString();
                theater.Seats = (int)numericUpDown_Seats.Value;
                theater.Name = textBox_NameOfTheater.Text;

                TheaterDataAccess.UpdateTheater(theater);

                IsEditing = false;
                ClearInput();

            }
        }
        private void editTheaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                IsEditing = true;
                textBox_NameOfTheater.Text = dtTheaterList.Rows[IndexRowSelected]["Name"].ToString();
                numericUpDown_Seats.Value = Convert.ToInt32(dtTheaterList.Rows[IndexRowSelected]["Seats"]);
            }
        }        
        private void deleteTheaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexRowSelected != -1)
            {
                TheaterDataAccess.DeleteTheater((string)dtTheaterList.Rows[IndexRowSelected]["TheaterID"]);
                dtTheaterList.Rows[IndexRowSelected].Delete();
            }
        }
    }
}
