using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double Number1, Number2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Number1 = double.Parse(textBox1.Text.Replace('.', ','));
                double Number2 = double.Parse(textBox2.Text.Replace('.', ','));
                textBox3.Text = Convert.ToString(Evaluation.Class1.Sum(Number1, Number2));
            }
            catch
            {
                MessageBox.Show("Error, please enter your number again.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
