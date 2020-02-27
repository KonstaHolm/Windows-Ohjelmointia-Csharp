using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_3._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        public class Calculate
        {
            private double pValue1;
            private double pValue2;

            public Calculate(double value1, double value2)
            {
                pValue1 = value1;
                pValue2 = value2;
            }

            public string Add()
            {
                double value3 = pValue1 + pValue2;
                string str = value3.ToString();
                return str;
            }

            public string Minus()
            {
                double value3 = pValue1 - pValue2;
                string str = value3.ToString();
                return str;
            }

            public string Mul()
            {
                double value3 = pValue1 * pValue2;
                string str = value3.ToString();
                return str;
            }

            public string Div()
            {
                double value3 = pValue1 / pValue2;
                string str = value3.ToString();
                return str;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            double value1;
            double value2;
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            value1 = Convert.ToDouble(str1);
            value2 = Convert.ToDouble(str2);
            Calculate laskin = new Calculate(value1, value2);

            label3.Text = laskin.Add();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value1;
            double value2;
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            value1 = Convert.ToDouble(str1);
            value2 = Convert.ToDouble(str2);
            Calculate laskin = new Calculate(value1, value2);
            label3.Text = laskin.Minus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double value1;
            double value2;
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            value1 = Convert.ToDouble(str1);
            value2 = Convert.ToDouble(str2);
            Calculate laskin = new Calculate(value1, value2);
            label3.Text = laskin.Mul();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double value1;
            double value2;
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            value1 = Convert.ToDouble(str1);
            value2 = Convert.ToDouble(str2);
            Calculate laskin = new Calculate(value1, value2);
            label3.Text = laskin.Div();
        }
    }
}
