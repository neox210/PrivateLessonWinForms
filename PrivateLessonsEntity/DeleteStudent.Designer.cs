namespace PrivateLessonsEntity
{
    partial class DeleteStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SelectedStudents = new System.Windows.Forms.ListBox();
            this.l_PickStudents = new System.Windows.Forms.Label();
            this.lb_PickStudents = new System.Windows.Forms.ListBox();
            this.l_TopInfo = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.DoubleArrowLeft = new System.Windows.Forms.PictureBox();
            this.DoubleArrowRight = new System.Windows.Forms.PictureBox();
            this.ArrowRught = new System.Windows.Forms.PictureBox();
            this.ArrowLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(353, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Usuń:";
            // 
            // lb_SelectedStudents
            // 
            this.lb_SelectedStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_SelectedStudents.FormattingEnabled = true;
            this.lb_SelectedStudents.Location = new System.Drawing.Point(356, 143);
            this.lb_SelectedStudents.Name = "lb_SelectedStudents";
            this.lb_SelectedStudents.Size = new System.Drawing.Size(200, 251);
            this.lb_SelectedStudents.TabIndex = 47;
            // 
            // l_PickStudents
            // 
            this.l_PickStudents.AutoSize = true;
            this.l_PickStudents.BackColor = System.Drawing.Color.Transparent;
            this.l_PickStudents.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_PickStudents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_PickStudents.Location = new System.Drawing.Point(46, 108);
            this.l_PickStudents.Name = "l_PickStudents";
            this.l_PickStudents.Size = new System.Drawing.Size(211, 18);
            this.l_PickStudents.TabIndex = 46;
            this.l_PickStudents.Text = "Wybierz ucznia/uczniów:";
            // 
            // lb_PickStudents
            // 
            this.lb_PickStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_PickStudents.FormattingEnabled = true;
            this.lb_PickStudents.Location = new System.Drawing.Point(46, 143);
            this.lb_PickStudents.Name = "lb_PickStudents";
            this.lb_PickStudents.Size = new System.Drawing.Size(200, 251);
            this.lb_PickStudents.TabIndex = 45;
            // 
            // l_TopInfo
            // 
            this.l_TopInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.l_TopInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_TopInfo.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_TopInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_TopInfo.Location = new System.Drawing.Point(0, 0);
            this.l_TopInfo.Name = "l_TopInfo";
            this.l_TopInfo.Size = new System.Drawing.Size(594, 75);
            this.l_TopInfo.TabIndex = 44;
            this.l_TopInfo.Text = "Usuń Ucznia";
            this.l_TopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.save;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Location = new System.Drawing.Point(257, 429);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(80, 80);
            this.Submit.TabIndex = 54;
            this.Submit.UseMnemonic = false;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pb_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.Image = global::PrivateLessonsEntity.Properties.Resources.exit;
            this.pb_exit.InitialImage = null;
            this.pb_exit.Location = new System.Drawing.Point(555, 9);
            this.pb_exit.Margin = new System.Windows.Forms.Padding(0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 53;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // DoubleArrowLeft
            // 
            this.DoubleArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleArrowLeft.Image = global::PrivateLessonsEntity.Properties.Resources.Actions_arrow_left_double_icon_button;
            this.DoubleArrowLeft.Location = new System.Drawing.Point(286, 339);
            this.DoubleArrowLeft.Name = "DoubleArrowLeft";
            this.DoubleArrowLeft.Size = new System.Drawing.Size(30, 30);
            this.DoubleArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoubleArrowLeft.TabIndex = 51;
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
            this.DoubleArrowRight.Location = new System.Drawing.Point(286, 289);
            this.DoubleArrowRight.Name = "DoubleArrowRight";
            this.DoubleArrowRight.Size = new System.Drawing.Size(30, 30);
            this.DoubleArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoubleArrowRight.TabIndex = 50;
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
            this.ArrowRught.Location = new System.Drawing.Point(286, 168);
            this.ArrowRught.Name = "ArrowRught";
            this.ArrowRught.Size = new System.Drawing.Size(30, 30);
            this.ArrowRught.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowRught.TabIndex = 49;
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
            this.ArrowLeft.Location = new System.Drawing.Point(286, 218);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(30, 30);
            this.ArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowLeft.TabIndex = 48;
            this.ArrowLeft.TabStop = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            this.ArrowLeft.MouseEnter += new System.EventHandler(this.ArrowLeft_MouseEnter);
            this.ArrowLeft.MouseLeave += new System.EventHandler(this.ArrowLeft_MouseLeave);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 537);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoubleArrowLeft);
            this.Controls.Add(this.DoubleArrowRight);
            this.Controls.Add(this.ArrowRught);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.lb_SelectedStudents);
            this.Controls.Add(this.l_PickStudents);
            this.Controls.Add(this.lb_PickStudents);
            this.Controls.Add(this.l_TopInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DoubleArrowLeft;
        private System.Windows.Forms.PictureBox DoubleArrowRight;
        private System.Windows.Forms.PictureBox ArrowRught;
        private System.Windows.Forms.PictureBox ArrowLeft;
        private System.Windows.Forms.ListBox lb_SelectedStudents;
        private System.Windows.Forms.Label l_PickStudents;
        private System.Windows.Forms.ListBox lb_PickStudents;
        private System.Windows.Forms.Label l_TopInfo;
        private System.Windows.Forms.Button Submit;
    }
}