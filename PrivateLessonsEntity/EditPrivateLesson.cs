using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateLessonsEntity
{
    public partial class EditPrivateLesson : Form
    {
        PrivateLessonHour LessonToEdit;

        public EditPrivateLesson(int id)
        {
            InitializeComponent();
            LoadPrivateLesson(id);
        }

        private void LoadPrivateLesson(int id)
        {
            using (var DB = new PrivateLessonsEntities())
            {
                LessonToEdit = DB.PrivateLessonHour.Single(h => h.Id == id);
            }
        }

        private void chb_EStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EStudent.Checked == true)
            {
                cb_UsersList.Enabled = true;
            }
            else
            {
                cb_UsersList.Enabled = false;
            }
        }

        private void chb_EStartHour_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EStartHour.Checked == true)
            {
                cb_StartMin.Enabled = true;
                cb_startDateHour.Enabled = true;
            }
            else
            {
                cb_StartMin.Enabled = false;
                cb_startDateHour.Enabled = false;
            }
        }

        private void chb_EDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EDuration.Checked == true)
            {
                cb_Duration.Enabled = true;
            }
            else
            {
                cb_Duration.Enabled = false;
            }
        }

        private void chb_EIsHome_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EIsHome.Checked == true)
            {
                gb_Place.Enabled = true;
            }
            else
            {
                gb_Place.Enabled = false;
            }
        }

        private void ch_ESubject_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_ESubject.Checked == true)
            {
                gb_Subject.Enabled = true;
            }
            else
            {
                gb_Subject.Enabled = false;
            }
        }

        private void ch_EDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_EDate.Checked == true)
            {
                dtp_StartDate.Enabled = true;
            }
            else
            {
                dtp_StartDate.Enabled = false;
            }
        }

        private void ch_ETopic_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_ETopic.Checked == true)
            {
                tb_Topic.Enabled = true;
            }
            else
            {
                tb_Topic.Enabled = false;
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

        private void FillComboBoxWithStudents()
        {
            using (var PrivateLessonsDb = new PrivateLessonsEntities())
            {
                cb_UsersList.DataSource = PrivateLessonsDb.Students.ToList();
                cb_UsersList.ValueMember = "Id";
                cb_UsersList.DisplayMember = "StudentDescription";
            }
        }

        private void EditPrivateLesson_Load(object sender, EventArgs e)
        {
            FillComboBoxWithStudents();
            rb_Math.Checked = true;
            rb_Home.Checked = true;
        }

        private void rb_OtherTopic_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_OtherTopic.Checked == true)
            {
                tb_Subject.Visible = true;
            }
            else
            {
                tb_Subject.Visible = false;
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("pl-PL");

            if (AddHourValidation.HourDataValidation(tb_Subject, cb_StartMin, cb_startDateHour, cb_Duration))
            {
                using (var DB = new PrivateLessonsEntities())
                {
                    var HourToUpdate = DB.PrivateLessonHour.Single(h => h.Id == LessonToEdit.Id);

                    if (cb_UsersList.Enabled == true)
                    {
                        HourToUpdate.StudentId = int.Parse(cb_UsersList.SelectedValue.ToString());
                        HourToUpdate.HourDescriptionSchedule = cb_UsersList.Text;
                    }

                    if (cb_startDateHour.Enabled == true && cb_StartMin.Enabled == true)
                    {
                        var startDate = HourToUpdate.StartDate.Date
                                .AddHours(int.Parse(cb_startDateHour.Text))
                                .AddMinutes(int.Parse(cb_StartMin.Text));

                        var duration = (int)HourToUpdate.EndDate.TimeOfDay.TotalMinutes - (int)HourToUpdate.StartDate.TimeOfDay.TotalMinutes;

                        HourToUpdate.StartDate = startDate;
                        HourToUpdate.EndDate = startDate.AddMinutes(duration);

                        HourToUpdate.HourDescription = HourToUpdate.StartDate.ToString("HH:mm")
                                     + " | " + cb_UsersList.Text +
                                     " | " + culture.DateTimeFormat.GetDayName(HourToUpdate.StartDate.DayOfWeek) +
                                     " " + HourToUpdate.StartDate.Day +
                                     "-" + HourToUpdate.StartDate.Month +
                                     "-" + HourToUpdate.StartDate.Year;
                    }

                    if (cb_Duration.Enabled == true)
                    {
                        var mins = (int)HourToUpdate.StartDate.TimeOfDay.TotalMinutes;
                        HourToUpdate.EndDate = HourToUpdate.StartDate.Date.AddMinutes(mins + int.Parse(cb_Duration.Text));

                        HourToUpdate.HourDescription = HourToUpdate.StartDate.ToString("HH:mm")
                                     + " | " + cb_UsersList.Text +
                                     " | " + culture.DateTimeFormat.GetDayName(HourToUpdate.StartDate.DayOfWeek) +
                                     " " + HourToUpdate.StartDate.Day +
                                     "-" + HourToUpdate.StartDate.Month +
                                     "-" + HourToUpdate.StartDate.Year;
                    }

                    if (gb_Place.Enabled == true)
                    {
                        var isHome = true;
                        if (rb_StudentHome.Checked == true)
                        {
                            isHome = false;
                        }

                        HourToUpdate.IsHome = isHome;
                    }

                    if (gb_Subject.Enabled == true)
                    {
                        var subject = "Matematyka";
                        if (rb_OtherTopic.Checked == true)
                        {
                            subject = tb_Subject.Text;
                        }
                        HourToUpdate.Subject = subject;
                    }

                    if (dtp_StartDate.Enabled == true)
                    {
                        var mins = (int)HourToUpdate.StartDate.TimeOfDay.TotalMinutes;
                        var duration = (int)HourToUpdate.EndDate.TimeOfDay.TotalMinutes - (int)HourToUpdate.StartDate.TimeOfDay.TotalMinutes;
                        HourToUpdate.StartDate = DateTime.Parse(dtp_StartDate.Text);
                        HourToUpdate.StartDate = HourToUpdate.StartDate.AddMinutes(mins);
                        HourToUpdate.EndDate = DateTime.Parse(dtp_StartDate.Text);
                        HourToUpdate.EndDate = HourToUpdate.StartDate.AddMinutes(duration);

                        HourToUpdate.HourDescription = HourToUpdate.StartDate.ToString("HH:mm")
                                     + " | " + cb_UsersList.Text +
                                     " | " + culture.DateTimeFormat.GetDayName(HourToUpdate.StartDate.DayOfWeek) +
                                     " " + HourToUpdate.StartDate.Day +
                                     "-" + HourToUpdate.StartDate.Month +
                                     "-" + HourToUpdate.StartDate.Year;
                    }

                    if (tb_Topic.Enabled == true)
                    {
                        HourToUpdate.Topic = tb_Topic.Text;
                    }

                    if (tb_Comment.Enabled == true)
                    {
                        HourToUpdate.Comment = tb_Comment.Text;
                    }


                    if (AddHourValidation.HourOnHour(HourToUpdate))
                    {
                        DB.SaveChanges();
                        var finishMessage = MessageBox.Show("Pomyślnie edytowano dane korepetycji");
                    }
                    else
                    {
                        var errorMessage = MessageBox.Show("Nowa godzina korepetycji pokrywa się z już istniejącą");
                    }
                    
                }
            }
        }
    }
}
