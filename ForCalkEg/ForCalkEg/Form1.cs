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

        private void ButtonsClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(entry.Text);
            double second = Convert.ToDouble(entrytwo.Text);
            double result;

            switch (((Button) sender).Name)
            {
                case "sum":
                    result = first + second;
                    break;
                case "sub":
                    result = first - second;
                    break;
                case "mul":
                    result = first*second;
                    break;
                case "divis":
                    result = first/second;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            conclusion.Text = result.ToString();
        }
    }
}
