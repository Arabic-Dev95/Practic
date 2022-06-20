using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_20._06._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x % y);
            }
            if (radioButton2.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(Math.Pow(x,y));
            }
            if (radioButton3.Checked)
            {
                string x = textBox1.Text;
                string y = textBox2.Text;
                textBox3.Text = x + y;
            }
            if (radioButton4.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x / y);
            }
        }
    }
}
