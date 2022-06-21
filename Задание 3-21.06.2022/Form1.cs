using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_бонус_20._06._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(textBox1.Text);
                label1.Text = "Файл сохранён";
                sw.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox2.Text + ".txt";
                StreamReader sr = new StreamReader(path);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream ofs = File.Open(path, FileMode.Open);
            FileStream cfs = File.Create(path + ".gz");
            GZipStream compressor = new GZipStream(cfs, CompressionMode.Compress);
            ofs.CopyTo(compressor);
            compressor.Close();
            ofs.Close();
            cfs.Close();
            label1.Text = "Файл успешно сжат";
        }
    }
}
