using System;
using System.Windows.Forms;
using System.IO;

namespace PasswordChecker
{
    public partial class main_form : Form
    {
        public string password = "";
        public bool[] result = new bool[5];
        /*
         * Результат взломоустойчивости по 5-ти критериям:
         * Длина
         * Наличие прописных букв
         * Наличие строчных букв
         * Наличие спецсимволов
         * Отсутствие в списке популярных
         */

        public string eng_printed_symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string eng_lined_symb = "abcdefghijklmnopqrstuvwxyz";
        public string ru_printed_symb = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string ru_lined_symb = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string specsymb_arr = "!@#$%^&*()_+,./?><~\"№;:*«»";

        public main_form()
        {
            InitializeComponent();
        }

        public void PasswordCheck(string password)
        {
            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = false;
            }
            result[result.Length - 1] = true;

            result[0] = password.Length >= 8;

            for (int i = 0; i < password.Length; i++)
            {
                if(eng_printed_symb.Contains(password[i].ToString()) || ru_printed_symb.Contains(password[i].ToString()))
                {
                    result[1] = true;
                } else if(eng_lined_symb.Contains(password[i].ToString()) || ru_lined_symb.Contains(password[i].ToString()))
                {
                    result[2] = true;
                } else if(specsymb_arr.Contains(password[i].ToString())){
                    result[3] = true;
                }
            }

            try{
                StreamReader sr = new StreamReader("passwords_list.txt");
                string text = sr.ReadToEnd();

                String[] arrString = text.Split(';');

                foreach (string s in arrString)
                    if (s == password.ToLower())
                    {
                        result[4] = false;
                    }
            } catch {
                MessageBox.Show("Passwords list not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = password_textBox.Text;
            PasswordCheck(password);

            if(result[0]){
                label00.ForeColor = System.Drawing.Color.Green;
            } else {
                label00.ForeColor = System.Drawing.Color.Red;
            }

            if (result[1])
            {
                label11.ForeColor = System.Drawing.Color.Green;
            } else {
                label11.ForeColor = System.Drawing.Color.Red;
            }

            if (result[2])
            {
                label22.ForeColor = System.Drawing.Color.Green;
            } else {
                label22.ForeColor = System.Drawing.Color.Red;
            }

            if (result[3])
            {
                label33.ForeColor = System.Drawing.Color.Green;
            } else {
                label33.ForeColor = System.Drawing.Color.Red;
            }

            if (result[4])
            {
                label44.ForeColor = System.Drawing.Color.Green;
            } else {
                label44.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
