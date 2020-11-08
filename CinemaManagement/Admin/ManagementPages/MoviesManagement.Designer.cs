namespace CinemaManagement.Admin.ManagementPages
{
    partial class MoviesManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TicketPrice = new System.Windows.Forms.TextBox();
            this.button_AddMovie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_MovieImage = new System.Windows.Forms.PictureBox();
            this.button_AddImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Classify = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_UpdateMovie = new System.Windows.Forms.Button();
            this.textBox_NameOfMovie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Table_MovieList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_MovieListTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MovieImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_MovieList)).BeginInit();
            this.contextMenuStrip_MovieListTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(420, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Phim";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(533, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá vé";
            // 
            // textBox_TicketPrice
            // 
            this.textBox_TicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TicketPrice.Location = new System.Drawing.Point(533, 270);
            this.textBox_TicketPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TicketPrice.Name = "textBox_TicketPrice";
            this.textBox_TicketPrice.Size = new System.Drawing.Size(180, 30);
            this.textBox_TicketPrice.TabIndex = 4;
            // 
            // button_AddMovie
            // 
            this.button_AddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddMovie.ForeColor = System.Drawing.Color.Black;
            this.button_AddMovie.Location = new System.Drawing.Point(688, 329);
            this.button_AddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddMovie.Name = "button_AddMovie";
            this.button_AddMovie.Size = new System.Drawing.Size(161, 35);
            this.button_AddMovie.TabIndex = 5;
            this.button_AddMovie.Text = "Thêm phim mới";
            this.button_AddMovie.UseVisualStyleBackColor = true;
            this.button_AddMovie.Click += new System.EventHandler(this.button_AddMovie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown_min);
            this.groupBox1.Controls.Add(this.numericUpDown_Hour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox_MovieImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_AddImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Classify);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Button_UpdateMovie);
            this.groupBox1.Controls.Add(this.button_AddMovie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_TicketPrice);
            this.groupBox1.Controls.Add(this.textBox_NameOfMovie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1024, 369);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(799, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "phút";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(619, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "tiếng";
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.Location = new System.Drawing.Point(715, 189);
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(74, 30);
            this.numericUpDown_min.TabIndex = 15;
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Location = new System.Drawing.Point(538, 189);
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(67, 30);
            this.numericUpDown_Hour.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thời lượng phim";
            // 
            // pictureBox_MovieImage
            // 
            this.pictureBox_MovieImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_MovieImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox_MovieImage.InitialImage = null;
            this.pictureBox_MovieImage.Location = new System.Drawing.Point(36, 181);
            this.pictureBox_MovieImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_MovieImage.Name = "pictureBox_MovieImage";
            this.pictureBox_MovieImage.Size = new System.Drawing.Size(175, 175);
            this.pictureBox_MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MovieImage.TabIndex = 12;
            this.pictureBox_MovieImage.TabStop = false;
            // 
            // button_AddImage
            // 
            this.button_AddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddImage.Location = new System.Drawing.Point(229, 181);
            this.button_AddImage.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddImage.Name = "button_AddImage";
            this.button_AddImage.Size = new System.Drawing.Size(55, 35);
            this.button_AddImage.TabIndex = 11;
            this.button_AddImage.Text = "...";
            this.button_AddImage.UseVisualStyleBackColor = true;
            this.button_AddImage.Click += new System.EventHandler(this.button_add_image_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình ảnh";
            // 
            // comboBox_Classify
            // 
            this.comboBox_Classify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_Classify.FormattingEnabled = true;
            this.comboBox_Classify.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-13"});
            this.comboBox_Classify.Location = new System.Drawing.Point(533, 98);
            this.comboBox_Classify.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Classify.Name = "comboBox_Classify";
            this.comboBox_Classify.Size = new System.Drawing.Size(96, 33);
            this.comboBox_Classify.TabIndex = 8;
            this.comboBox_Classify.Text = "G";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(533, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phân loại phim";
            // 
            // Button_UpdateMovie
            // 
            this.Button_UpdateMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpdateMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_UpdateMovie.Location = new System.Drawing.Point(856, 329);
            this.Button_UpdateMovie.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UpdateMovie.Name = "Button_UpdateMovie";
            this.Button_UpdateMovie.Size = new System.Drawing.Size(161, 35);
            this.Button_UpdateMovie.TabIndex = 6;
            this.Button_UpdateMovie.Text = "Cập nhật";
            this.Button_UpdateMovie.UseVisualStyleBackColor = true;
            this.Button_UpdateMovie.Click += new System.EventHandler(this.Button_UpdateMovie_Click);
            // 
            // textBox_NameOfMovie
            // 
            this.textBox_NameOfMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_NameOfMovie.Location = new System.Drawing.Point(32, 98);
            this.textBox_NameOfMovie.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NameOfMovie.Name = "textBox_NameOfMovie";
            this.textBox_NameOfMovie.Size = new System.Drawing.Size(476, 30);
            this.textBox_NameOfMovie.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Table_MovieList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(0, 369);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1024, 399);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phim";
            // 
            // Table_MovieList
            // 
            this.Table_MovieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_MovieList.BackgroundColor = System.Drawing.Color.White;
            this.Table_MovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_MovieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MovieName,
            this.Time,
            this.Classify,
            this.Price,
            this.Image});
            this.Table_MovieList.ContextMenuStrip = this.contextMenuStrip_MovieListTable;
            this.Table_MovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_MovieList.Location = new System.Drawing.Point(4, 27);
            this.Table_MovieList.Margin = new System.Windows.Forms.Padding(4);
            this.Table_MovieList.Name = "Table_MovieList";
            this.Table_MovieList.ReadOnly = true;
            this.Table_MovieList.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Table_MovieList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table_MovieList.RowTemplate.Height = 24;
            this.Table_MovieList.Size = new System.Drawing.Size(1016, 368);
            this.Table_MovieList.TabIndex = 0;
            this.Table_MovieList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MovieList_MouseDown);
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Mã phim";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MovieName
            // 
            this.MovieName.FillWeight = 30F;
            this.MovieName.HeaderText = "Tên phim";
            this.MovieName.MinimumWidth = 6;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 15F;
            this.Time.HeaderText = "Thời lượng phim";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Classify
            // 
            this.Classify.FillWeight = 10F;
            this.Classify.HeaderText = "Phân loại";
            this.Classify.MinimumWidth = 6;
            this.Classify.Name = "Classify";
            this.Classify.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 20F;
            this.Price.HeaderText = "Giá vé";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.FillWeight = 15F;
            this.Image.HeaderText = "Hình ảnh";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // contextMenuStrip_MovieListTable
            // 
            this.contextMenuStrip_MovieListTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_MovieListTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaPhimToolStripMenuItem,
            this.xóaPhimToolStripMenuItem});
            this.contextMenuStrip_MovieListTable.Name = "contextMenuStrip1";
            this.contextMenuStrip_MovieListTable.Size = new System.Drawing.Size(181, 52);
            // 
            // chỉnhSửaPhimToolStripMenuItem
            // 
            this.chỉnhSửaPhimToolStripMenuItem.Name = "chỉnhSửaPhimToolStripMenuItem";
            this.chỉnhSửaPhimToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.chỉnhSửaPhimToolStripMenuItem.Text = "Chỉnh sửa phim";
            this.chỉnhSửaPhimToolStripMenuItem.Click += new System.EventHandler(this.EditMovieToolStripMenuItem_Click);
            // 
            // xóaPhimToolStripMenuItem
            // 
            this.xóaPhimToolStripMenuItem.Name = "xóaPhimToolStripMenuItem";
            this.xóaPhimToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.xóaPhimToolStripMenuItem.Text = "Xóa phim";
            this.xóaPhimToolStripMenuItem.Click += new System.EventHandler(this.DeleteMovieToolStripMenuItem_Click);
            // 
            // MoviesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MoviesManagement";
            this.Size = new System.Drawing.Size(1024, 768);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MovieImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_MovieList)).EndInit();
            this.contextMenuStrip_MovieListTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TicketPrice;
        private System.Windows.Forms.Button button_AddMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_UpdateMovie;
        private System.Windows.Forms.PictureBox pictureBox_MovieImage;
        private System.Windows.Forms.Button button_AddImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Classify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Table_MovieList;
        private System.Windows.Forms.TextBox textBox_NameOfMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.NumericUpDown numericUpDown_min;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_MovieListTable;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhimToolStripMenuItem;
    }
}
