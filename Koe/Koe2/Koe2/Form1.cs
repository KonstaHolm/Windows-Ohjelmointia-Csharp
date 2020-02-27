using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<IType> shapes = new List<IType>();

        interface IType
        {
            string GetFigType();

        }


        class Ympyra : IType
        {


            public Ympyra()
            {
            }

            public string GetFigType()
            {
                return "Olen ympyrä";
            }
        }

        class Nelio : IType
        {


            public Nelio()
            {
            }

            public string GetFigType()
            {
                return "Minäpäs olen neliö";
            }
        }



        private void ympyraButton_Click(object sender, EventArgs e)
        {
            Ympyra circle = new Ympyra();
            shapes.Add(circle);
        }

        private void NelioButton_Click(object sender, EventArgs e)
        {
            Nelio square = new Nelio();
            shapes.Add(square);
        }

        private void tulostaButton_Click(object sender, EventArgs e)
        {
            string apu = "";
            foreach(IType item in shapes){
                apu = apu + item.GetFigType() + Environment.NewLine;
            }
            textBox1.Text = apu;
        }
    }
}
