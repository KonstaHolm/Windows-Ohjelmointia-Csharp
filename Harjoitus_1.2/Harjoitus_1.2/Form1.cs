using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            double.TryParse(firstBox.Text, out a);
            double.TryParse(secondBox.Text, out b);

            double result = (a + b);

            resultLabel.Text = result.ToString();

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            double.TryParse(firstBox.Text, out a);
            double.TryParse(secondBox.Text, out b);

            double result = (a - b);

            resultLabel.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            double.TryParse(firstBox.Text, out a);
            double.TryParse(secondBox.Text, out b);

            double result = (a * b);

            resultLabel.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;

            double.TryParse(firstBox.Text, out a);
            double.TryParse(secondBox.Text, out b);

            double result = (a / b);

            resultLabel.Text = result.ToString();
        }
    }
}
