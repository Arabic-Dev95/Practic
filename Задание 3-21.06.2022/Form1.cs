using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Задание_3_21._06._2022
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
                WriteAllText(path, textBox1.Text);
                label1.Text = "Файл сохранён";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox2.Text + ".txt";
                textBox1.Text = ReadAllText(path);
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
        public static string ReadAllText(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                var encoding = new UTF8Encoding(true);
                StreamReader reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
        }
        public static void WriteAllText(string path, string text)
        {
            using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Write))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                stream.Write(info, 0, info.Length);
                //var encoding = new UTF8Encoding(true);
                //StreamWriter writer = new StreamWriter(stream, encoding);
                //writer.WriteLine(text);
            }
        }
    }
}

