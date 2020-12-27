using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        bool isText1Number = false;
        bool isText2Number = false;
        double num1;
        double num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void CombineButton_Click(object sender, EventArgs e)
        {
            if (!isText1Number || !isText2Number)
            {
                MessageBox.Show("Please enter numbers into the input fields!");
            }
            else
            {
                double sum = num1 + num2;
                label1.Text = sum.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            isText1Number = double.TryParse(textBox1.Text, out num1);
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isText2Number = double.TryParse(textBox2.Text, out num2);
        }
    }
}
