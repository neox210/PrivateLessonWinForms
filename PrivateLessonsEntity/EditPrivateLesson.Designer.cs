namespace PrivateLessonsEntity
{
    partial class EditPrivateLesson
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
            this.gb_Subject = new System.Windows.Forms.GroupBox();
            this.rb_Math = new System.Windows.Forms.RadioButton();
            this.rb_OtherTopic = new System.Windows.Forms.RadioButton();
            this.gb_Place = new System.Windows.Forms.GroupBox();
            this.rb_Home = new System.Windows.Forms.RadioButton();
            this.rb_StudentHome = new System.Windows.Forms.RadioButton();
            this.b_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Topic = new System.Windows.Forms.TextBox();
            this.cb_Duration = new System.Windows.Forms.ComboBox();
            this.cb_StartMin = new System.Windows.Forms.ComboBox();
            this.cb_startDateHour = new System.Windows.Forms.ComboBox();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.cb_UsersList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Data = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.gb_EditList = new System.Windows.Forms.GroupBox();
            this.chb_EStudent = new System.Windows.Forms.CheckBox();
            this.chb_EStartHour = new System.Windows.Forms.CheckBox();
            this.chb_EDuration = new System.Windows.Forms.CheckBox();
            this.ch_EComment = new System.Windows.Forms.CheckBox();
            this.chb_EIsHome = new System.Windows.Forms.CheckBox();
            this.ch_ESubject = new System.Windows.Forms.CheckBox();
            this.ch_EDate = new System.Windows.Forms.CheckBox();
            this.ch_ETopic = new System.Windows.Forms.CheckBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.gb_Subject.SuspendLayout();
            this.gb_Place.SuspendLayout();
            this.gb_EditList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Subject
            // 
            this.gb_Subject.Controls.Add(this.rb_Math);
            this.gb_Subject.Controls.Add(this.rb_OtherTopic);
            this.gb_Subject.Enabled = false;
            this.gb_Subject.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb_Subject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_Subject.Location = new System.Drawing.Point(251, 343);
            this.gb_Subject.Name = "gb_Subject";
            this.gb_Subject.Size = new System.Drawing.Size(237, 69);
            this.gb_Subject.TabIndex = 85;
            this.gb_Subject.TabStop = false;
            this.gb_Subject.Text = "Przedmiot";
            // 
            // rb_Math
            // 
            this.rb_Math.AutoSize = true;
            this.rb_Math.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_Math.Location = new System.Drawing.Point(4, 32);
            this.rb_Math.Name = "rb_Math";
            this.rb_Math.Size = new System.Drawing.Size(126, 22);
            this.rb_Math.TabIndex = 59;
            this.rb_Math.TabStop = true;
            this.rb_Math.Text = "Matematyka";
            this.rb_Math.UseVisualStyleBackColor = true;
            // 
            // rb_OtherTopic
            // 
            this.rb_OtherTopic.AutoSize = true;
            this.rb_OtherTopic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_OtherTopic.Location = new System.Drawing.Point(136, 32);
            this.rb_OtherTopic.Name = "rb_OtherTopic";
            this.rb_OtherTopic.Size = new System.Drawing.Size(62, 22);
            this.rb_OtherTopic.TabIndex = 60;
            this.rb_OtherTopic.TabStop = true;
            this.rb_OtherTopic.Text = "Inny";
            this.rb_OtherTopic.UseVisualStyleBackColor = true;
            this.rb_OtherTopic.CheckedChanged += new System.EventHandler(this.rb_OtherTopic_CheckedChanged);
            // 
            // gb_Place
            // 
            this.gb_Place.Controls.Add(this.rb_Home);
            this.gb_Place.Controls.Add(this.rb_StudentHome);
            this.gb_Place.Enabled = false;
            this.gb_Place.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb_Place.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_Place.Location = new System.Drawing.Point(247, 253);
            this.gb_Place.Name = "gb_Place";
            this.gb_Place.Size = new System.Drawing.Size(237, 69);
            this.gb_Place.TabIndex = 84;
            this.gb_Place.TabStop = false;
            this.gb_Place.Text = "Miejsce Korepetycji";
            // 
            // rb_Home
            // 
            this.rb_Home.AutoSize = true;
            this.rb_Home.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_Home.Location = new System.Drawing.Point(4, 32);
            this.rb_Home.Name = "rb_Home";
            this.rb_Home.Size = new System.Drawing.Size(63, 22);
            this.rb_Home.TabIndex = 59;
            this.rb_Home.TabStop = true;
            this.rb_Home.Text = "Dom";
            this.rb_Home.UseVisualStyleBackColor = true;
            // 
            // rb_StudentHome
            // 
            this.rb_StudentHome.AutoSize = true;
            this.rb_StudentHome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_StudentHome.Location = new System.Drawing.Point(95, 32);
            this.rb_StudentHome.Name = "rb_StudentHome";
            this.rb_StudentHome.Size = new System.Drawing.Size(96, 22);
            this.rb_StudentHome.TabIndex = 60;
            this.rb_StudentHome.TabStop = true;
            this.rb_StudentHome.Text = "U ucznia";
            this.rb_StudentHome.UseVisualStyleBackColor = true;
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.Transparent;
            this.b_save.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.save;
            this.b_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Location = new System.Drawing.Point(618, 343);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(80, 80);
            this.b_save.TabIndex = 83;
            this.b_save.UseMnemonic = false;
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(297, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 82;
            this.label8.Text = ":";
            // 
            // tb_Comment
            // 
            this.tb_Comment.Enabled = false;
            this.tb_Comment.Location = new System.Drawing.Point(566, 215);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(200, 92);
            this.tb_Comment.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(561, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Komentarz:";
            // 
            // tb_Topic
            // 
            this.tb_Topic.Enabled = false;
            this.tb_Topic.Location = new System.Drawing.Point(566, 138);
            this.tb_Topic.Name = "tb_Topic";
            this.tb_Topic.Size = new System.Drawing.Size(200, 20);
            this.tb_Topic.TabIndex = 79;
            // 
            // cb_Duration
            // 
            this.cb_Duration.Enabled = false;
            this.cb_Duration.FormattingEnabled = true;
            this.cb_Duration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "150",
            "180"});
            this.cb_Duration.Location = new System.Drawing.Point(251, 214);
            this.cb_Duration.Name = "cb_Duration";
            this.cb_Duration.Size = new System.Drawing.Size(55, 21);
            this.cb_Duration.TabIndex = 78;
            // 
            // cb_StartMin
            // 
            this.cb_StartMin.Enabled = false;
            this.cb_StartMin.FormattingEnabled = true;
            this.cb_StartMin.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cb_StartMin.Location = new System.Drawing.Point(325, 138);
            this.cb_StartMin.Name = "cb_StartMin";
            this.cb_StartMin.Size = new System.Drawing.Size(37, 21);
            this.cb_StartMin.TabIndex = 77;
            // 
            // cb_startDateHour
            // 
            this.cb_startDateHour.Enabled = false;
            this.cb_startDateHour.FormattingEnabled = true;
            this.cb_startDateHour.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cb_startDateHour.Location = new System.Drawing.Point(251, 138);
            this.cb_startDateHour.Name = "cb_startDateHour";
            this.cb_startDateHour.Size = new System.Drawing.Size(40, 21);
            this.cb_startDateHour.TabIndex = 76;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Enabled = false;
            this.dtp_StartDate.Location = new System.Drawing.Point(566, 50);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 75;
            // 
            // cb_UsersList
            // 
            this.cb_UsersList.Enabled = false;
            this.cb_UsersList.FormattingEnabled = true;
            this.cb_UsersList.Location = new System.Drawing.Point(251, 50);
            this.cb_UsersList.Name = "cb_UsersList";
            this.cb_UsersList.Size = new System.Drawing.Size(182, 21);
            this.cb_UsersList.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(561, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Temat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(246, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Czas trwania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(246, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Godzina";
            // 
            // l_Data
            // 
            this.l_Data.AutoSize = true;
            this.l_Data.BackColor = System.Drawing.Color.Transparent;
            this.l_Data.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Data.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Data.Location = new System.Drawing.Point(561, 21);
            this.l_Data.Name = "l_Data";
            this.l_Data.Size = new System.Drawing.Size(72, 25);
            this.l_Data.TabIndex = 70;
            this.l_Data.Text = "Data:";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.BackColor = System.Drawing.Color.Transparent;
            this.l_Name.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Name.Location = new System.Drawing.Point(246, 21);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(85, 25);
            this.l_Name.TabIndex = 69;
            this.l_Name.Text = "Uczeń:";
            // 
            // gb_EditList
            // 
            this.gb_EditList.Controls.Add(this.ch_ETopic);
            this.gb_EditList.Controls.Add(this.ch_EDate);
            this.gb_EditList.Controls.Add(this.ch_ESubject);
            this.gb_EditList.Controls.Add(this.chb_EIsHome);
            this.gb_EditList.Controls.Add(this.ch_EComment);
            this.gb_EditList.Controls.Add(this.chb_EDuration);
            this.gb_EditList.Controls.Add(this.chb_EStartHour);
            this.gb_EditList.Controls.Add(this.chb_EStudent);
            this.gb_EditList.Location = new System.Drawing.Point(13, 21);
            this.gb_EditList.Name = "gb_EditList";
            this.gb_EditList.Size = new System.Drawing.Size(177, 214);
            this.gb_EditList.TabIndex = 86;
            this.gb_EditList.TabStop = false;
            this.gb_EditList.Text = "Wybierz parametry do edycji:";
            // 
            // chb_EStudent
            // 
            this.chb_EStudent.AutoSize = true;
            this.chb_EStudent.Location = new System.Drawing.Point(7, 20);
            this.chb_EStudent.Name = "chb_EStudent";
            this.chb_EStudent.Size = new System.Drawing.Size(89, 17);
            this.chb_EStudent.TabIndex = 0;
            this.chb_EStudent.Text = "Zmień ucznia";
            this.chb_EStudent.UseVisualStyleBackColor = true;
            this.chb_EStudent.CheckedChanged += new System.EventHandler(this.chb_EStudent_CheckedChanged);
            // 
            // chb_EStartHour
            // 
            this.chb_EStartHour.AutoSize = true;
            this.chb_EStartHour.Location = new System.Drawing.Point(7, 43);
            this.chb_EStartHour.Name = "chb_EStartHour";
            this.chb_EStartHour.Size = new System.Drawing.Size(155, 17);
            this.chb_EStartHour.TabIndex = 1;
            this.chb_EStartHour.Text = "Zmień godzinę rozpoczęcia";
            this.chb_EStartHour.UseVisualStyleBackColor = true;
            this.chb_EStartHour.CheckedChanged += new System.EventHandler(this.chb_EStartHour_CheckedChanged);
            // 
            // chb_EDuration
            // 
            this.chb_EDuration.AutoSize = true;
            this.chb_EDuration.Location = new System.Drawing.Point(7, 66);
            this.chb_EDuration.Name = "chb_EDuration";
            this.chb_EDuration.Size = new System.Drawing.Size(117, 17);
            this.chb_EDuration.TabIndex = 2;
            this.chb_EDuration.Text = "Zmień czas trwania";
            this.chb_EDuration.UseVisualStyleBackColor = true;
            this.chb_EDuration.CheckedChanged += new System.EventHandler(this.chb_EDuration_CheckedChanged);
            // 
            // ch_EComment
            // 
            this.ch_EComment.AutoSize = true;
            this.ch_EComment.Location = new System.Drawing.Point(7, 181);
            this.ch_EComment.Name = "ch_EComment";
            this.ch_EComment.Size = new System.Drawing.Size(107, 17);
            this.ch_EComment.TabIndex = 3;
            this.ch_EComment.Text = "Zmień komentarz";
            this.ch_EComment.UseVisualStyleBackColor = true;
            this.ch_EComment.CheckedChanged += new System.EventHandler(this.ch_EComment_CheckedChanged);
            // 
            // chb_EIsHome
            // 
            this.chb_EIsHome.AutoSize = true;
            this.chb_EIsHome.Location = new System.Drawing.Point(7, 89);
            this.chb_EIsHome.Name = "chb_EIsHome";
            this.chb_EIsHome.Size = new System.Drawing.Size(147, 17);
            this.chb_EIsHome.TabIndex = 4;
            this.chb_EIsHome.Text = "Zmień miejsce korepetycji";
            this.chb_EIsHome.UseVisualStyleBackColor = true;
            this.chb_EIsHome.CheckedChanged += new System.EventHandler(this.chb_EIsHome_CheckedChanged);
            // 
            // ch_ESubject
            // 
            this.ch_ESubject.AutoSize = true;
            this.ch_ESubject.Location = new System.Drawing.Point(7, 112);
            this.ch_ESubject.Name = "ch_ESubject";
            this.ch_ESubject.Size = new System.Drawing.Size(131, 17);
            this.ch_ESubject.TabIndex = 5;
            this.ch_ESubject.Text = "Zmień przedmiot zajęć";
            this.ch_ESubject.UseVisualStyleBackColor = true;
            this.ch_ESubject.CheckedChanged += new System.EventHandler(this.ch_ESubject_CheckedChanged);
            // 
            // ch_EDate
            // 
            this.ch_EDate.AutoSize = true;
            this.ch_EDate.Location = new System.Drawing.Point(7, 135);
            this.ch_EDate.Name = "ch_EDate";
            this.ch_EDate.Size = new System.Drawing.Size(79, 17);
            this.ch_EDate.TabIndex = 6;
            this.ch_EDate.Text = "Zmień datę";
            this.ch_EDate.UseVisualStyleBackColor = true;
            this.ch_EDate.CheckedChanged += new System.EventHandler(this.ch_EDate_CheckedChanged);
            // 
            // ch_ETopic
            // 
            this.ch_ETopic.AutoSize = true;
            this.ch_ETopic.Location = new System.Drawing.Point(7, 158);
            this.ch_ETopic.Name = "ch_ETopic";
            this.ch_ETopic.Size = new System.Drawing.Size(112, 17);
            this.ch_ETopic.TabIndex = 7;
            this.ch_ETopic.Text = "Zmień temat zajęć";
            this.ch_ETopic.UseVisualStyleBackColor = true;
            this.ch_ETopic.CheckedChanged += new System.EventHandler(this.ch_ETopic_CheckedChanged);
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(251, 418);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(233, 20);
            this.tb_Subject.TabIndex = 87;
            this.tb_Subject.Visible = false;
            // 
            // EditPrivateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.gb_EditList);
            this.Controls.Add(this.gb_Subject);
            this.Controls.Add(this.gb_Place);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Comment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Topic);
            this.Controls.Add(this.cb_Duration);
            this.Controls.Add(this.cb_StartMin);
            this.Controls.Add(this.cb_startDateHour);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.cb_UsersList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_Data);
            this.Controls.Add(this.l_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPrivateLesson";
            this.Text = "EditPrivateLesson";
            this.Load += new System.EventHandler(this.EditPrivateLesson_Load);
            this.gb_Subject.ResumeLayout(false);
            this.gb_Subject.PerformLayout();
            this.gb_Place.ResumeLayout(false);
            this.gb_Place.PerformLayout();
            this.gb_EditList.ResumeLayout(false);
            this.gb_EditList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Subject;
        private System.Windows.Forms.RadioButton rb_Math;
        private System.Windows.Forms.RadioButton rb_OtherTopic;
        private System.Windows.Forms.GroupBox gb_Place;
        private System.Windows.Forms.RadioButton rb_Home;
        private System.Windows.Forms.RadioButton rb_StudentHome;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Topic;
        private System.Windows.Forms.ComboBox cb_Duration;
        private System.Windows.Forms.ComboBox cb_StartMin;
        private System.Windows.Forms.ComboBox cb_startDateHour;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.ComboBox cb_UsersList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_Data;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.GroupBox gb_EditList;
        private System.Windows.Forms.CheckBox ch_ETopic;
        private System.Windows.Forms.CheckBox ch_EDate;
        private System.Windows.Forms.CheckBox ch_ESubject;
        private System.Windows.Forms.CheckBox chb_EIsHome;
        private System.Windows.Forms.CheckBox chb_EDuration;
        private System.Windows.Forms.CheckBox chb_EStartHour;
        private System.Windows.Forms.CheckBox chb_EStudent;
        private System.Windows.Forms.CheckBox ch_EComment;
        private System.Windows.Forms.TextBox tb_Subject;
    }
}