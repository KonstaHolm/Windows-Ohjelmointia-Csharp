using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool likesIcecream = false;
            string likeIcecream = "";
            string age = "";
            string country = "";
            if (checkBox1.Checked)
            {
                likesIcecream = true;
                likeIcecream = "I like ice cream ";
            }

            if (radioButton1.Checked)
            {
                age = "0-20";
            }

            if (radioButton2.Checked)
            {
                age = "21-49";
            }

            if (radioButton3.Checked)
            {
                age = "50-";
            }

            country = listBox1.SelectedItem.ToString();

            string print = name + ":" + likeIcecream + "My age is " + age + " I like" + Environment.NewLine + "to live in " + country;
            textBox2.Text = print;

        }
    }
}
