namespace CinemaManagement.CashierPages.Invoice
{
    partial class InvoiceView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1_Bill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_TongCong = new System.Windows.Forms.Label();
            this.textBox1_ThanhTien = new System.Windows.Forms.TextBox();
            this.textBox2_Total = new System.Windows.Forms.TextBox();
            this.textBox3_Discount = new System.Windows.Forms.TextBox();
            this.button_ExportInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Bill
            // 
            this.dataGridView1_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Bill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1_Bill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_Bill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1_Bill.GridColor = System.Drawing.Color.White;
            this.dataGridView1_Bill.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1_Bill.Name = "dataGridView1_Bill";
            this.dataGridView1_Bill.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1_Bill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1_Bill.RowTemplate.Height = 24;
            this.dataGridView1_Bill.Size = new System.Drawing.Size(424, 425);
            this.dataGridView1_Bill.TabIndex = 0;
            this.dataGridView1_Bill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Bill_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạm tính";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giảm giá: %";
            // 
            // label3_TongCong
            // 
            this.label3_TongCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_TongCong.AutoSize = true;
            this.label3_TongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_TongCong.Location = new System.Drawing.Point(77, 515);
            this.label3_TongCong.Name = "label3_TongCong";
            this.label3_TongCong.Size = new System.Drawing.Size(85, 17);
            this.label3_TongCong.TabIndex = 8;
            this.label3_TongCong.Text = "Tổng cộng";
            this.label3_TongCong.Click += new System.EventHandler(this.label3_TongCong_Click);
            // 
            // textBox1_ThanhTien
            // 
            this.textBox1_ThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_ThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ThanhTien.Location = new System.Drawing.Point(178, 457);
            this.textBox1_ThanhTien.Name = "textBox1_ThanhTien";
            this.textBox1_ThanhTien.Size = new System.Drawing.Size(249, 22);
            this.textBox1_ThanhTien.TabIndex = 9;
            // 
            // textBox2_Total
            // 
            this.textBox2_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox2_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Total.Location = new System.Drawing.Point(178, 515);
            this.textBox2_Total.Name = "textBox2_Total";
            this.textBox2_Total.Size = new System.Drawing.Size(249, 22);
            this.textBox2_Total.TabIndex = 10;
            // 
            // textBox3_Discount
            // 
            this.textBox3_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox3_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Discount.Location = new System.Drawing.Point(178, 486);
            this.textBox3_Discount.Name = "textBox3_Discount";
            this.textBox3_Discount.Size = new System.Drawing.Size(249, 22);
            this.textBox3_Discount.TabIndex = 11;
            // 
            // button_ExportInvoice
            // 
            this.button_ExportInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExportInvoice.BackColor = System.Drawing.Color.Black;
            this.button_ExportInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ExportInvoice.Location = new System.Drawing.Point(331, 544);
            this.button_ExportInvoice.Name = "button_ExportInvoice";
            this.button_ExportInvoice.Size = new System.Drawing.Size(96, 53);
            this.button_ExportInvoice.TabIndex = 12;
            this.button_ExportInvoice.Text = "Xuất hóa đơn";
            this.button_ExportInvoice.UseVisualStyleBackColor = false;
            this.button_ExportInvoice.Click += new System.EventHandler(this.button_ExportInvoice_Click);
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.button_ExportInvoice);
            this.Controls.Add(this.textBox3_Discount);
            this.Controls.Add(this.textBox2_Total);
            this.Controls.Add(this.textBox1_ThanhTien);
            this.Controls.Add(this.label3_TongCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_Bill);
            this.Name = "InvoiceView";
            this.Size = new System.Drawing.Size(430, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_TongCong;
        private System.Windows.Forms.TextBox textBox1_ThanhTien;
        private System.Windows.Forms.TextBox textBox2_Total;
        private System.Windows.Forms.TextBox textBox3_Discount;
        private System.Windows.Forms.Button button_ExportInvoice;
    }
}
