namespace CinemaManagement.Admin
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MovieManagementTabPage = new System.Windows.Forms.TabPage();
            this.TheaterManagementTabPage = new System.Windows.Forms.TabPage();
            this.ShowTimeManagementTabPage = new System.Windows.Forms.TabPage();
            this.DrinksManagementTabPage = new System.Windows.Forms.TabPage();
            this.FoodsManagementTabPage = new System.Windows.Forms.TabPage();
            this.OthersManagementTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MovieManagementTabPage);
            this.tabControl1.Controls.Add(this.TheaterManagementTabPage);
            this.tabControl1.Controls.Add(this.ShowTimeManagementTabPage);
            this.tabControl1.Controls.Add(this.DrinksManagementTabPage);
            this.tabControl1.Controls.Add(this.FoodsManagementTabPage);
            this.tabControl1.Controls.Add(this.OthersManagementTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // MovieManagementTabPage
            // 
            this.MovieManagementTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.MovieManagementTabPage.Name = "MovieManagementTabPage";
            this.MovieManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MovieManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.MovieManagementTabPage.TabIndex = 1;
            this.MovieManagementTabPage.Text = "Phim đang chiếu";
            this.MovieManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // TheaterManagementTabPage
            // 
            this.TheaterManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.TheaterManagementTabPage.Name = "TheaterManagementTabPage";
            this.TheaterManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TheaterManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.TheaterManagementTabPage.TabIndex = 2;
            this.TheaterManagementTabPage.Text = "Rạp chiếu";
            this.TheaterManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // ShowTimeManagementTabPage
            // 
            this.ShowTimeManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.ShowTimeManagementTabPage.Name = "ShowTimeManagementTabPage";
            this.ShowTimeManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShowTimeManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.ShowTimeManagementTabPage.TabIndex = 3;
            this.ShowTimeManagementTabPage.Text = "Suất chiếu";
            this.ShowTimeManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // DrinksManagementTabPage
            // 
            this.DrinksManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.DrinksManagementTabPage.Name = "DrinksManagementTabPage";
            this.DrinksManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DrinksManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.DrinksManagementTabPage.TabIndex = 4;
            this.DrinksManagementTabPage.Text = "Đồ uống";
            this.DrinksManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // FoodsManagementTabPage
            // 
            this.FoodsManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.FoodsManagementTabPage.Name = "FoodsManagementTabPage";
            this.FoodsManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FoodsManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.FoodsManagementTabPage.TabIndex = 5;
            this.FoodsManagementTabPage.Text = "Món ăn";
            this.FoodsManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // OthersManagementTabPage
            // 
            this.OthersManagementTabPage.Location = new System.Drawing.Point(4, 29);
            this.OthersManagementTabPage.Name = "OthersManagementTabPage";
            this.OthersManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OthersManagementTabPage.Size = new System.Drawing.Size(1054, 644);
            this.OthersManagementTabPage.TabIndex = 6;
            this.OthersManagementTabPage.Text = "Khác";
            this.OthersManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 677);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1080, 724);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MovieManagementTabPage;
        private System.Windows.Forms.TabPage TheaterManagementTabPage;
        private System.Windows.Forms.TabPage ShowTimeManagementTabPage;
        private System.Windows.Forms.TabPage DrinksManagementTabPage;
        private System.Windows.Forms.TabPage FoodsManagementTabPage;
        private System.Windows.Forms.TabPage OthersManagementTabPage;
    }
}