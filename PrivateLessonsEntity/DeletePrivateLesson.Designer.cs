namespace PrivateLessonsEntity
{
    partial class DeletePrivateLesson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_SortDateOrder = new System.Windows.Forms.RadioButton();
            this.rb_SortOrderStudent = new System.Windows.Forms.RadioButton();
            this.cb_SelectStudent = new System.Windows.Forms.ComboBox();
            this.dtp_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.chb_ByDate = new System.Windows.Forms.CheckBox();
            this.chb_ByStudent = new System.Windows.Forms.CheckBox();
            this.b_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SelectedHours = new System.Windows.Forms.ListBox();
            this.l_PickStudents = new System.Windows.Forms.Label();
            this.lb_PickHours = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.DoubleArrowLeft = new System.Windows.Forms.PictureBox();
            this.DoubleArrowRight = new System.Windows.Forms.PictureBox();
            this.ArrowRught = new System.Windows.Forms.PictureBox();
            this.ArrowLeft = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
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
            this.l_TopInfo.TabIndex = 29;
            this.l_TopInfo.Text = "Usuń godzinę korepetycji";
            this.l_TopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_SortDateOrder);
            this.groupBox1.Controls.Add(this.rb_SortOrderStudent);
            this.groupBox1.Location = new System.Drawing.Point(25, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 86);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortuj po:";
            // 
            // rb_SortDateOrder
            // 
            this.rb_SortDateOrder.AutoSize = true;
            this.rb_SortDateOrder.Location = new System.Drawing.Point(18, 54);
            this.rb_SortDateOrder.Name = "rb_SortDateOrder";
            this.rb_SortDateOrder.Size = new System.Drawing.Size(53, 17);
            this.rb_SortDateOrder.TabIndex = 1;
            this.rb_SortDateOrder.TabStop = true;
            this.rb_SortDateOrder.Text = "Dacie";
            this.rb_SortDateOrder.UseVisualStyleBackColor = true;
            this.rb_SortDateOrder.CheckedChanged += new System.EventHandler(this.rb_SortDateOrder_CheckedChanged);
            // 
            // rb_SortOrderStudent
            // 
            this.rb_SortOrderStudent.AutoSize = true;
            this.rb_SortOrderStudent.Location = new System.Drawing.Point(18, 20);
            this.rb_SortOrderStudent.Name = "rb_SortOrderStudent";
            this.rb_SortOrderStudent.Size = new System.Drawing.Size(58, 17);
            this.rb_SortOrderStudent.TabIndex = 0;
            this.rb_SortOrderStudent.TabStop = true;
            this.rb_SortOrderStudent.Text = "Uczniu";
            this.rb_SortOrderStudent.UseVisualStyleBackColor = true;
            // 
            // cb_SelectStudent
            // 
            this.cb_SelectStudent.FormattingEnabled = true;
            this.cb_SelectStudent.Location = new System.Drawing.Point(158, 113);
            this.cb_SelectStudent.Name = "cb_SelectStudent";
            this.cb_SelectStudent.Size = new System.Drawing.Size(187, 21);
            this.cb_SelectStudent.TabIndex = 32;
            // 
            // dtp_SelectDate
            // 
            this.dtp_SelectDate.Enabled = false;
            this.dtp_SelectDate.Location = new System.Drawing.Point(158, 151);
            this.dtp_SelectDate.Name = "dtp_SelectDate";
            this.dtp_SelectDate.Size = new System.Drawing.Size(187, 20);
            this.dtp_SelectDate.TabIndex = 33;
            // 
            // chb_ByDate
            // 
            this.chb_ByDate.AutoSize = true;
            this.chb_ByDate.Location = new System.Drawing.Point(351, 117);
            this.chb_ByDate.Name = "chb_ByDate";
            this.chb_ByDate.Size = new System.Drawing.Size(139, 17);
            this.chb_ByDate.TabIndex = 34;
            this.chb_ByDate.Text = "Zajęcia wybranego dnia";
            this.chb_ByDate.UseVisualStyleBackColor = true;
            this.chb_ByDate.CheckedChanged += new System.EventHandler(this.chb_ByDate_CheckedChanged);
            // 
            // chb_ByStudent
            // 
            this.chb_ByStudent.AutoSize = true;
            this.chb_ByStudent.Enabled = false;
            this.chb_ByStudent.Location = new System.Drawing.Point(351, 151);
            this.chb_ByStudent.Name = "chb_ByStudent";
            this.chb_ByStudent.Size = new System.Drawing.Size(150, 17);
            this.chb_ByStudent.TabIndex = 35;
            this.chb_ByStudent.Text = "Zajęcia wybranego ucznia";
            this.chb_ByStudent.UseVisualStyleBackColor = true;
            this.chb_ByStudent.CheckedChanged += new System.EventHandler(this.chb_ByStudent_CheckedChanged);
            // 
            // b_Show
            // 
            this.b_Show.Location = new System.Drawing.Point(523, 117);
            this.b_Show.Name = "b_Show";
            this.b_Show.Size = new System.Drawing.Size(75, 51);
            this.b_Show.TabIndex = 36;
            this.b_Show.Text = "Pokaż korepetycje";
            this.b_Show.UseVisualStyleBackColor = true;
            this.b_Show.Click += new System.EventHandler(this.b_Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(348, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Korepetycje do usunięcia:";
            // 
            // lb_SelectedHours
            // 
            this.lb_SelectedHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_SelectedHours.FormattingEnabled = true;
            this.lb_SelectedHours.Location = new System.Drawing.Point(348, 240);
            this.lb_SelectedHours.Name = "lb_SelectedHours";
            this.lb_SelectedHours.Size = new System.Drawing.Size(250, 251);
            this.lb_SelectedHours.TabIndex = 55;
            // 
            // l_PickStudents
            // 
            this.l_PickStudents.AutoSize = true;
            this.l_PickStudents.BackColor = System.Drawing.Color.Transparent;
            this.l_PickStudents.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_PickStudents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_PickStudents.Location = new System.Drawing.Point(41, 205);
            this.l_PickStudents.Name = "l_PickStudents";
            this.l_PickStudents.Size = new System.Drawing.Size(221, 18);
            this.l_PickStudents.TabIndex = 54;
            this.l_PickStudents.Text = "Wybierz godzinę/godziny:";
            // 
            // lb_PickHours
            // 
            this.lb_PickHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_PickHours.FormattingEnabled = true;
            this.lb_PickHours.Location = new System.Drawing.Point(25, 240);
            this.lb_PickHours.Name = "lb_PickHours";
            this.lb_PickHours.Size = new System.Drawing.Size(250, 251);
            this.lb_PickHours.TabIndex = 53;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.save;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Location = new System.Drawing.Point(286, 513);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(50, 50);
            this.Submit.TabIndex = 61;
            this.Submit.UseMnemonic = false;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DoubleArrowLeft
            // 
            this.DoubleArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleArrowLeft.Image = global::PrivateLessonsEntity.Properties.Resources.Actions_arrow_left_double_icon_button;
            this.DoubleArrowLeft.Location = new System.Drawing.Point(296, 430);
            this.DoubleArrowLeft.Name = "DoubleArrowLeft";
            this.DoubleArrowLeft.Size = new System.Drawing.Size(30, 30);
            this.DoubleArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoubleArrowLeft.TabIndex = 59;
            this.DoubleArrowLeft.TabStop = false;
            this.DoubleArrowLeft.Click += new System.EventHandler(this.DoubleArrowLeft_Click);
            this.DoubleArrowLeft.MouseEnter += new System.EventHandler(this.DoubleArrowLeft_MouseEnter);
            this.DoubleArrowLeft.MouseLeave += new System.EventHandler(this.DoubleArrowLeft_MouseLeave);
            // 
            // DoubleArrowRight
            // 
            this.DoubleArrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleArrowRight.Image = global::PrivateLessonsEntity.Properties.Resources.Actions_arrow_right_double_icon_button;
            this.DoubleArrowRight.Location = new System.Drawing.Point(296, 380);
            this.DoubleArrowRight.Name = "DoubleArrowRight";
            this.DoubleArrowRight.Size = new System.Drawing.Size(30, 30);
            this.DoubleArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoubleArrowRight.TabIndex = 58;
            this.DoubleArrowRight.TabStop = false;
            this.DoubleArrowRight.Click += new System.EventHandler(this.DoubleArrowRight_Click);
            this.DoubleArrowRight.MouseEnter += new System.EventHandler(this.DoubleArrowRight_MouseEnter);
            this.DoubleArrowRight.MouseLeave += new System.EventHandler(this.DoubleArrowRight_MouseLeave);
            // 
            // ArrowRught
            // 
            this.ArrowRught.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArrowRught.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrowRught.Image = global::PrivateLessonsEntity.Properties.Resources.Actions_arrow_right_icon_button;
            this.ArrowRught.Location = new System.Drawing.Point(296, 259);
            this.ArrowRught.Name = "ArrowRught";
            this.ArrowRught.Size = new System.Drawing.Size(30, 30);
            this.ArrowRught.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowRught.TabIndex = 57;
            this.ArrowRught.TabStop = false;
            this.ArrowRught.Click += new System.EventHandler(this.ArrowRught_Click);
            this.ArrowRught.MouseEnter += new System.EventHandler(this.ArrowRught_MouseEnter);
            this.ArrowRught.MouseLeave += new System.EventHandler(this.ArrowRught_MouseLeave);
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrowLeft.Image = global::PrivateLessonsEntity.Properties.Resources.Actions_arrow_left_icon_button;
            this.ArrowLeft.Location = new System.Drawing.Point(296, 309);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(30, 30);
            this.ArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowLeft.TabIndex = 56;
            this.ArrowLeft.TabStop = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            this.ArrowLeft.MouseEnter += new System.EventHandler(this.ArrowLeft_MouseEnter);
            this.ArrowLeft.MouseLeave += new System.EventHandler(this.ArrowLeft_MouseLeave);
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
            this.pb_exit.TabIndex = 30;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // DeletePrivateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 575);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoubleArrowLeft);
            this.Controls.Add(this.DoubleArrowRight);
            this.Controls.Add(this.ArrowRught);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.lb_SelectedHours);
            this.Controls.Add(this.l_PickStudents);
            this.Controls.Add(this.lb_PickHours);
            this.Controls.Add(this.b_Show);
            this.Controls.Add(this.chb_ByStudent);
            this.Controls.Add(this.chb_ByDate);
            this.Controls.Add(this.dtp_SelectDate);
            this.Controls.Add(this.cb_SelectStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.l_TopInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePrivateLesson";
            this.Text = "DeletePrivateLesson";
            this.Load += new System.EventHandler(this.DeletePrivateLesson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label l_TopInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_SortDateOrder;
        private System.Windows.Forms.RadioButton rb_SortOrderStudent;
        private System.Windows.Forms.ComboBox cb_SelectStudent;
        private System.Windows.Forms.DateTimePicker dtp_SelectDate;
        private System.Windows.Forms.CheckBox chb_ByDate;
        private System.Windows.Forms.CheckBox chb_ByStudent;
        private System.Windows.Forms.Button b_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DoubleArrowLeft;
        private System.Windows.Forms.PictureBox DoubleArrowRight;
        private System.Windows.Forms.PictureBox ArrowRught;
        private System.Windows.Forms.PictureBox ArrowLeft;
        private System.Windows.Forms.ListBox lb_SelectedHours;
        private System.Windows.Forms.Label l_PickStudents;
        private System.Windows.Forms.ListBox lb_PickHours;
        private System.Windows.Forms.Button Submit;
    }
}