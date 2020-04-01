using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 pesel = Int32.Parse(textBox1.Text.ToString());
            Int32[] tab = new Int32[11];

            for (int i = 10; i >= 0; i--)
            {
                tab[i] = pesel % 10;
                pesel = pesel / 10;
            }


            Int32 wzor = 1 * tab[0] + 3 * tab[1] + 7 * tab[2] + 9 * tab[3] + 1 * tab[4] + 3 * tab[5] + 7 * tab[6] + 9 * tab[7] + 1 * tab[8] + 3 * tab[9];
            Int32 liczba = 10 - wzor % 10;

            if (liczba == tab[10])
            {
                label2.Text = "PESEL prawidłowy";
            }
            else
            {
                label2.Text = "PESEL nieprawidłowy";
            }
        }
    }
}
