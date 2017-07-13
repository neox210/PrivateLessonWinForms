using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateLessonsEntity
{
    public static class AddStudentValidation
    {
        public static bool ValidateStudentData(TextBox tb_Name, TextBox tb_Surname, TextBox tb_PhoneNumber, TextBox tb_City, TextBox tb_Street, ComboBox cb_Level, ComboBox cb_Class)
        {
            if (tb_Name.Enabled == true && string.IsNullOrWhiteSpace(tb_Name.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj imię ucznia!");
                return false;
            }

            if (tb_Surname.Enabled == true && string.IsNullOrWhiteSpace(tb_Surname.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj nazwisko ucznia!");
                return false;
            }
            int value;

            if (tb_PhoneNumber.Enabled == true && (string.IsNullOrWhiteSpace(tb_PhoneNumber.Text) || tb_PhoneNumber.Text.Length != 9 || !int.TryParse(tb_PhoneNumber.Text, out value)))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj 9 cyfrowy numer telefonu (musi się składać tylko z cyfr, bez spacji)");
                return false;
            }

            if (tb_City.Enabled == true && tb_Street.Enabled == true &&  (string.IsNullOrWhiteSpace(tb_City.Text) || string.IsNullOrWhiteSpace(tb_Street.Text)))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Podaj pełny adres ucznia");
                return false;
            }

            if (cb_Level.Enabled == true && string.IsNullOrWhiteSpace(cb_Level.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz poziom nauczania ucznia!");
                return false;
            }
            if (cb_Class.Enabled == true && (cb_Level.SelectedIndex == 0 || cb_Level.SelectedIndex == 1 || cb_Level.SelectedIndex == 2 || cb_Level.SelectedIndex == 3) && string.IsNullOrWhiteSpace(cb_Class.Text))
            {
                var errorNullOrwhiteSpace = MessageBox.Show("Wybierz klasę ucznia!");
                return false;
            }

            return true;
        }

        
    }
}
