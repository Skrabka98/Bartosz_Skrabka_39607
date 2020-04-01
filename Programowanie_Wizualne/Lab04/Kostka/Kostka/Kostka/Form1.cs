using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostka
{

    public partial class Form1 : Form
    {
        Random rand = new Random();
        int a;
        string number;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random();
        }
        public void Random()
        {
            a = rand.Next(1, 7);
            number = a.ToString();
            label2.Text = number;
        }
        private void Copy(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(label2.Text);
        }

        private void key_r(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                Random();
            }
        }
    }
}
