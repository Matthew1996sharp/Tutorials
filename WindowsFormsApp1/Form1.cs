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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = textBox1.Text;
            bool result = int.TryParse(s, out i); //i now = 108
            if ((result == false) || (textBox1.Text.StartsWith("0"))) label1.Text = "NO";
            if (textBox1.Text.Length == 0) label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\User\\OneDrive\\Desktop\\Новый текстовый документ.txt");
            sw.WriteLine(Convert.ToInt32(textBox1.Text));
            sw.WriteLine(Convert.ToDouble(textBox2.Text));
            sw.Close();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                if (textBox2.Text.Length == 0) label1.Text = "";
                else label1.Text = "NO";
            }
        }
    }
}
