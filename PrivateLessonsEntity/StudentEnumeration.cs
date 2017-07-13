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
    public partial class StudentEnumeration : Form
    {
        List<Students> StudentsList;
        public StudentEnumeration()
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

        private void FillStudentsTable(ListView listview)
        {
            var LoadStudents = new StudentList();
            this.StudentsList = LoadStudents.StudentsPickList;

            listview.Items.Clear();

            foreach (var student in StudentsList)
            {
                var item = new ListViewItem(student.Id.ToString());
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.Surname);
                item.SubItems.Add(student.PhoneNumber.ToString());
                item.SubItems.Add(student.City);
                item.SubItems.Add(student.Street);
                item.SubItems.Add(student.Level);
                item.SubItems.Add(student.SchoolClass.ToString());
                item.SubItems.Add(student.CreatedDate.ToString("dd-MM-yyyy"));

                listview.Items.Add(item);
            }
        }

        private void StudentEnumeration_Load(object sender, EventArgs e)
        {
            FillStudentsTable(lv_StudentList);
        }

        private void dodajUczniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent AddStudentForm = new AddStudent();
            AddStudentForm.Show();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var DB = new PrivateLessonsEntities())
            {
                var studentId = int.Parse(lv_StudentList.SelectedItems[0].Text);


                var StudentToRemove = DB.Students.FirstOrDefault(s => s.Id == studentId);

                DB.Students.Remove(StudentToRemove);
                DB.SaveChanges();
            }

            FillStudentsTable(lv_StudentList);
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            FillStudentsTable(lv_StudentList);
        }

        private void pb_Search_Click(object sender, EventArgs e)
        {
            var searchValue = tb_Search.Text;

            using (var DB = new PrivateLessonsEntities())
            {
                var searchList = DB.Students.Where(
                                                    s => s.Name.Contains(searchValue) ||
                                                    s.Surname.Contains(searchValue) ||
                                                    s.City.Contains(searchValue) ||
                                                    s.Street.Contains(searchValue) ||
                                                    s.Level.Contains(searchValue) ||
                                                    s.Comment.Contains(searchValue)
                                                    );

                lv_StudentList.Items.Clear();

                foreach (var student in searchList)
                {
                    var item = new ListViewItem(student.Id.ToString());
                    item.SubItems.Add(student.Name);
                    item.SubItems.Add(student.Surname);
                    item.SubItems.Add(student.PhoneNumber.ToString());
                    item.SubItems.Add(student.City);
                    item.SubItems.Add(student.Street);
                    item.SubItems.Add(student.Level);
                    item.SubItems.Add(student.SchoolClass.ToString());
                    item.SubItems.Add(student.CreatedDate.ToString("dd-MM-yyyy"));

                    lv_StudentList.Items.Add(item);
                }
            }
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent EditStudentForm = new EditStudent(int.Parse(lv_StudentList.SelectedItems[0].Text));
            EditStudentForm.Show();
        }


    }
}
