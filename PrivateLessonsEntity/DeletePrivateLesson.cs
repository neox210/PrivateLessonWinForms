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
    public partial class DeletePrivateLesson : Form
    {
        List<PrivateLessonHour> PickHourList;
        List<PrivateLessonHour> SelectedHourList;


        public DeletePrivateLesson()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillComboBoxWithStudents()
        {
            using (var PrivateLessonsDb = new PrivateLessonsEntities())
            {

                cb_SelectStudent.DataSource = PrivateLessonsDb.Students.ToList();
                cb_SelectStudent.ValueMember = "Id";
                cb_SelectStudent.DisplayMember = "StudentDescription";
            }
        }

        private void FillListBoxWithHours()
        {
            lb_PickHours.DataSource = PickHourList;
            lb_PickHours.ValueMember = "Id";
            lb_PickHours.DisplayMember = "HourDescription";
        }

        private void DeleteDubbled()
        {
            if (SelectedHourList.Count>0)
            {
                var hoursToRemove = new List<PrivateLessonHour>();
                
                foreach (var hourPick in PickHourList)
                {
                    foreach (var hourSelect in SelectedHourList)
                    {
                        if (hourSelect.Id == hourPick.Id)
                        {
                            hoursToRemove.Add(hourSelect);
                        }
                    }
                }

                foreach (var hour in hoursToRemove)
                {
                    PickHourList.RemoveAll(h => h.Id == hour.Id);
                }
                    
                lb_PickHours.DataSource = null;
                lb_PickHours.Items.Clear();
                UpdatePickListBox();
            }
        }
        

        private void DeletePrivateLesson_Load(object sender, EventArgs e)
        {
            SelectedHourList = new List<PrivateLessonHour>();
            PickHourList = new List<PrivateLessonHour>();
            FillComboBoxWithStudents();
        }

        private void b_Show_Click(object sender, EventArgs e)
        {
            PickHourList.Clear();
            ShowHours();
            DeleteDubbled();
        }

        private void ShowHours()
        {
            if (rb_SortDateOrder.Checked == true)
            {
                var ListObj = new PrivateLessonsHoursList(dtp_SelectDate.Value, chb_ByStudent.Checked, int.Parse(cb_SelectStudent.SelectedValue.ToString()));
                PickHourList = ListObj.PrivateLessonsList;
            }
            else
            {
                var ListObj = new PrivateLessonsHoursList(int.Parse(cb_SelectStudent.SelectedValue.ToString()), chb_ByDate.Checked, dtp_SelectDate.Value);
                PickHourList = ListObj.PrivateLessonsList;
            }
            FillListBoxWithHours();
        }

        private void rb_SortDateOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SortDateOrder.Checked == true)
            {
                cb_SelectStudent.Enabled = false;
                chb_ByDate.Enabled = false;
                chb_ByDate.Checked = false;
                chb_ByStudent.Enabled = true;
                dtp_SelectDate.Enabled = true;
            }
            else
            {
                cb_SelectStudent.Enabled = true;
                chb_ByDate.Enabled = true;
                chb_ByStudent.Enabled = false;
                chb_ByStudent.Checked = false;
                dtp_SelectDate.Enabled = false;
            }
        }

        private void chb_ByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ByDate.Checked == true)
            {
                dtp_SelectDate.Enabled = true;
            }
            else
            {
                dtp_SelectDate.Enabled = false;
            }
        }

        private void chb_ByStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ByStudent.Checked == true)
            {
                cb_SelectStudent.Enabled = true;
            }
            else
            {
                cb_SelectStudent.Enabled = false;
            }
        }

        private void UpdatePickListBox()
        {
            lb_PickHours.DataSource = PickHourList;
            lb_PickHours.ValueMember = "Id";
            lb_PickHours.DisplayMember = "HourDescription";
        }

        private void UpdateSelectedListBox()
        {

            lb_SelectedHours.DataSource = SelectedHourList;
            lb_SelectedHours.ValueMember = "Id";
            lb_SelectedHours.DisplayMember = "HourDescription";
        }

        private void ClearListboxex()
        {
            lb_PickHours.DataSource = null;
            lb_PickHours.Items.Clear();
            UpdatePickListBox();
            lb_SelectedHours.DataSource = null;
            lb_SelectedHours.Items.Clear();
            UpdateSelectedListBox();
        }
        private void ArrowRught_Click(object sender, EventArgs e)
        {
            if (PickHourList.Count > 0)
            {
                var hourToRemove = PickHourList.Single(s => s.Id == int.Parse(lb_PickHours.SelectedValue.ToString()));
                SelectedHourList.Add(hourToRemove);
                PickHourList.Remove(hourToRemove);
                ClearListboxex();
            }
        }

        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            if (SelectedHourList.Count > 0)
            {
                var studentToReturn = SelectedHourList.Single(s => s.Id == int.Parse(lb_SelectedHours.SelectedValue.ToString()));
                SelectedHourList.Remove(studentToReturn);
                PickHourList.Add(studentToReturn);
                ClearListboxex();
            }
        }

        private void DoubleArrowLeft_Click(object sender, EventArgs e)
        {
            PickHourList.AddRange(SelectedHourList);
            SelectedHourList.Clear();
            ClearListboxex();
        }

        private void DoubleArrowRight_Click(object sender, EventArgs e)
        {
            SelectedHourList.AddRange(PickHourList);
            PickHourList.Clear();
            ClearListboxex();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (var DB = new PrivateLessonsEntities())
            {
                var IdListToDelete = new List<int>();
                foreach (var hour in SelectedHourList)
                {
                    IdListToDelete.Add(hour.Id);
                }

                foreach (var id in IdListToDelete)
                {
                    var hourToDelete = DB.PrivateLessonHour.FirstOrDefault(i => i.Id == id);
                    DB.PrivateLessonHour.Remove(hourToDelete);
                }
                DB.SaveChanges();
                SelectedHourList.Clear();
                ClearListboxex();
            }

        }

        private void ArrowRught_MouseEnter(object sender, EventArgs e)
        {
            ArrowRught.Image = Resources.Actions_arrow_right_icon_buttonhover;
        }

        private void ArrowRught_MouseLeave(object sender, EventArgs e)
        {
            ArrowRught.Image = Resources.Actions_arrow_right_icon_button;
        }

        private void ArrowLeft_MouseEnter(object sender, EventArgs e)
        {
            ArrowLeft.Image = Resources.Actions_arrow_left_icon_buttonhover;
        }

        private void ArrowLeft_MouseLeave(object sender, EventArgs e)
        {
            ArrowLeft.Image = Resources.Actions_arrow_left_icon_button;
        }

        private void DoubleArrowRight_MouseEnter(object sender, EventArgs e)
        {
            DoubleArrowRight.Image = Resources.Actions_arrow_right_double_icon_buttonhover;
        }

        private void DoubleArrowRight_MouseLeave(object sender, EventArgs e)
        {
            DoubleArrowRight.Image = Resources.Actions_arrow_right_double_icon_button;
        }

        private void DoubleArrowLeft_MouseEnter(object sender, EventArgs e)
        {
            DoubleArrowLeft.Image = Resources.Actions_arrow_left_double_icon_buttonhover;
        }

        private void DoubleArrowLeft_MouseLeave(object sender, EventArgs e)
        {
            DoubleArrowLeft.Image = Resources.Actions_arrow_left_double_icon_button;
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
