namespace CinemaManagement.CashierPages.BookingMovie
{
    partial class ShowTimeContainer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MovieTime = new System.Windows.Forms.Label();
            this.label_MovieName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_MoviePrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ShowTimeList = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_MoviePrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_MovieTime);
            this.panel1.Controls.Add(this.label_MovieName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 127);
            this.panel1.TabIndex = 0;
            // 
            // label_MovieTime
            // 
            this.label_MovieTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MovieTime.Location = new System.Drawing.Point(4, 32);
            this.label_MovieTime.Name = "label_MovieTime";
            this.label_MovieTime.Size = new System.Drawing.Size(331, 28);
            this.label_MovieTime.TabIndex = 1;
            this.label_MovieTime.Text = "Thời lượng:  2 tiếng 15 phút";
            // 
            // label_MovieName
            // 
            this.label_MovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MovieName.Location = new System.Drawing.Point(3, 0);
            this.label_MovieName.Name = "label_MovieName";
            this.label_MovieName.Size = new System.Drawing.Size(474, 32);
            this.label_MovieName.TabIndex = 0;
            this.label_MovieName.Text = "Thám tử lừng danh Conan (PG-13)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel_ShowTimeList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 373);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá vé: ";
            // 
            // label_MoviePrice
            // 
            this.label_MoviePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MoviePrice.Location = new System.Drawing.Point(66, 58);
            this.label_MoviePrice.Name = "label_MoviePrice";
            this.label_MoviePrice.Size = new System.Drawing.Size(133, 28);
            this.label_MoviePrice.TabIndex = 4;
            this.label_MoviePrice.Text = "55000";
            // 
            // flowLayoutPanel_ShowTimeList
            // 
            this.flowLayoutPanel_ShowTimeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_ShowTimeList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_ShowTimeList.Name = "flowLayoutPanel_ShowTimeList";
            this.flowLayoutPanel_ShowTimeList.Size = new System.Drawing.Size(480, 373);
            this.flowLayoutPanel_ShowTimeList.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(480, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Các suất chiếu có sẵn:";
            // 
            // ShowTimeContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShowTimeContainer";
            this.Size = new System.Drawing.Size(480, 500);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MovieTime;
        private System.Windows.Forms.Label label_MovieName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_MoviePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ShowTimeList;
        private System.Windows.Forms.Label label6;
    }
}
