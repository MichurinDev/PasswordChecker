using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordChecker
{
    public partial class main_form : Form
    {
        public string password = ""; // Declaring a variable to store the password
        public bool[] result = new bool[5]; // Declaring a variable to store the values of the criteries
        /*
         * Result of burglary resistance according to 5 criteries:
         * Length (at least 8 characters)
         * Availability of uppercase letters
         * Availability of lowercase letters
         * Availability of special characters
         * Not on the popular list
         */

        // Symbol Lists
        public string eng_printed_symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string eng_lined_symb = "abcdefghijklmnopqrstuvwxyz";
        public string ru_printed_symb = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string ru_lined_symb = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string specsymb_arr = "!@#$%^&*()_+,./?><~\"№;:*«»";

        public main_form() // Form initialization
        {
            InitializeComponent();
        }

        // Function for checking password for compliance
        public void PasswordCheck(string password)
        {
            // Resetting criteries values
            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = false;
            }
            result[result.Length - 1] = true;

            // Checking the password...
            result[0] = password.Length >= 8; // Matching the number of characters

            for (int i = 0; i < password.Length; i++)
            {
                if (eng_printed_symb.Contains(password[i].ToString()) || ru_printed_symb.Contains(password[i].ToString()))
                {
                    result[1] = true; // If there are uppercase characters
                }
                else if (eng_lined_symb.Contains(password[i].ToString()) || ru_lined_symb.Contains(password[i].ToString()))
                {
                    result[2] = true; // If there are lowercase characters
                }
                else if (specsymb_arr.Contains(password[i].ToString()))
                {
                    result[3] = true; // If there are special characters
                }
            }

            // The presence of a password in the list of frequently used
            try
            {
                // Reading a file
                StreamReader sr = new StreamReader("passwords_list.txt");
                string text = sr.ReadToEnd();

                String[] arrString = text.Split(';');

                foreach (string s in arrString)
                    if (s == password.ToLower())
                    {
                        result[4] = false; // If the password is in this list ...
                    }
            }
            catch
            {
                MessageBox.Show("Passwords list not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // If file is not found...
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = password_textBox.Text; // Get a password
            PasswordCheck(password); // Check it out

            // Displaying the result of the check
            if (result[0])
            {
                label00.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label00.ForeColor = System.Drawing.Color.Red;
            }

            if (result[1])
            {
                label11.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label11.ForeColor = System.Drawing.Color.Red;
            }

            if (result[2])
            {
                label22.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label22.ForeColor = System.Drawing.Color.Red;
            }

            if (result[3])
            {
                label33.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label33.ForeColor = System.Drawing.Color.Red;
            }

            if (result[4])
            {
                label44.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label44.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
