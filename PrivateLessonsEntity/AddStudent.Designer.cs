namespace PrivateLessonsEntity
{
    partial class AddStudent
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
            this.tb_Street = new System.Windows.Forms.TextBox();
            this.l_Comment = new System.Windows.Forms.Label();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.l_Class = new System.Windows.Forms.Label();
            this.l_Level = new System.Windows.Forms.Label();
            this.l_Adress = new System.Windows.Forms.Label();
            this.l_PhoneNumber = new System.Windows.Forms.Label();
            this.l_Surname = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.l_TopInfo = new System.Windows.Forms.Label();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Street
            // 
            this.tb_Street.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Street.Location = new System.Drawing.Point(49, 472);
            this.tb_Street.Name = "tb_Street";
            this.tb_Street.Size = new System.Drawing.Size(150, 33);
            this.tb_Street.TabIndex = 53;
            this.tb_Street.Text = "Ulica ";
            // 
            // l_Comment
            // 
            this.l_Comment.AutoSize = true;
            this.l_Comment.BackColor = System.Drawing.Color.Transparent;
            this.l_Comment.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Comment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Comment.Location = new System.Drawing.Point(360, 284);
            this.l_Comment.Name = "l_Comment";
            this.l_Comment.Size = new System.Drawing.Size(137, 25);
            this.l_Comment.TabIndex = 51;
            this.l_Comment.Text = "Komentarz:";
            // 
            // tb_Comment
            // 
            this.tb_Comment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Comment.Location = new System.Drawing.Point(365, 324);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(173, 85);
            this.tb_Comment.TabIndex = 50;
            // 
            // cb_Class
            // 
            this.cb_Class.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(365, 224);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(121, 33);
            this.cb_Class.TabIndex = 48;
            this.cb_Class.Visible = false;
            // 
            // cb_Level
            // 
            this.cb_Level.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Items.AddRange(new object[] {
            "Podstawówka",
            "Gimnazjum",
            "Liceum",
            "Technikum",
            "Inne"});
            this.cb_Level.Location = new System.Drawing.Point(365, 124);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(173, 33);
            this.cb_Level.TabIndex = 47;
            this.cb_Level.SelectedValueChanged += new System.EventHandler(this.ClassSelect);
            // 
            // tb_City
            // 
            this.tb_City.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_City.Location = new System.Drawing.Point(49, 424);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(150, 33);
            this.tb_City.TabIndex = 46;
            this.tb_City.Text = "Miasto";
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_PhoneNumber.Location = new System.Drawing.Point(49, 324);
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.Size = new System.Drawing.Size(150, 33);
            this.tb_PhoneNumber.TabIndex = 45;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Surname.Location = new System.Drawing.Point(54, 224);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(150, 33);
            this.tb_Surname.TabIndex = 44;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Name.Location = new System.Drawing.Point(54, 124);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(150, 33);
            this.tb_Name.TabIndex = 43;
            // 
            // l_Class
            // 
            this.l_Class.AutoSize = true;
            this.l_Class.BackColor = System.Drawing.Color.Transparent;
            this.l_Class.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Class.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Class.Location = new System.Drawing.Point(360, 184);
            this.l_Class.Name = "l_Class";
            this.l_Class.Size = new System.Drawing.Size(77, 25);
            this.l_Class.TabIndex = 42;
            this.l_Class.Text = "klasa:";
            this.l_Class.Visible = false;
            // 
            // l_Level
            // 
            this.l_Level.AutoSize = true;
            this.l_Level.BackColor = System.Drawing.Color.Transparent;
            this.l_Level.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Level.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Level.Location = new System.Drawing.Point(360, 84);
            this.l_Level.Name = "l_Level";
            this.l_Level.Size = new System.Drawing.Size(98, 25);
            this.l_Level.TabIndex = 41;
            this.l_Level.Text = "Poziom:";
            // 
            // l_Adress
            // 
            this.l_Adress.AutoSize = true;
            this.l_Adress.BackColor = System.Drawing.Color.Transparent;
            this.l_Adress.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Adress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Adress.Location = new System.Drawing.Point(49, 384);
            this.l_Adress.Name = "l_Adress";
            this.l_Adress.Size = new System.Drawing.Size(82, 25);
            this.l_Adress.TabIndex = 40;
            this.l_Adress.Text = "Adres:";
            // 
            // l_PhoneNumber
            // 
            this.l_PhoneNumber.AutoSize = true;
            this.l_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.l_PhoneNumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_PhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_PhoneNumber.Location = new System.Drawing.Point(49, 284);
            this.l_PhoneNumber.Name = "l_PhoneNumber";
            this.l_PhoneNumber.Size = new System.Drawing.Size(100, 25);
            this.l_PhoneNumber.TabIndex = 39;
            this.l_PhoneNumber.Text = "Telefon:";
            // 
            // l_Surname
            // 
            this.l_Surname.AutoSize = true;
            this.l_Surname.BackColor = System.Drawing.Color.Transparent;
            this.l_Surname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Surname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Surname.Location = new System.Drawing.Point(49, 184);
            this.l_Surname.Name = "l_Surname";
            this.l_Surname.Size = new System.Drawing.Size(121, 25);
            this.l_Surname.TabIndex = 38;
            this.l_Surname.Text = "Nazwisko:";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.BackColor = System.Drawing.Color.Transparent;
            this.l_Name.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l_Name.Location = new System.Drawing.Point(49, 84);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(69, 25);
            this.l_Name.TabIndex = 37;
            this.l_Name.Text = "Imię:";
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
            this.l_TopInfo.TabIndex = 36;
            this.l_TopInfo.Text = "Dodaj Ucznia";
            this.l_TopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pb_exit.TabIndex = 52;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = global::PrivateLessonsEntity.Properties.Resources.save;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Location = new System.Drawing.Point(365, 442);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(80, 80);
            this.Submit.TabIndex = 49;
            this.Submit.UseMnemonic = false;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 537);
            this.Controls.Add(this.tb_Street);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.l_Comment);
            this.Controls.Add(this.tb_Comment);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.cb_Level);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.tb_PhoneNumber);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Class);
            this.Controls.Add(this.l_Level);
            this.Controls.Add(this.l_Adress);
            this.Controls.Add(this.l_PhoneNumber);
            this.Controls.Add(this.l_Surname);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_TopInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Street;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label l_Comment;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.ComboBox cb_Level;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_PhoneNumber;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label l_Class;
        private System.Windows.Forms.Label l_Level;
        private System.Windows.Forms.Label l_Adress;
        private System.Windows.Forms.Label l_PhoneNumber;
        private System.Windows.Forms.Label l_Surname;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_TopInfo;
    }
}