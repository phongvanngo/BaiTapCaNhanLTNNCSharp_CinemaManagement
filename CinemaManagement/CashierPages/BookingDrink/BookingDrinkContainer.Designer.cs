namespace CinemaManagement.CashierPages.BookingDrink
{
    partial class BookingDrinkContainer
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
            this.flowLayoutPanel_DrinkList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_DrinkList
            // 
            this.flowLayoutPanel_DrinkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_DrinkList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_DrinkList.Name = "flowLayoutPanel_DrinkList";
            this.flowLayoutPanel_DrinkList.Size = new System.Drawing.Size(1350, 1033);
            this.flowLayoutPanel_DrinkList.TabIndex = 0;
            // 
            // BookingDrinkContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_DrinkList);
            this.Name = "BookingDrinkContainer";
            this.Size = new System.Drawing.Size(1350, 1033);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DrinkList;
    }
}
