namespace CinemaManagement.Admin.ManagementPages
{
    partial class DrinksManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox_DrinkImage = new System.Windows.Forms.PictureBox();
            this.button_AddImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_UpdateDrink = new System.Windows.Forms.Button();
            this.Button_AddDrink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_NameOfDrink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Table_FoodList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_FoodListTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DrinkImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_FoodList)).BeginInit();
            this.contextMenuStrip_FoodListTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_DrinkImage
            // 
            this.pictureBox_DrinkImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_DrinkImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox_DrinkImage.Location = new System.Drawing.Point(32, 160);
            this.pictureBox_DrinkImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_DrinkImage.Name = "pictureBox_DrinkImage";
            this.pictureBox_DrinkImage.Size = new System.Drawing.Size(175, 175);
            this.pictureBox_DrinkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DrinkImage.TabIndex = 12;
            this.pictureBox_DrinkImage.TabStop = false;
            // 
            // button_AddImage
            // 
            this.button_AddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddImage.Location = new System.Drawing.Point(215, 160);
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
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình ảnh";
            // 
            // Button_UpdateDrink
            // 
            this.Button_UpdateDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UpdateDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpdateDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_UpdateDrink.Location = new System.Drawing.Point(911, 323);
            this.Button_UpdateDrink.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UpdateDrink.Name = "Button_UpdateDrink";
            this.Button_UpdateDrink.Size = new System.Drawing.Size(161, 35);
            this.Button_UpdateDrink.TabIndex = 6;
            this.Button_UpdateDrink.Text = "Cập nhật";
            this.Button_UpdateDrink.UseVisualStyleBackColor = true;
            this.Button_UpdateDrink.Click += new System.EventHandler(this.Button_UpdateFood_Click);
            // 
            // Button_AddDrink
            // 
            this.Button_AddDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_AddDrink.Location = new System.Drawing.Point(743, 323);
            this.Button_AddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddDrink.Name = "Button_AddDrink";
            this.Button_AddDrink.Size = new System.Drawing.Size(161, 35);
            this.Button_AddDrink.TabIndex = 5;
            this.Button_AddDrink.Text = "Thêm mới";
            this.Button_AddDrink.UseVisualStyleBackColor = true;
            this.Button_AddDrink.Click += new System.EventHandler(this.button_AddFood_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đồ uống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(433, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý đồ uống";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox_DrinkImage);
            this.groupBox1.Controls.Add(this.button_AddImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Button_UpdateDrink);
            this.groupBox1.Controls.Add(this.Button_AddDrink);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Price);
            this.groupBox1.Controls.Add(this.textBox_NameOfDrink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 366);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Price.Location = new System.Drawing.Point(533, 93);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(180, 30);
            this.textBox_Price.TabIndex = 4;
            // 
            // textBox_NameOfDrink
            // 
            this.textBox_NameOfDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_NameOfDrink.Location = new System.Drawing.Point(32, 93);
            this.textBox_NameOfDrink.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NameOfDrink.Name = "textBox_NameOfDrink";
            this.textBox_NameOfDrink.Size = new System.Drawing.Size(476, 30);
            this.textBox_NameOfDrink.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(528, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá";
            // 
            // Table_FoodList
            // 
            this.Table_FoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_FoodList.BackgroundColor = System.Drawing.Color.White;
            this.Table_FoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_FoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodName,
            this.Price,
            this.Image});
            this.Table_FoodList.ContextMenuStrip = this.contextMenuStrip_FoodListTable;
            this.Table_FoodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_FoodList.Location = new System.Drawing.Point(4, 27);
            this.Table_FoodList.Margin = new System.Windows.Forms.Padding(4);
            this.Table_FoodList.Name = "Table_FoodList";
            this.Table_FoodList.ReadOnly = true;
            this.Table_FoodList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Table_FoodList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Table_FoodList.RowTemplate.Height = 24;
            this.Table_FoodList.Size = new System.Drawing.Size(1072, 327);
            this.Table_FoodList.TabIndex = 0;
            this.Table_FoodList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_FoodList_MouseDown);
            // 
            // Id
            // 
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Mã món ăn";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.FillWeight = 40F;
            this.FoodName.HeaderText = "Tên món ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 20F;
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.FillWeight = 20F;
            this.Image.HeaderText = "Hình ảnh";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // contextMenuStrip_FoodListTable
            // 
            this.contextMenuStrip_FoodListTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_FoodListTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaPhimToolStripMenuItem,
            this.xóaPhimToolStripMenuItem});
            this.contextMenuStrip_FoodListTable.Name = "contextMenuStrip1";
            this.contextMenuStrip_FoodListTable.Size = new System.Drawing.Size(203, 52);
            // 
            // chỉnhSửaPhimToolStripMenuItem
            // 
            this.chỉnhSửaPhimToolStripMenuItem.Name = "chỉnhSửaPhimToolStripMenuItem";
            this.chỉnhSửaPhimToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.chỉnhSửaPhimToolStripMenuItem.Text = "Chỉnh sửa đồ uống";
            this.chỉnhSửaPhimToolStripMenuItem.Click += new System.EventHandler(this.EditFoodToolStripMenuItem_Click);
            // 
            // xóaPhimToolStripMenuItem
            // 
            this.xóaPhimToolStripMenuItem.Name = "xóaPhimToolStripMenuItem";
            this.xóaPhimToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.xóaPhimToolStripMenuItem.Text = "Xóa đồ uống";
            this.xóaPhimToolStripMenuItem.Click += new System.EventHandler(this.DeleteFoodToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Table_FoodList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 366);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1080, 358);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đồ uống";
            // 
            // DrinksManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DrinksManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DrinkImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_FoodList)).EndInit();
            this.contextMenuStrip_FoodListTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_DrinkImage;
        private System.Windows.Forms.Button button_AddImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_UpdateDrink;
        private System.Windows.Forms.Button Button_AddDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_NameOfDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Table_FoodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_FoodListTable;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhimToolStripMenuItem;
    }
}
