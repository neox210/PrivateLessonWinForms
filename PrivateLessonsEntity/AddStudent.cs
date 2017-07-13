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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cb_Level.SelectedIndex = 0;
            cb_Class.SelectedIndex = 0;
        }

        public void ClassSelect(object sender, EventArgs e)
        {
            cb_Class.Items.Clear();
            switch (cb_Level.SelectedIndex)
            {
                case 0: // podstawowka
                    cb_Class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
                    cb_Class.Visible = true;
                    l_Class.Visible = true;
                    break;

                case 1: // gimnazjum
                    cb_Class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
               });
                    cb_Class.Visible = true;
                    l_Class.Visible = true;
                    break;

                case 2: // liceum
                    cb_Class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            });
                    cb_Class.Visible = true;
                    l_Class.Visible = true;
                    break;

                case 3: // technikum
                    cb_Class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            });
                    cb_Class.Visible = true;
                    l_Class.Visible = true;
                    break;
                case 4: //inne
                    cb_Class.Visible = false;
                    l_Class.Visible = false;
                    break;


                default:
                    break;
            }


        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Name.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj imię ucznia!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_Surname.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj nazwisko ucznia!");
                return;
            }
            int value;

            if (string.IsNullOrWhiteSpace(tb_PhoneNumber.Text) ||
                tb_PhoneNumber.Text.Length != 9 || 
                !int.TryParse(tb_PhoneNumber.Text, out value))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj 9 cyfrowy numer telefonu " +
                                                        "(musi się składać tylko z cyfr, bez spacji)");
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_City.Text) || string.IsNullOrWhiteSpace(tb_Street.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj pełny adres ucznia");
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_Level.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz poziom nauczania ucznia!");
                return;
            }
            if ((cb_Level.SelectedIndex == 0 || cb_Level.SelectedIndex == 1 || 
                cb_Level.SelectedIndex == 2 || cb_Level.SelectedIndex == 3) 
                && string.IsNullOrWhiteSpace(cb_Class.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz klasę ucznia!");
                return;
            }

            var student = new Students()
            {
                Name = tb_Name.Text,
                Surname = tb_Surname.Text,
                PhoneNumber = int.Parse(tb_PhoneNumber.Text),
                City = tb_City.Text,
                Street = tb_Street.Text,
                Level = cb_Level.Text,
                SchoolClass = int.Parse(cb_Class.Text),
                Comment = tb_Comment.Text,
                CreatedDate = DateTime.Now,
                StudentDescription = tb_Surname.Text + " " + tb_Name.Text + " " + tb_City.Text
            };

            string message = $"Czy na pewno chcesz dodać ucznia: \n" +
                                    $" {student.Name.ToUpper()} {student.Surname.ToUpper()}\n" +
                                    $"numer telefonu: {student.PhoneNumber}\n" +
                                    $"Adres: {student.City} {student.Street}\n" +
                                    $"poziom nauczania: {student.Level} klasa: {student.SchoolClass}\n" +
                                    $"Komentarz: {student.Comment}";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var PrivateLessonsDB = new PrivateLessonsEntities())
                {
                    PrivateLessonsDB.Students.Add(student);
                    PrivateLessonsDB.SaveChanges();
                }

                result = MessageBox.Show("Pomyślnie dodano ucznia!");
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
