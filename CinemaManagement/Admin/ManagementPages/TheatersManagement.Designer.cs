namespace CinemaManagement.Admin.ManagementPages
{
    partial class TheatersManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AddTheater = new System.Windows.Forms.Button();
            this.textBox_NameOfTheater = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Table_TheaterList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheaterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_TheaterListTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_UpdateTheater = new System.Windows.Forms.Button();
            this.numericUpDown_Seats = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_TheaterList)).BeginInit();
            this.contextMenuStrip_TheaterListTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seats)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên rạp";
            // 
            // button_AddTheater
            // 
            this.button_AddTheater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddTheater.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_AddTheater.Location = new System.Drawing.Point(736, 256);
            this.button_AddTheater.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddTheater.Name = "button_AddTheater";
            this.button_AddTheater.Size = new System.Drawing.Size(161, 35);
            this.button_AddTheater.TabIndex = 5;
            this.button_AddTheater.Text = "Thêm Rạp";
            this.button_AddTheater.UseVisualStyleBackColor = true;
            this.button_AddTheater.Click += new System.EventHandler(this.button_AddTheater_Click);
            // 
            // textBox_NameOfTheater
            // 
            this.textBox_NameOfTheater.Location = new System.Drawing.Point(34, 97);
            this.textBox_NameOfTheater.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NameOfTheater.Name = "textBox_NameOfTheater";
            this.textBox_NameOfTheater.Size = new System.Drawing.Size(363, 30);
            this.textBox_NameOfTheater.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Table_TheaterList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1080, 425);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách rạp";
            // 
            // Table_TheaterList
            // 
            this.Table_TheaterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_TheaterList.BackgroundColor = System.Drawing.Color.White;
            this.Table_TheaterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_TheaterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TheaterName,
            this.Seat});
            this.Table_TheaterList.ContextMenuStrip = this.contextMenuStrip_TheaterListTable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_TheaterList.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table_TheaterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_TheaterList.Location = new System.Drawing.Point(4, 27);
            this.Table_TheaterList.Margin = new System.Windows.Forms.Padding(4);
            this.Table_TheaterList.Name = "Table_TheaterList";
            this.Table_TheaterList.ReadOnly = true;
            this.Table_TheaterList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Table_TheaterList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Table_TheaterList.RowTemplate.Height = 24;
            this.Table_TheaterList.Size = new System.Drawing.Size(1072, 394);
            this.Table_TheaterList.TabIndex = 0;
            this.Table_TheaterList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_TheaterList_MouseDown);
            // 
            // Id
            // 
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Mã Rạp";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // TheaterName
            // 
            this.TheaterName.FillWeight = 50F;
            this.TheaterName.HeaderText = "Tên Rạp";
            this.TheaterName.MinimumWidth = 6;
            this.TheaterName.Name = "TheaterName";
            this.TheaterName.ReadOnly = true;
            // 
            // Seat
            // 
            this.Seat.FillWeight = 30F;
            this.Seat.HeaderText = "Số lượng ghế";
            this.Seat.MinimumWidth = 6;
            this.Seat.Name = "Seat";
            this.Seat.ReadOnly = true;
            // 
            // contextMenuStrip_TheaterListTable
            // 
            this.contextMenuStrip_TheaterListTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_TheaterListTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaPhimToolStripMenuItem,
            this.xóaPhimToolStripMenuItem});
            this.contextMenuStrip_TheaterListTable.Name = "contextMenuStrip1";
            this.contextMenuStrip_TheaterListTable.Size = new System.Drawing.Size(169, 52);
            // 
            // chỉnhSửaPhimToolStripMenuItem
            // 
            this.chỉnhSửaPhimToolStripMenuItem.Name = "chỉnhSửaPhimToolStripMenuItem";
            this.chỉnhSửaPhimToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.chỉnhSửaPhimToolStripMenuItem.Text = "Chỉnh sửa rạp";
            this.chỉnhSửaPhimToolStripMenuItem.Click += new System.EventHandler(this.editTheaterToolStripMenuItem_Click);
            // 
            // xóaPhimToolStripMenuItem
            // 
            this.xóaPhimToolStripMenuItem.Name = "xóaPhimToolStripMenuItem";
            this.xóaPhimToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.xóaPhimToolStripMenuItem.Text = "Xóa rạp";
            this.xóaPhimToolStripMenuItem.Click += new System.EventHandler(this.deleteTheaterToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_UpdateTheater);
            this.groupBox1.Controls.Add(this.numericUpDown_Seats);
            this.groupBox1.Controls.Add(this.button_AddTheater);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_NameOfTheater);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 299);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button_UpdateTheater
            // 
            this.button_UpdateTheater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UpdateTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateTheater.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_UpdateTheater.Location = new System.Drawing.Point(905, 256);
            this.button_UpdateTheater.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateTheater.Name = "button_UpdateTheater";
            this.button_UpdateTheater.Size = new System.Drawing.Size(161, 35);
            this.button_UpdateTheater.TabIndex = 10;
            this.button_UpdateTheater.Text = "Cập nhật";
            this.button_UpdateTheater.UseVisualStyleBackColor = true;
            this.button_UpdateTheater.Click += new System.EventHandler(this.button_UpdateTheater_Click);
            // 
            // numericUpDown_Seats
            // 
            this.numericUpDown_Seats.Location = new System.Drawing.Point(34, 159);
            this.numericUpDown_Seats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Seats.Name = "numericUpDown_Seats";
            this.numericUpDown_Seats.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_Seats.TabIndex = 9;
            this.numericUpDown_Seats.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(454, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý rạp chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số ghế";
            // 
            // TheatersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TheatersManagement";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_TheaterList)).EndInit();
            this.contextMenuStrip_TheaterListTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Seats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AddTheater;
        private System.Windows.Forms.TextBox textBox_NameOfTheater;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Table_TheaterList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheaterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.NumericUpDown numericUpDown_Seats;
        private System.Windows.Forms.Button button_UpdateTheater;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_TheaterListTable;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhimToolStripMenuItem;
    }
}
