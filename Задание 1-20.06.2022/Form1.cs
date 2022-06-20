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
            dolg = 100000;
            label1.Text = "Долг по кредиту: " + dolg;
        }
        double dolg;
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Math.Round(Convert.ToDouble(textBox1.Text), 2);
            Plata(x);
        }
        public void Plata(double p)
        {
            if(p >= dolg)
            {
                double c = p - dolg;
                dolg = 0;
                label1.Text = "Долг по кредиту: " + dolg;
                label1.Text += "\nКредит погашен\n";
                label1.Text += "Переплата: " + (c);
            }
            if(p < dolg)
            {
                dolg -= p;
                label1.Text = "Платёж принят\n";
                label1.Text += "Долг по кредиту: " + dolg;              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dolg = 100000;
            label1.Text = "Долг по кредиту: " + dolg;
        }
    }
}
