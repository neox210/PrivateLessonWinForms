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
    public partial class DeleteStudent : Form
    {
        private List<Students> StudentsSelectedList;
        private List<Students> StudentsPickList;


        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void FillListBoxWithStudents()
        {
            lb_PickStudents.DataSource = StudentsPickList;
            lb_PickStudents.ValueMember = "Id";
            lb_PickStudents.DisplayMember = "StudentDescription";
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            var StudentList = new StudentList();
            StudentsPickList = StudentList.StudentsPickList;
            StudentsSelectedList = new List<Students>();
            FillListBoxWithStudents();

        }

        private void UpdatePickListBox()
        {
            lb_PickStudents.DataSource = StudentsPickList;
            lb_PickStudents.ValueMember = "Id";
            lb_PickStudents.DisplayMember = "StudentDescription";
        }

        private void UpdateSelectedListBox()
        {
            
            lb_SelectedStudents.DataSource = StudentsSelectedList;
            lb_SelectedStudents.ValueMember = "Id";
            lb_SelectedStudents.DisplayMember = "StudentDescription";
        }

        private void ClearListboxex()
        {
            lb_PickStudents.DataSource = null;
            lb_PickStudents.Items.Clear();
            UpdatePickListBox();
            lb_SelectedStudents.DataSource = null;
            lb_SelectedStudents.Items.Clear();
            UpdateSelectedListBox();
        }

        private void ArrowRught_Click(object sender, EventArgs e)
        {

            if (StudentsPickList.Count>0)
            {
                var studentToRemove = StudentsPickList.Single(s => s.Id == int.Parse(lb_PickStudents.SelectedValue.ToString()));
                StudentsSelectedList.Add(studentToRemove);
                StudentsPickList.Remove(studentToRemove);
                ClearListboxex();
            }
        }

        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            if (StudentsSelectedList.Count>0)
            {
                var studentToReturn = StudentsSelectedList.Single(s => s.Id == int.Parse(lb_SelectedStudents.SelectedValue.ToString()));
                StudentsSelectedList.Remove(studentToReturn);
                StudentsPickList.Add(studentToReturn);
                ClearListboxex();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (var DB = new PrivateLessonsEntities())
            {
                var studentIdList = new List<int>();
                foreach (var student in StudentsSelectedList)
                {
                    studentIdList.Add(student.Id);
                }
                foreach (var id in studentIdList)
                {
                    var studentToDelete = DB.Students.FirstOrDefault(i => i.Id == id);
                    DB.Students.Remove(studentToDelete);
                }
                DB.SaveChanges();
            }
            StudentsSelectedList.Clear();
            ClearListboxex();
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


        private void DoubleArrowRight_Click(object sender, EventArgs e)
        {
            if (StudentsPickList.Count>0)
            {
                StudentsSelectedList.AddRange(StudentsPickList);
                StudentsPickList.Clear();
                ClearListboxex();
            }
        }

        private void DoubleArrowLeft_Click(object sender, EventArgs e)
        {
            if (StudentsSelectedList.Count>0)
            {
                StudentsPickList.AddRange(StudentsSelectedList);
                StudentsSelectedList.Clear();
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
    }
}
