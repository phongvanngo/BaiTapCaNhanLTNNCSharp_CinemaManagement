namespace CinemaManagement.CashierPages.BookingMovie
{
    partial class ButtonShowTime
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
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Theater = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Seats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Time
            // 
            this.label_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(0, 17);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(120, 60);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "17 : 50";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // label_Theater
            // 
            this.label_Theater.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Theater.Location = new System.Drawing.Point(0, 97);
            this.label_Theater.Name = "label_Theater";
            this.label_Theater.Size = new System.Drawing.Size(120, 23);
            this.label_Theater.TabIndex = 1;
            this.label_Theater.Text = "Rạp: B04";
            // 
            // label_Date
            // 
            this.label_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(0, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(120, 17);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "1/1/2020";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Seats
            // 
            this.label_Seats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Seats.Location = new System.Drawing.Point(0, 77);
            this.label_Seats.Name = "label_Seats";
            this.label_Seats.Size = new System.Drawing.Size(120, 20);
            this.label_Seats.TabIndex = 3;
            this.label_Seats.Text = "Reserved : 12/50";
            // 
            // ButtonShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Seats);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Theater);
            this.Name = "ButtonShowTime";
            this.Size = new System.Drawing.Size(120, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Theater;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Seats;
    }
}
