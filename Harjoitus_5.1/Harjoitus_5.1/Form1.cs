using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] persons = new string[10];
        int counter = 0;





        private void save_button_Click(object sender, EventArgs e)
        {

            string str1 = firstNameBox.Text;
            string str2 = lastNameBox.Text;
            string str3 = ageBox.Text.ToString();
            string str4 = str1 + " " + str2 + " " + str3 + Environment.NewLine;
            if(counter <= 9)
            {
                persons[counter] = str4;
                counter++;
            }
            if (counter > 9)
            {
                save_button.Enabled = false;
            }



        }

        private void print_button_Click(object sender, EventArgs e)
        {

            string syote = "";
            for(int i = 0; i <= 9; i++)
            {
                syote += persons[i];
            }

            printBox.Text = syote;

        }
    }
}
