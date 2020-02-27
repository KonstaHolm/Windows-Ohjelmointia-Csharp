using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mammal Nisakas = new Mammal();
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
