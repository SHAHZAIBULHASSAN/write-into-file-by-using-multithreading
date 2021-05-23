using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multithreadingfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\Users\shahzaib.hassan\Desktop\File\file.text");
            StreamWriter writer =  file.CreateText();
            writer.WriteLine(textBox1.Text);
            writer.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FileInfo fil = new FileInfo(@"C:\Users\shahzaib.hassan\Desktop\File\Myfile.text");
           
            StreamWriter writer = fil.CreateText();
            writer.WriteLine(textBox1.Text);
            writer.Close();

        }
    }
}
