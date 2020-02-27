using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student[] arraylist = new Student[100];
        int counter = 0;
        string syote = "";

        public class Student
        {
            private string name = "";
            private string age = "";

            public Student()
            {

            }

            public Student(string sAge, string sName)
            {
                age = sAge;
                name = sName;
            }

            public string getName()
            {
                return name;
            }

            public string getAge()
            {
                return age;
            }

        }
        

        private void add_button_Click(object sender, EventArgs e)
        {
            Student oppilas = new Student(ageBox.Text, nameBox.Text);
            arraylist[counter] = oppilas;
            counter++;
            syote += oppilas.getName() + " " + oppilas.getAge().ToString() + Environment.NewLine; ;
            textBox3.Text = syote;

        }

        private void average_button_Click(object sender, EventArgs e)
        {
            float average = 0;
            float ageSum = 0;
            int quantity = 0;
            int i = 0;
            while(arraylist[i] != null)
            {
                ageSum += float.Parse(arraylist[i].getAge());
                quantity++;
                i++;
            }
            average = ageSum / quantity;
            string str = average.ToString() + Environment.NewLine;
            averageBox.Text = str;

        }
    }
}
