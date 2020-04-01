using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    double wzrost = Convert.ToDouble(textBox1.Text);
                    //Debug.WriteLine(wzrost);
                    double waga = Convert.ToDouble(textBox2.Text);
                    double wiek = Convert.ToDouble(textBox3.Text);
                    if (radioButton1.Checked == true)
                    {
                        double bmr = ((9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) + 5);
                        wynik.ForeColor = Color.Black;
                        wynik.Text = bmr.ToString();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        double bmr = ((9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) - 161);
                        wynik.ForeColor = Color.Black;
                        wynik.Text = bmr.ToString();
                    }
                }
                else
                {
                    wynik.ForeColor = Color.Red;
                    wynik.Text = "Brak danych";
                }
            }
            catch (Exception ex) {
                wynik.ForeColor = Color.Red;
                wynik.Text = "Brak danych";
            }
            } 

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
