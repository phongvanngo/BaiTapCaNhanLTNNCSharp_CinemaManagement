namespace CinemaManagement.Admin.ManagementPages
{
    partial class ShowTimeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.dateTimePicker_TimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_NameOfTheater = new System.Windows.Forms.ComboBox();
            this.comboBox_NameOfMovie = new System.Windows.Forms.ComboBox();
            this.button_AddNewShowTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Table_ShowTimeList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheaterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ShowTimeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.dateTimePicker_TimeStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_Date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_NameOfTheater);
            this.groupBox1.Controls.Add(this.comboBox_NameOfMovie);
            this.groupBox1.Controls.Add(this.button_AddNewShowTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 371);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Update.Location = new System.Drawing.Point(911, 328);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(161, 35);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_TimeStart
            // 
            this.dateTimePicker_TimeStart.CustomFormat = "HH:mm";
            this.dateTimePicker_TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_TimeStart.Location = new System.Drawing.Point(256, 241);
            this.dateTimePicker_TimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_TimeStart.Name = "dateTimePicker_TimeStart";
            this.dateTimePicker_TimeStart.ShowUpDown = true;
            this.dateTimePicker_TimeStart.Size = new System.Drawing.Size(201, 30);
            this.dateTimePicker_TimeStart.TabIndex = 13;
            this.dateTimePicker_TimeStart.Value = new System.DateTime(2020, 11, 6, 16, 4, 33, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(251, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giờ chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(34, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày chiếu";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(32, 241);
            this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(201, 30);
            this.dateTimePicker_Date.TabIndex = 8;
            this.dateTimePicker_Date.Value = new System.DateTime(2020, 11, 6, 16, 4, 33, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(415, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý suất chiếu";
            // 
            // comboBox_NameOfTheater
            // 
            this.comboBox_NameOfTheater.FormattingEnabled = true;
            this.comboBox_NameOfTheater.Location = new System.Drawing.Point(32, 165);
            this.comboBox_NameOfTheater.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_NameOfTheater.Name = "comboBox_NameOfTheater";
            this.comboBox_NameOfTheater.Size = new System.Drawing.Size(597, 33);
            this.comboBox_NameOfTheater.TabIndex = 7;
            // 
            // comboBox_NameOfMovie
            // 
            this.comboBox_NameOfMovie.FormattingEnabled = true;
            this.comboBox_NameOfMovie.Location = new System.Drawing.Point(32, 93);
            this.comboBox_NameOfMovie.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_NameOfMovie.Name = "comboBox_NameOfMovie";
            this.comboBox_NameOfMovie.Size = new System.Drawing.Size(597, 33);
            this.comboBox_NameOfMovie.TabIndex = 6;
            // 
            // button_AddNewShowTime
            // 
            this.button_AddNewShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddNewShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewShowTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_AddNewShowTime.Location = new System.Drawing.Point(742, 328);
            this.button_AddNewShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddNewShowTime.Name = "button_AddNewShowTime";
            this.button_AddNewShowTime.Size = new System.Drawing.Size(161, 35);
            this.button_AddNewShowTime.TabIndex = 5;
            this.button_AddNewShowTime.Text = "Thêm mới";
            this.button_AddNewShowTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên rạp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Table_ShowTimeList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1080, 353);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phim";
            // 
            // Table_ShowTimeList
            // 
            this.Table_ShowTimeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table_ShowTimeList.BackgroundColor = System.Drawing.Color.White;
            this.Table_ShowTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_ShowTimeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MovieName,
            this.TheaterName,
            this.Time,
            this.Seat});
            this.Table_ShowTimeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_ShowTimeList.Location = new System.Drawing.Point(4, 27);
            this.Table_ShowTimeList.Margin = new System.Windows.Forms.Padding(4);
            this.Table_ShowTimeList.Name = "Table_ShowTimeList";
            this.Table_ShowTimeList.ReadOnly = true;
            this.Table_ShowTimeList.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Table_ShowTimeList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table_ShowTimeList.RowTemplate.Height = 24;
            this.Table_ShowTimeList.Size = new System.Drawing.Size(1072, 322);
            this.Table_ShowTimeList.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Mã suất chiếu";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MovieName
            // 
            this.MovieName.FillWeight = 30F;
            this.MovieName.HeaderText = "Tên phim";
            this.MovieName.MinimumWidth = 6;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // TheaterName
            // 
            this.TheaterName.FillWeight = 20F;
            this.TheaterName.HeaderText = "Tên Rạp";
            this.TheaterName.MinimumWidth = 6;
            this.TheaterName.Name = "TheaterName";
            this.TheaterName.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 25F;
            this.Time.HeaderText = "Thời gian chiếu";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Seat
            // 
            this.Seat.FillWeight = 15F;
            this.Seat.HeaderText = "Số chỗ ngồi còn lại";
            this.Seat.MinimumWidth = 6;
            this.Seat.Name = "Seat";
            this.Seat.ReadOnly = true;
            // 
            // ShowTimeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShowTimeManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_ShowTimeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_AddNewShowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Table_ShowTimeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox comboBox_NameOfTheater;
        private System.Windows.Forms.ComboBox comboBox_NameOfMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheaterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Update;
    }
}
