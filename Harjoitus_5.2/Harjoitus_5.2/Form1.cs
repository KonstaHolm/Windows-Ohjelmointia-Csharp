using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Mammal
        {

            protected string mType = "";
            protected string mName = "";
            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }
            public string Type
            {
                get { return mType; }
                set { mType = value; }
            }

            public Mammal()
            {

            }

            public Mammal(string type)
            {
                mType = type;
            }

            public string GetMType()
            {
                string str = "Object type is " + mType;
                return str;
            }

        }

        public class Person : Mammal
        {

            private int mAge = 0;
            public int Age
           {
                get { return mAge; }
                set { mAge = value; }
           } 

            public Person()
            {
                mType = "PERSON";
            }

        }

        public class Dog : Mammal
        {

            private string mOwner = "";
            public string Owner
            {
                get { return mOwner; }
                set { mOwner = value; }
            }

            public Dog()
            {
                mType = "DOG";
            }

        }

        private void print_button_Click(object sender, EventArgs e)
        {

            Mammal Nisakas = new Mammal("DOG");
            Person Henkilo = new Person();
            Dog Koira = new Dog();

            Nisakas.Name = "Nisakas";
            string testi1 = Nisakas.Name + Environment.NewLine;
            string testi2 = Nisakas.GetMType() + Environment.NewLine;

            Henkilo.Age = 21;
            string testi3 = Henkilo.Age.ToString() + Environment.NewLine;
            string testi4 = Henkilo.GetMType() + Environment.NewLine;
            Henkilo.Name = "Ihminen";
            string testi5 = Henkilo.Name + Environment.NewLine;

            Koira.Owner = "Jussi";
            string testi6 = Koira.Owner + Environment.NewLine;
            string testi7 = Koira.GetMType() + Environment.NewLine;
            Koira.Name = "Koira";
            string testi8 = Koira.Name + Environment.NewLine;
            string syote = testi1 + testi2 + testi3 + testi4 + testi5 + testi6 + testi7 + testi8;

            textBox1.Text = syote;

        }
    }
}
