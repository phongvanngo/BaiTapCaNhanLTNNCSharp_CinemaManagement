using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.CashierPages.Invoice
{
    public partial class InvoiceDetailForm : Form
    {
        DataTable invoice = new DataTable();
        public InvoiceDetailForm(DataTable invoice_detail)
        {
            InitializeComponent();
            this.invoice = invoice_detail;
            label_TimeExport.Text ="Thời gian: "+ DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
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
    }
}
