using PrivateLessonsEntity.Properties;
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
    public partial class AddPrivateLesson : Form
    {
        public AddPrivateLesson()
        {
            InitializeComponent();
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

        private void b_save_Click(object sender, EventArgs e)
        {

            if (tb_Subject.Visible == true && string.IsNullOrWhiteSpace(tb_Subject.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Należy wybrać przedmiot lub wpisać go ręcznie!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_StartMin.Text) || string.IsNullOrWhiteSpace(cb_startDateHour.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz godzinę rozpoczęcia zajęć!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_Duration.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz czas trwania zajęć!");
                return;
            }

            var startDate = DateTime.Parse(dtp_StartDate.Text)
                            .AddHours(int.Parse(cb_startDateHour.Text))
                            .AddMinutes(int.Parse(cb_StartMin.Text));

            var isHome = true;
            if(rb_StudentHome.Checked == true)
            {
                isHome = false;
            }

            var subject = "Matematyka";
            if (rb_OtherTopic.Checked == true)
            { 
                subject = tb_Subject.Text;
            }
            var culture = new CultureInfo("pl-PL");
            var privateLesson = new PrivateLessonHour()
            {
                StudentId = int.Parse(cb_UsersList.SelectedValue.ToString()),
                StartDate = startDate,
                EndDate = startDate.AddMinutes(int.Parse(cb_Duration.Text)),
                IsHome = isHome,
                Subject = subject,
                Topic = tb_Topic.Text,
                Comment = tb_Comment.Text,
                HourDescription = startDate.ToString("HH:mm")
                                 + " | " +  cb_UsersList.Text + 
                                 " | " +  culture.DateTimeFormat.GetDayName(startDate.DayOfWeek) + 
                                 " " + startDate.Day + 
                                 "-" + startDate.Month + 
                                 "-"+ startDate.Year,
                HourDescriptionSchedule = cb_UsersList.Text
            };

            if (string.IsNullOrWhiteSpace(privateLesson.Topic))
            {
                privateLesson.Topic = "brak tematu";
            }

            if (string.IsNullOrWhiteSpace(privateLesson.Comment))
            {
                privateLesson.Comment = "brak komentarza";
            }

            string WhereLesson = "u mnie w domu";
            if (privateLesson.IsHome == false)
            {
                WhereLesson = "u ucznia w domu";
            }

            string message = $"Czy na pewno chcesz dodać godzinę korepetycji dla: \n" +
                                    $" {privateLesson.HourDescriptionSchedule.ToUpper()} \n" +
                                    $"rozpoczynającą się: {privateLesson.StartDate.ToString("HH:mm dddd dd MMMM")} \n" +
                                    $"konczącą sie: {privateLesson.EndDate.ToString("HH:mm dddd dd MMMM")} \n" +
                                    $"odbywającą się: {WhereLesson} \n" +
                                    $"Przedmiot: {privateLesson.Subject} - {privateLesson.Topic} \n" +
                                    $"Komentarz: {privateLesson.Comment}";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var PrivateLessonsDB = new PrivateLessonsEntities())
                {
                    var validateHour = PrivateLessonsDB.PrivateLessonHour.Where(h => h.StartDate.Day == privateLesson.StartDate.Day &&
                                                                                     h.StartDate.Month == privateLesson.StartDate.Month &&
                                                                                     h.StartDate.Year == privateLesson.StartDate.Year);
                    int checkValidate = 0;

                    foreach (var hour in validateHour)
                    {
                        if (((privateLesson.StartDate > hour.StartDate) && (privateLesson.EndDate < hour.EndDate)) ||
                            (privateLesson.StartDate == hour.StartDate && privateLesson.EndDate == hour.EndDate) ||
                            (privateLesson.EndDate <= hour.EndDate && privateLesson.EndDate > hour.StartDate) ||
                            (privateLesson.StartDate < hour.EndDate && privateLesson.StartDate >= hour.StartDate) ||
                            (hour.StartDate > privateLesson.StartDate && hour.EndDate < privateLesson.EndDate)
                            )
                        {
                            checkValidate++;
                        }
                    }


                    if (checkValidate == 0)
                    {
                        PrivateLessonsDB.PrivateLessonHour.Add(privateLesson);
                        PrivateLessonsDB.SaveChanges();
                        string finishMessage = "Pomyślnie dodano godzinę do bazy danych";
                        result = MessageBox.Show(finishMessage);
                    }
                    else
                    {
                        string errorMessage = "Nowa godzina korepetycji pokrywa się z aktualnie istniejącą";
                        result = MessageBox.Show(errorMessage);
                    }
                }
            }
        }

        private void AddPrivateLesson_Load(object sender, EventArgs e)
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

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_exit_MouseEnter(object sender, EventArgs e)
        {
            pb_exit.Image = Resources.exithover;
        }

        private void pb_exit_MouseLeave(object sender, EventArgs e)
        {
            pb_exit.Image = Resources.exit;
        }
    }
}
