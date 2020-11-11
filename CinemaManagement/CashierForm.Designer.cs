namespace CinemaManagement
{
    partial class CashierForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_InvoiceContainer = new System.Windows.Forms.Panel();
            this.panel_BookingContainer = new System.Windows.Forms.Panel();
            this.singleMovieShowTime1 = new CinemaManagement.CashierPages.BookingMovie.SingleMovieShowTime();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Admin = new System.Windows.Forms.Label();
            this.label_Drink = new System.Windows.Forms.Label();
            this.label_Food = new System.Windows.Forms.Label();
            this.label_ShowTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_ShowTimeContainer = new System.Windows.Forms.Panel();
            this.panel_BookingContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_InvoiceContainer
            // 
            this.panel_InvoiceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_InvoiceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_InvoiceContainer.Location = new System.Drawing.Point(3, 3);
            this.panel_InvoiceContainer.Name = "panel_InvoiceContainer";
            this.panel_InvoiceContainer.Size = new System.Drawing.Size(475, 510);
            this.panel_InvoiceContainer.TabIndex = 0;
            // 
            // panel_BookingContainer
            // 
            this.panel_BookingContainer.AutoScroll = true;
            this.panel_BookingContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel_BookingContainer.Controls.Add(this.singleMovieShowTime1);
            this.panel_BookingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BookingContainer.Location = new System.Drawing.Point(481, 0);
            this.panel_BookingContainer.Name = "panel_BookingContainer";
            this.panel_BookingContainer.Size = new System.Drawing.Size(1256, 1033);
            this.panel_BookingContainer.TabIndex = 0;
            // 
            // singleMovieShowTime1
            // 
            this.singleMovieShowTime1.Location = new System.Drawing.Point(145, 69);
            this.singleMovieShowTime1.Name = "singleMovieShowTime1";
            this.singleMovieShowTime1.Size = new System.Drawing.Size(8, 8);
            this.singleMovieShowTime1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_Admin, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Drink, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Food, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_ShowTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1737, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 1033);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_Admin
            // 
            this.label_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Admin.Location = new System.Drawing.Point(3, 979);
            this.label_Admin.Name = "label_Admin";
            this.label_Admin.Size = new System.Drawing.Size(159, 54);
            this.label_Admin.TabIndex = 3;
            this.label_Admin.Text = "Quản trị viên";
            this.label_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Admin.Click += new System.EventHandler(this.label_Admin_Click);
            this.label_Admin.MouseEnter += new System.EventHandler(this.NaviagationLabel_Hover);
            this.label_Admin.MouseLeave += new System.EventHandler(this.NaviagationLabel_MouseOver);
            // 
            // label_Drink
            // 
            this.label_Drink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Drink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Drink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Drink.Location = new System.Drawing.Point(3, 102);
            this.label_Drink.Name = "label_Drink";
            this.label_Drink.Size = new System.Drawing.Size(159, 51);
            this.label_Drink.TabIndex = 2;
            this.label_Drink.Text = "Đồ uống";
            this.label_Drink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Drink.Click += new System.EventHandler(this.label_Drink_Click);
            this.label_Drink.MouseEnter += new System.EventHandler(this.NaviagationLabel_Hover);
            this.label_Drink.MouseLeave += new System.EventHandler(this.NaviagationLabel_MouseOver);
            // 
            // label_Food
            // 
            this.label_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Food.Location = new System.Drawing.Point(3, 51);
            this.label_Food.Name = "label_Food";
            this.label_Food.Size = new System.Drawing.Size(159, 51);
            this.label_Food.TabIndex = 1;
            this.label_Food.Text = "Món Ăn";
            this.label_Food.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Food.Click += new System.EventHandler(this.label_Food_Click);
            this.label_Food.MouseEnter += new System.EventHandler(this.NaviagationLabel_Hover);
            this.label_Food.MouseLeave += new System.EventHandler(this.NaviagationLabel_MouseOver);
            // 
            // label_ShowTime
            // 
            this.label_ShowTime.BackColor = System.Drawing.Color.Black;
            this.label_ShowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowTime.Location = new System.Drawing.Point(3, 0);
            this.label_ShowTime.Name = "label_ShowTime";
            this.label_ShowTime.Size = new System.Drawing.Size(159, 51);
            this.label_ShowTime.TabIndex = 0;
            this.label_ShowTime.Text = "Suất Chiếu";
            this.label_ShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ShowTime.Click += new System.EventHandler(this.label_ShowTime_Click);
            this.label_ShowTime.MouseEnter += new System.EventHandler(this.NaviagationLabel_Hover);
            this.label_ShowTime.MouseLeave += new System.EventHandler(this.NaviagationLabel_MouseOver);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel_ShowTimeContainer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_InvoiceContainer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 1033);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel_ShowTimeContainer
            // 
            this.panel_ShowTimeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ShowTimeContainer.Location = new System.Drawing.Point(3, 519);
            this.panel_ShowTimeContainer.Name = "panel_ShowTimeContainer";
            this.panel_ShowTimeContainer.Size = new System.Drawing.Size(475, 511);
            this.panel_ShowTimeContainer.TabIndex = 0;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel_BookingContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Management";
            this.panel_BookingContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InvoiceContainer;
        private System.Windows.Forms.Panel panel_BookingContainer;
        private CashierPages.BookingMovie.SingleMovieShowTime singleMovieShowTime1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Drink;
        private System.Windows.Forms.Label label_Food;
        private System.Windows.Forms.Label label_ShowTime;
        private System.Windows.Forms.Label label_Admin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_ShowTimeContainer;
    }
}

