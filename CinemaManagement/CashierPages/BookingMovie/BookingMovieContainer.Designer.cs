namespace CinemaManagement.CashierPages.BookingMovie
{
    partial class BookingMovieContainer
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
            this.flowLayoutPanel_MovieList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_MovieList
            // 
            this.flowLayoutPanel_MovieList.AutoScroll = true;
            this.flowLayoutPanel_MovieList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_MovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_MovieList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_MovieList.Name = "flowLayoutPanel_MovieList";
            this.flowLayoutPanel_MovieList.Size = new System.Drawing.Size(1350, 1033);
            this.flowLayoutPanel_MovieList.TabIndex = 0;
            // 
            // BookingMovieContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.flowLayoutPanel_MovieList);
            this.Name = "BookingMovieContainer";
            this.Size = new System.Drawing.Size(1350, 1033);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_MovieList;
    }
}
