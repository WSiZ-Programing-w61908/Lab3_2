using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(radioButton1.Checked == true)
            {
                if (textBox1.Text == "1") MessageBox.Show("31.05.2021", "Termin egzaminu");
                else if (textBox1.Text == "2") MessageBox.Show("07.06.2021", "Termin egzaminu");
                else if (textBox1.Text == "3") MessageBox.Show("13.05.2021", "Termin egzaminu");
                else if (textBox1.Text == "4") MessageBox.Show("01.06.2021", "Termin egzaminu");
                else MessageBox.Show("Nie ma takiego przedmiotu");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label2.Visible = true;
                listBox2.Visible = true;
            }
        }
    }
}
