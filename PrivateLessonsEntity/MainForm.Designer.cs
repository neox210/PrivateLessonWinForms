namespace PrivateLessonsEntity
{
    partial class MainForm
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
            this.l_TopInfo = new System.Windows.Forms.Label();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_StudentList = new System.Windows.Forms.PictureBox();
            this.pb_Schedule = new System.Windows.Forms.PictureBox();
            this.pb_DeleteStudent = new System.Windows.Forms.PictureBox();
            this.pb_AddStudent = new System.Windows.Forms.PictureBox();
            this.pb_DeleteHour = new System.Windows.Forms.PictureBox();
            this.pb_AddHour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DeleteStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DeleteHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddHour)).BeginInit();
            this.SuspendLayout();
            // 
            // l_TopInfo
            // 
            this.l_TopInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.l_TopInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_TopInfo.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_TopInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_TopInfo.Location = new System.Drawing.Point(0, 0);
            this.l_TopInfo.Name = "l_TopInfo";
            this.l_TopInfo.Size = new System.Drawing.Size(610, 75);
            this.l_TopInfo.TabIndex = 27;
            this.l_TopInfo.Text = "Kontrola Korepetytora";
            this.l_TopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pb_exit.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.exit;
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.InitialImage = null;
            this.pb_exit.Location = new System.Drawing.Point(571, 9);
            this.pb_exit.Margin = new System.Windows.Forms.Padding(0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 28;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // pb_StudentList
            // 
            this.pb_StudentList.Image = global::PrivateLessonsEntity.Properties.Resources.ListaUczniowButton;
            this.pb_StudentList.Location = new System.Drawing.Point(316, 335);
            this.pb_StudentList.Name = "pb_StudentList";
            this.pb_StudentList.Size = new System.Drawing.Size(240, 85);
            this.pb_StudentList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_StudentList.TabIndex = 24;
            this.pb_StudentList.TabStop = false;
            this.pb_StudentList.Click += new System.EventHandler(this.pb_StudentList_Click);
            this.pb_StudentList.MouseEnter += new System.EventHandler(this.pb_StudentList_MouseEnter);
            this.pb_StudentList.MouseLeave += new System.EventHandler(this.pb_StudentList_MouseLeave);
            // 
            // pb_Schedule
            // 
            this.pb_Schedule.Image = global::PrivateLessonsEntity.Properties.Resources.GrafikButton;
            this.pb_Schedule.Location = new System.Drawing.Point(46, 335);
            this.pb_Schedule.Name = "pb_Schedule";
            this.pb_Schedule.Size = new System.Drawing.Size(240, 85);
            this.pb_Schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Schedule.TabIndex = 23;
            this.pb_Schedule.TabStop = false;
            this.pb_Schedule.Click += new System.EventHandler(this.pb_Schedule_Click);
            this.pb_Schedule.MouseEnter += new System.EventHandler(this.pb_Schedule_MouseEnter);
            this.pb_Schedule.MouseLeave += new System.EventHandler(this.pb_Schedule_MouseLeave);
            // 
            // pb_DeleteStudent
            // 
            this.pb_DeleteStudent.Image = global::PrivateLessonsEntity.Properties.Resources.UsunUcznaButton;
            this.pb_DeleteStudent.Location = new System.Drawing.Point(316, 230);
            this.pb_DeleteStudent.Name = "pb_DeleteStudent";
            this.pb_DeleteStudent.Size = new System.Drawing.Size(240, 85);
            this.pb_DeleteStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_DeleteStudent.TabIndex = 22;
            this.pb_DeleteStudent.TabStop = false;
            this.pb_DeleteStudent.Click += new System.EventHandler(this.pb_DeleteStudent_Click);
            this.pb_DeleteStudent.MouseEnter += new System.EventHandler(this.pb_DeleteStudent_MouseEnter);
            this.pb_DeleteStudent.MouseLeave += new System.EventHandler(this.pb_DeleteStudent_MouseLeave);
            // 
            // pb_AddStudent
            // 
            this.pb_AddStudent.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.DodajUczniaButton;
            this.pb_AddStudent.Location = new System.Drawing.Point(316, 125);
            this.pb_AddStudent.Name = "pb_AddStudent";
            this.pb_AddStudent.Size = new System.Drawing.Size(240, 85);
            this.pb_AddStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_AddStudent.TabIndex = 21;
            this.pb_AddStudent.TabStop = false;
            this.pb_AddStudent.Click += new System.EventHandler(this.pb_AddStudent_Click);
            this.pb_AddStudent.MouseEnter += new System.EventHandler(this.pb_AddStudent_MouseEnter);
            this.pb_AddStudent.MouseLeave += new System.EventHandler(this.pb_AddStudent_MouseLeave);
            // 
            // pb_DeleteHour
            // 
            this.pb_DeleteHour.Image = global::PrivateLessonsEntity.Properties.Resources.UsunGodzineButton;
            this.pb_DeleteHour.Location = new System.Drawing.Point(46, 230);
            this.pb_DeleteHour.Name = "pb_DeleteHour";
            this.pb_DeleteHour.Size = new System.Drawing.Size(240, 85);
            this.pb_DeleteHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_DeleteHour.TabIndex = 20;
            this.pb_DeleteHour.TabStop = false;
            this.pb_DeleteHour.Click += new System.EventHandler(this.pb_DeleteHour_Click);
            this.pb_DeleteHour.MouseEnter += new System.EventHandler(this.pb_DeleteHour_MouseEnter);
            this.pb_DeleteHour.MouseLeave += new System.EventHandler(this.pb_DeleteHour_MouseLeave);
            // 
            // pb_AddHour
            // 
            this.pb_AddHour.Image = global::PrivateLessonsEntity.Properties.Resources.DodajGodzinęButton;
            this.pb_AddHour.Location = new System.Drawing.Point(46, 125);
            this.pb_AddHour.Name = "pb_AddHour";
            this.pb_AddHour.Size = new System.Drawing.Size(240, 85);
            this.pb_AddHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_AddHour.TabIndex = 19;
            this.pb_AddHour.TabStop = false;
            this.pb_AddHour.Click += new System.EventHandler(this.pb_AddHour_Click);
            this.pb_AddHour.MouseEnter += new System.EventHandler(this.pb_AddHour_MouseEnter);
            this.pb_AddHour.MouseLeave += new System.EventHandler(this.pb_AddHour_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 475);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.l_TopInfo);
            this.Controls.Add(this.pb_StudentList);
            this.Controls.Add(this.pb_Schedule);
            this.Controls.Add(this.pb_DeleteStudent);
            this.Controls.Add(this.pb_AddStudent);
            this.Controls.Add(this.pb_DeleteHour);
            this.Controls.Add(this.pb_AddHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DeleteStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DeleteHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label l_TopInfo;
        private System.Windows.Forms.PictureBox pb_StudentList;
        private System.Windows.Forms.PictureBox pb_Schedule;
        private System.Windows.Forms.PictureBox pb_DeleteStudent;
        private System.Windows.Forms.PictureBox pb_AddStudent;
        private System.Windows.Forms.PictureBox pb_DeleteHour;
        private System.Windows.Forms.PictureBox pb_AddHour;
    }
}

