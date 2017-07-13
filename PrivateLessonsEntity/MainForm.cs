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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pb_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent AddStudentForm = new AddStudent();
            AddStudentForm.Show(); 
        }

        private void pb_AddHour_Click(object sender, EventArgs e)
        {
            AddPrivateLesson AddStudentForm = new AddPrivateLesson();
            AddStudentForm.Show();
        }

        private void pb_DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent DeleteStudentForm = new DeleteStudent();
            DeleteStudentForm.Show();
        }

        private void pb_DeleteHour_Click(object sender, EventArgs e)
        {
            DeletePrivateLesson DeletePrivateLessonForm = new DeletePrivateLesson();
            DeletePrivateLessonForm.Show();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Schedule_Click(object sender, EventArgs e)
        {
            ScheduleForm ScheduleForm = new ScheduleForm();
            ScheduleForm.Show();
        }

        private void pb_StudentList_Click(object sender, EventArgs e)
        {
            StudentEnumeration StudentEnumerationForm = new StudentEnumeration();
            StudentEnumerationForm.Show();
        }

        private void pb_AddHour_MouseEnter(object sender, EventArgs e)
        {
            pb_AddHour.Image = Resources.DodajGodzinęButtonHover;
        }

        private void pb_AddHour_MouseLeave(object sender, EventArgs e)
        {
            pb_AddHour.Image = Resources.DodajGodzinęButton;
        }

        private void pb_AddStudent_MouseEnter(object sender, EventArgs e)
        {
            pb_AddStudent.Image = Resources.DodajUczniaButtonHover;
        }

        private void pb_AddStudent_MouseLeave(object sender, EventArgs e)
        {
            pb_AddStudent.Image = Resources.DodajUczniaButton;
        }

        private void pb_DeleteHour_MouseEnter(object sender, EventArgs e)
        {
            pb_DeleteHour.Image = Resources.UsunGodzineButtonHover;
        }

        private void pb_DeleteHour_MouseLeave(object sender, EventArgs e)
        {
            pb_DeleteHour.Image = Resources.UsunGodzineButton;
        }

        private void pb_DeleteStudent_MouseEnter(object sender, EventArgs e)
        {
            pb_DeleteStudent.Image = Resources.UsunUcznaButtonHover;
        }

        private void pb_DeleteStudent_MouseLeave(object sender, EventArgs e)
        {
            pb_DeleteStudent.Image = Resources.UsunUcznaButton;
        }

        private void pb_Schedule_MouseEnter(object sender, EventArgs e)
        {
            pb_Schedule.Image = Resources.GrafikButtonHover;
        }

        private void pb_Schedule_MouseLeave(object sender, EventArgs e)
        {
            pb_Schedule.Image = Resources.GrafikButton;
        }

        private void pb_StudentList_MouseEnter(object sender, EventArgs e)
        {
            pb_StudentList.Image = Resources.ListaUczniowButtonHover;
        }

        private void pb_StudentList_MouseLeave(object sender, EventArgs e)
        {
            pb_StudentList.Image = Resources.ListaUczniowButton;
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
