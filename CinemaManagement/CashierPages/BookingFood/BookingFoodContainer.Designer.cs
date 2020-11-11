namespace CinemaManagement.CashierPages.BookingFood
{
    partial class BookingFoodContainer
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
            this.flowLayoutPanel_FoodList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_FoodList
            // 
            this.flowLayoutPanel_FoodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_FoodList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_FoodList.Name = "flowLayoutPanel_FoodList";
            this.flowLayoutPanel_FoodList.Size = new System.Drawing.Size(1350, 1033);
            this.flowLayoutPanel_FoodList.TabIndex = 0;
            // 
            // BookingFoodContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_FoodList);
            this.Name = "BookingFoodContainer";
            this.Size = new System.Drawing.Size(1350, 1033);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_FoodList;
    }
}
