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
    public partial class ScheduleForm : Form
    {
        List<PrivateLessonHour> HourList = new List<PrivateLessonHour>(); 
        public ScheduleForm()
        {
            InitializeComponent();
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

        private void ScheduleFill(ListView ListView, DateTime Date)
        {
            ListView.Items.Clear();
            var PrivateLessonsList = new List<PrivateLessonHour>();

                using (var DB = new PrivateLessonsEntities())
                {
                    PrivateLessonsList = DB.PrivateLessonHour.Where(d => d.StartDate.Day == Date.Day &&
                                                                    d.StartDate.Month == Date.Month &&
                                                                    d.StartDate.Year == Date.Year)
                                                              .ToList();
                }
                PrivateLessonsList.Sort((d1, d2) => d1.StartDate.CompareTo(d2.StartDate));
            
                foreach (var hour in PrivateLessonsList)
                {
                string lessonPlace;
                if (hour.IsHome == true)
                {
                    lessonPlace = "U mnie w domu";
                }
                else
                {
                    lessonPlace = "DOJAZD DO UCZNIA";
                }
                    var item = new ListViewItem(hour.Id.ToString());
                    item.SubItems.Add(hour.StartDate.ToString("HH:mm"));
                    item.SubItems.Add(hour.EndDate.ToString("HH:mm"));
                    item.SubItems.Add(hour.HourDescriptionSchedule);
                    item.ToolTipText = $"{hour.HourDescriptionSchedule} \n" +
                                        $"{hour.Subject}\n" +
                                        $"{hour.Topic}\n" +
                                        $"{lessonPlace}\n" +
                                        $"{hour.Comment}\n" +
                                        $"PPM - Edytuj";

                

                    ListView.Items.Add(item);
                }
        }

        private void HourListFill()
        {
            l_Day1.Visible = true;
            l_Day2.Visible = true;
            l_Day3.Visible = true;
            l_Day4.Visible = true;
            l_Day5.Visible = true;
            l_Day6.Visible = true;

            l_Day1.Text = dtp_Date.Value.ToString("dddd dd MMMM");
            l_Day2.Text = dtp_Date.Value.AddDays(1).ToString("dddd dd MMMM");
            l_Day3.Text = dtp_Date.Value.AddDays(2).ToString("dddd dd MMMM");
            l_Day4.Text = dtp_Date.Value.AddDays(3).ToString("dddd dd MMMM");
            l_Day5.Text = dtp_Date.Value.AddDays(4).ToString("dddd dd MMMM");
            l_Day6.Text = dtp_Date.Value.AddDays(5).ToString("dddd dd MMMM");

            ScheduleFill(lv_Day1, dtp_Date.Value);
            ScheduleFill(lv_Day2, dtp_Date.Value.AddDays(1));
            ScheduleFill(lv_Day3, dtp_Date.Value.AddDays(2));
            ScheduleFill(lv_Day4, dtp_Date.Value.AddDays(3));
            ScheduleFill(lv_Day5, dtp_Date.Value.AddDays(4));
            ScheduleFill(lv_Day6, dtp_Date.Value.AddDays(5));

            lv_Day1.Visible = true;
            lv_Day2.Visible = true;
            lv_Day3.Visible = true;
            lv_Day4.Visible = true;
            lv_Day5.Visible = true;
            lv_Day6.Visible = true;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            HourListFill();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day1.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day2.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day3.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day4.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day5.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            EditPrivateLesson EditPrivateLessonForm = new EditPrivateLesson(int.Parse(lv_Day6.SelectedItems[0].Text));
            EditPrivateLessonForm.Show();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            HourListFill();
        }
    }
}
