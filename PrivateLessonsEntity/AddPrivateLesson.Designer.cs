namespace PrivateLessonsEntity
{
    partial class AddPrivateLesson
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
            this.label8 = new System.Windows.Forms.Label();
            this.rb_StudentHome = new System.Windows.Forms.RadioButton();
            this.rb_Home = new System.Windows.Forms.RadioButton();
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
            this.label1 = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.l_TopInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Math = new System.Windows.Forms.RadioButton();
            this.rb_OtherTopic = new System.Windows.Forms.RadioButton();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(96, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = ":";
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
            // tb_Comment
            // 
            this.tb_Comment.Location = new System.Drawing.Point(365, 293);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(200, 92);
            this.tb_Comment.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(360, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Komentarz:";
            // 
            // tb_Topic
            // 
            this.tb_Topic.Location = new System.Drawing.Point(365, 216);
            this.tb_Topic.Name = "tb_Topic";
            this.tb_Topic.Size = new System.Drawing.Size(200, 20);
            this.tb_Topic.TabIndex = 55;
            // 
            // cb_Duration
            // 
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
            this.cb_Duration.Location = new System.Drawing.Point(50, 292);
            this.cb_Duration.Name = "cb_Duration";
            this.cb_Duration.Size = new System.Drawing.Size(55, 21);
            this.cb_Duration.TabIndex = 54;
            // 
            // cb_StartMin
            // 
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
            this.cb_StartMin.Location = new System.Drawing.Point(124, 216);
            this.cb_StartMin.Name = "cb_StartMin";
            this.cb_StartMin.Size = new System.Drawing.Size(37, 21);
            this.cb_StartMin.TabIndex = 53;
            // 
            // cb_startDateHour
            // 
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
            this.cb_startDateHour.Location = new System.Drawing.Point(50, 216);
            this.cb_startDateHour.Name = "cb_startDateHour";
            this.cb_startDateHour.Size = new System.Drawing.Size(40, 21);
            this.cb_startDateHour.TabIndex = 52;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(365, 128);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 51;
            // 
            // cb_UsersList
            // 
            this.cb_UsersList.FormattingEnabled = true;
            this.cb_UsersList.Location = new System.Drawing.Point(50, 128);
            this.cb_UsersList.Name = "cb_UsersList";
            this.cb_UsersList.Size = new System.Drawing.Size(182, 21);
            this.cb_UsersList.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(360, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Temat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(45, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Czas trwania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(45, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Godzina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(360, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data:";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.BackColor = System.Drawing.Color.Transparent;
            this.l_Name.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Name.Location = new System.Drawing.Point(45, 99);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(85, 25);
            this.l_Name.TabIndex = 44;
            this.l_Name.Text = "Uczeń:";
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
            this.l_TopInfo.TabIndex = 43;
            this.l_TopInfo.Text = "Dodaj Godzinę Korepetycji";
            this.l_TopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Home);
            this.groupBox1.Controls.Add(this.rb_StudentHome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(50, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 69);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miejsce Korepetycji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Math);
            this.groupBox2.Controls.Add(this.rb_OtherTopic);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(50, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 69);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przedmiot";
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
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(54, 530);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(233, 20);
            this.tb_Subject.TabIndex = 69;
            this.tb_Subject.Visible = false;
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.Transparent;
            this.b_save.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.save;
            this.b_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Location = new System.Drawing.Point(417, 421);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(80, 80);
            this.b_save.TabIndex = 66;
            this.b_save.UseMnemonic = false;
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.Image = global::PrivateLessonsEntity.Properties.Resources.exit;
            this.pb_exit.InitialImage = null;
            this.pb_exit.Location = new System.Drawing.Point(571, 9);
            this.pb_exit.Margin = new System.Windows.Forms.Padding(0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 62;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // AddPrivateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 575);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.pb_exit);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_TopInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPrivateLesson";
            this.Text = "AddPrivateLesson";
            this.Load += new System.EventHandler(this.AddPrivateLesson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_StudentHome;
        private System.Windows.Forms.RadioButton rb_Home;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_TopInfo;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Math;
        private System.Windows.Forms.RadioButton rb_OtherTopic;
        private System.Windows.Forms.TextBox tb_Subject;
    }
}