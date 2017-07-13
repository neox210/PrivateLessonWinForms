using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateLessonsEntity
{
    public static class AddHourValidation
    {
        public static bool HourDataValidation(TextBox tb_Subject, ComboBox cb_StartMin, ComboBox cb_startDateHour, ComboBox cb_Duration)
        {
            if (tb_Subject.Enabled == true && tb_Subject.Visible == true && string.IsNullOrWhiteSpace(tb_Subject.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Należy wybrać przedmiot lub wpisać go ręcznie!");
                return false;
            }

            if (cb_StartMin.Enabled == true && cb_startDateHour.Enabled == true && (string.IsNullOrWhiteSpace(cb_StartMin.Text) || string.IsNullOrWhiteSpace(cb_startDateHour.Text)))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz godzinę rozpoczęcia zajęć!");
                return false;
            }

            if (cb_Duration.Enabled == true && string.IsNullOrWhiteSpace(cb_Duration.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz czas trwania zajęć!");
                return false;
            }
            return true;
        }

        public static bool HourOnHour(PrivateLessonHour privateLesson)
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
                if (checkValidate > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
