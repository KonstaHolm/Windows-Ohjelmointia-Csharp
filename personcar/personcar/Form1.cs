using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person first; Car firstCar;
            firstCar = new Car(); 
            firstCar.Model = "Volvo"; 
            firstCar.Color = "black"; 
            firstCar.Year = 2014;
            first = new Person("Tom Smith", firstCar);

            textBox1.Text = first.Name + " " + first.MyCar.Model + " " + first.MyCar.Color + " " + first.MyCar.Year;

        }
        public class Person
        {
            public string Name { get; set; }
            public Car MyCar { get; set; }
            public Person(string pname, Car pcar) 
            {
                Name = pname;
                MyCar = pcar;
            }
        }
    }
}
