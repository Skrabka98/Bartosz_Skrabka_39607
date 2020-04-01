using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logowanie
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string login = textBox1.Text;
            string password = textBox2.Text;
            string[] logins = new string[4];
            string[] passwords = new string[4];

            logins[0] = "admin";
            logins[1] = "user";
            logins[2] = "root";
            logins[3] = "plebs";

            passwords[0] = "12345";
            passwords[1] = "qwerty";
            passwords[2] = "tajnehaslo";
            passwords[3] = "niepodam";



            for (int i = 0; i <= 3; i++)
            {

                if (login == logins[i] && password == passwords[i])
                {
                    zalogowany();
                }

            }


        }

        public void zalogowany()
        {
            Form2 f = new Form2();
            f.Show();
        }

    }
}
