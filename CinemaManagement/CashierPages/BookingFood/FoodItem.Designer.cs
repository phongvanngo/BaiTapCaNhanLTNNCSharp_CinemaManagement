namespace CinemaManagement.CashierPages.BookingFood
{
    partial class FoodItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodItem));
            this.pictureBox_FoodImage = new System.Windows.Forms.PictureBox();
          
            this.label_FoodName = new System.Windows.Forms.Label();
            this.label_FoodPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_FoodImage
            // 
            this.pictureBox_FoodImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_FoodImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_FoodImage.Image")));
            this.pictureBox_FoodImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_FoodImage.Name = "pictureBox_FoodImage";
            this.pictureBox_FoodImage.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox_FoodImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_FoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FoodImage.TabIndex = 0;
            this.pictureBox_FoodImage.TabStop = false;
            this.pictureBox_FoodImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FoodItem_MouseDown);
            this.pictureBox_FoodImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoodItem_MouseUp);
          
            // 
            // label_FoodName
            // 
            this.label_FoodName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FoodName.Location = new System.Drawing.Point(3, 153);
            this.label_FoodName.Name = "label_FoodName";
            this.label_FoodName.Size = new System.Drawing.Size(144, 23);
            this.label_FoodName.TabIndex = 2;
            this.label_FoodName.Text = "Tên món ăn";
            this.label_FoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FoodPrice
            // 
            this.label_FoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FoodPrice.Location = new System.Drawing.Point(3, 177);
            this.label_FoodPrice.Name = "label_FoodPrice";
            this.label_FoodPrice.Size = new System.Drawing.Size(144, 23);
            this.label_FoodPrice.TabIndex = 3;
            this.label_FoodPrice.Text = "Giá: 100000";
            this.label_FoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label_FoodPrice);
            this.Controls.Add(this.label_FoodName);
            this.Controls.Add(this.pictureBox_FoodImage);
            this.Name = "FoodItem";
            this.Size = new System.Drawing.Size(150, 200);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FoodItem_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoodItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_FoodImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FoodName;
        private System.Windows.Forms.Label label_FoodPrice;
    }
}
