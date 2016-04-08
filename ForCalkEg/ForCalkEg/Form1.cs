using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForCalkEg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(entry.Text);
            double second = Convert.ToDouble(entrytwo.Text);
            double result = first + second;
            conclusion.Text = result.ToString();

   
        }

        private void mul_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(entry.Text);
            double second = Convert.ToDouble(entrytwo.Text);
            double result = first * second;
            conclusion.Text = result.ToString();

        }

        private void divis_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(entry.Text);
            double second = Convert.ToDouble(entrytwo.Text);
            double result = first / second;
            conclusion.Text = result.ToString();

        }

        private void sub_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(entry.Text);
            double second = Convert.ToDouble(entrytwo.Text);
            double result = first - second;
            conclusion.Text = result.ToString();

        }
    }
}
