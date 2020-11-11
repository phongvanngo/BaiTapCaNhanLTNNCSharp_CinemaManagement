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

namespace CinemaManagement.CashierPages.Invoice
{
    public partial class InvoiceView : UserControl
    {

        DataTable invoice = new DataTable();
        public InvoiceView()
        {
            InitializeComponent();

            //invoice.Columns.Add("ID", typeof(int));
            invoice.Columns.Add("Name", typeof(string));
            invoice.Columns.Add("Amount", typeof(int));
            invoice.Columns.Add("Price", typeof(int));
            invoice.Columns.Add("Total", typeof(int));
            dataGridView1_Bill.DataSource = invoice;

            //reassign column name
            dataGridView1_Bill.Columns["Name"].HeaderText = "Tên";
            dataGridView1_Bill.Columns["Amount"].HeaderText = "Số lượng";
            dataGridView1_Bill.Columns["Price"].HeaderText = "Đơn giá";
            dataGridView1_Bill.Columns["Total"].HeaderText = "Thành tiền";

            //dataGridView1_Bill.Columns["Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // fix size cho columns
            dataGridView1_Bill.Columns["Name"].FillWeight = 60F;
            dataGridView1_Bill.Columns["Amount"].FillWeight = 10F;
            dataGridView1_Bill.Columns["Price"].FillWeight = 15F;
            dataGridView1_Bill.Columns["Total"].FillWeight = 15F;
        }

        public void UpdateThanhTien()
        {
            int sum = 0;
            for (int index = 0; index < invoice.Rows.Count; index++)
            {
                sum += (int)invoice.Rows[index]["Total"];
            }
            textBox1_ThanhTien.Text = sum + "";

        }

        public void AddItemToInvoice(string ID,string Name,int Price)
        {
            for (int index = 0; index < invoice.Rows.Count; index++)
            {
                if (((string)invoice.Rows[index]["Name"]) == Name)
                {
                    invoice.Rows[index]["Amount"] = ((int)invoice.Rows[index]["Amount"]) + 1;
                    invoice.Rows[index]["Total"] = ((int)invoice.Rows[index]["Price"]) * ((int)invoice.Rows[index]["Amount"]);
                    UpdateThanhTien();
                    return;
                }
            }
            invoice.Rows.Add(Name, 1, Price, Price);
            UpdateThanhTien();
        }

        private void dataGridView1_Bill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            //int selectedId = Convert.ToInt32(dataGridView_invoice.Rows[selectedRowIndex].Cells[0]);

            invoice.Rows[selectedRowIndex]["Total"] = ((int)invoice.Rows[selectedRowIndex]["Price"]) * ((int)invoice.Rows[selectedRowIndex]["Amount"]);
            UpdateThanhTien();
        }

        private void label3_TongCong_Click(object sender, EventArgs e)
        {
            int ThanhTien = 0;
            Int32.TryParse(textBox1_ThanhTien.Text,out ThanhTien);
            double discount = 0;
            double.TryParse(textBox3_Discount.Text, out discount);
            textBox2_Total.Text = (ThanhTien - ThanhTien * (discount/100)).ToString();
        }

        private void button_ExportInvoice_Click(object sender, EventArgs e)
        {
            InvoiceDetailForm invoiceForm = new InvoiceDetailForm(invoice);
            invoiceForm.Show();

        }
    }
}
