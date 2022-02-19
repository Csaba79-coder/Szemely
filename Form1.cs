using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szemely
{
    public partial class Form1 : Form
    {
        Ember sz1, sz2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sz2 = new Ember(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), checkBox1.Checked);
            String neme;
            if (sz2.Getferfi()) { neme = "Férfi"; } else { neme = "Nő"; }
            label2.Text = "Név: " + sz2.Getnev() + "  Születési év: " + sz2.Getszul_ev().ToString() + "  Neme: " + neme + "  Életkor: " + sz2.GetEletkor().ToString();
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sz1.GetEletkor() < sz2.GetEletkor())
            {
                label3.Text = sz2.Getnev() + " az idősebb, korkülömbség: " + (sz2.GetEletkor() - sz1.GetEletkor()) + " év";
            }
            else if (sz1.GetEletkor() > sz2.GetEletkor())
            {
                label3.Text = sz1.Getnev() + " az idősebb, korkülömbség: " + (sz1.GetEletkor() - sz2.GetEletkor()) + " év";
            }
            else { label3.Text = " egyidősek "; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sz1 = new Ember(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), checkBox1.Checked);
            string neme;
            if (sz1.Getferfi()) { neme = "Férfi"; } else { neme = "Nő"; }
            label1.Text = "Név: " + sz1.Getnev() + "  Születési év: " + sz1.Getszul_ev().ToString() + "  Neme: " + neme + "  Életkor: " + sz1.GetEletkor().ToString();
            button2.Enabled = true;
        }
    }
}
