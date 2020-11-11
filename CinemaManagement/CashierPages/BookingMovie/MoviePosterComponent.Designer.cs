namespace CinemaManagement.CashierPages.BookingMovie
{
    partial class MoviePosterComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviePosterComponent));
            this.pictureBox_MovieImage = new System.Windows.Forms.PictureBox();
            this.label_MovieName = new System.Windows.Forms.Label();
            this.label_MovieClassify = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_MovieImage
            // 
            this.pictureBox_MovieImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MovieImage.Image")));
            this.pictureBox_MovieImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_MovieImage.Name = "pictureBox_MovieImage";
            this.pictureBox_MovieImage.Size = new System.Drawing.Size(162, 240);
            this.pictureBox_MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MovieImage.TabIndex = 0;
            this.pictureBox_MovieImage.TabStop = false;
            this.pictureBox_MovieImage.Click += new System.EventHandler(this.pictureBox_MovieImage_Click);
            // 
            // label_MovieName
            // 
            this.label_MovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MovieName.ForeColor = System.Drawing.Color.White;
            this.label_MovieName.Location = new System.Drawing.Point(0, 243);
            this.label_MovieName.Name = "label_MovieName";
            this.label_MovieName.Size = new System.Drawing.Size(162, 23);
            this.label_MovieName.TabIndex = 1;
            this.label_MovieName.Text = "In the heart of sea";
            // 
            // label_MovieClassify
            // 
            this.label_MovieClassify.ForeColor = System.Drawing.Color.White;
            this.label_MovieClassify.Location = new System.Drawing.Point(0, 262);
            this.label_MovieClassify.Name = "label_MovieClassify";
            this.label_MovieClassify.Size = new System.Drawing.Size(165, 23);
            this.label_MovieClassify.TabIndex = 2;
            this.label_MovieClassify.Text = "PG-13";
            // 
            // MoviePosterComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_MovieClassify);
            this.Controls.Add(this.label_MovieName);
            this.Controls.Add(this.pictureBox_MovieImage);
            this.Name = "MoviePosterComponent";
            this.Size = new System.Drawing.Size(162, 295);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MovieImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_MovieImage;
        private System.Windows.Forms.Label label_MovieName;
        private System.Windows.Forms.Label label_MovieClassify;
    }
}
