using PrivateLessonsEntity.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateLessonsEntity
{
    public partial class EditStudent : Form
    {
        int StudentId;
        public EditStudent(int studentId)
        {
            InitializeComponent();
            this.StudentId = studentId;
        }

        private void chb_EName_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EName.Checked == true)
            {
                tb_Name.Enabled = true;
            }
            else
            {
                tb_Name.Enabled = false;
            }
        }

        private void chb_ESurname_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ESurname.Checked == true)
            {
                tb_Surname.Enabled = true;
            }
            else
            {
                tb_Surname.Enabled = false;
            }
        }

        private void chb_EPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EPhone.Checked == true)
            {
                tb_PhoneNumber.Enabled = true;
            }
            else
            {
                tb_PhoneNumber.Enabled = false;
            }
        }

        private void chb_EAdress_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EAdress.Checked == true)
            {
                tb_City.Enabled = true;
                tb_Street.Enabled = true;
            }
            else
            {
                tb_City.Enabled = false;
                tb_Street.Enabled = false;
            }
        }

        private void ch_ELevel_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_ELevel.Checked == true)
            {
                cb_Level.Enabled = true;
            }
            else
            {
                cb_Level.Enabled = false;
            }
        }

        private void ch_EClass_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_EClass.Checked == true)
            {
                cb_Class.Enabled = true;
            }
            else
            {
                cb_Class.Enabled = false;
            }
        }

        private void ch_EComment_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_EComment.Checked == true)
            {
                tb_Comment.Enabled = true;
            }
            else
            {
                tb_Comment.Enabled = false;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (AddStudentValidation.ValidateStudentData(tb_Name, tb_Surname, tb_PhoneNumber, tb_City, tb_Street, cb_Level, cb_Class))
            {
                string message = "Czy wszystkie wprowadzone zmiany są poprawne?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var DB = new PrivateLessonsEntities())
                    {
                        var StudentToEdit = DB.Students.Single(s => s.Id == StudentId);
                        if (tb_Name.Enabled == true)
                        {
                            StudentToEdit.Name = tb_Name.Text;
                        }

                        if (tb_Surname.Enabled == true)
                        {
                            StudentToEdit.Surname = tb_Surname.Text;
                        }

                        if (tb_PhoneNumber.Enabled == true)
                        {
                            StudentToEdit.PhoneNumber = int.Parse(tb_PhoneNumber.Text);
                        }

                        if (tb_Street.Enabled == true && tb_City.Enabled == true)
                        {
                            StudentToEdit.Street = tb_Street.Text;
                            StudentToEdit.City = tb_Street.Text;
                        }
                        if (cb_Level.Enabled == true)
                        {
                            StudentToEdit.Level = cb_Level.Text;
                        }
                        if (cb_Class.Enabled == true)
                        {
                            StudentToEdit.SchoolClass = int.Parse(cb_Class.Text);
                        }
                        if (tb_Comment.Enabled == true)
                        {
                            StudentToEdit.Comment = tb_Comment.Text;
                        }

                        StudentToEdit.StudentDescription = StudentToEdit.Surname + " " + StudentToEdit.Name + " " + StudentToEdit.City;

                        DB.SaveChanges();
                    }

                    result = MessageBox.Show("Pomyślnie edytowano dane ucznia");
                }
            }
        }
    }
}
