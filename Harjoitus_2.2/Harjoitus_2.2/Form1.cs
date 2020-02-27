using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Harjoitus 2.2";
        }

        public class NumberGame
        {
            private int number1 = 3;
            private int number2 = 10;
            private int number3 = 44;

            public NumberGame()
            {
            }

            public int GetNumber1()
            {
                return number1;
            }
            public int GetNumber2()
            {
                return number2;
            }
            public int GetNumber3()
            {
                return number3;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberGame peli = new NumberGame();
            
            int numero1 = peli.GetNumber1();
            int numero2 = peli.GetNumber2();
            int numero3 = peli.GetNumber3();

            string vastaus1 = numero1.ToString();
            string vastaus2 = numero2.ToString();
            string vastaus3 = numero3.ToString();


            if (textBox5.Text.Equals(vastaus1) && textBox6.Text.Equals(vastaus2) && textBox7.Text.Equals(vastaus3))
            {
                textBox8.Text = "Your answer was correct!";
            } else
            {
                textBox8.Text = "Your answer was wrong!";
            }

            int value1;
            if(int.TryParse(textBox5.Text, out value1))
            {
                if(value1 > 100 || value1 < 0)
                {
                    MessageBox.Show("Value1 is not between 0-99!\nPlease re-enter new value(s)");
                }
            }

            int value2;
            if (int.TryParse(textBox6.Text, out value2))
            {
                if (value2 > 100 || value2 < 0)
                {
                    System.Windows.Forms.MessageBox.Show("Value2 is not between 0-99!\nPlease re-enter new value(s)");
                }
            }

            int value3;
            if (int.TryParse(textBox7.Text, out value3))
            {
                if (value3 > 100 || value3 < 0)
                {
                    System.Windows.Forms.MessageBox.Show("Value3 is not between 0-99!\nPlease re-enter new value(s)");
                }
            }

            int valid1;
            if (!int.TryParse(textBox5.Text, out valid1))
            {

                System.Windows.Forms.MessageBox.Show("Value1 is not integer!\nPlease re-enter new value(s)");

            }

            int valid2;
            if (!int.TryParse(textBox6.Text, out valid2))
            {
                
                System.Windows.Forms.MessageBox.Show("Value2 is not integer!\nPlease re-enter new value(s)");

            }

            int valid3;
            if (!int.TryParse(textBox7.Text, out valid3))
            {

                System.Windows.Forms.MessageBox.Show("Value3 is not integer!\nPlease re-enter new value(s)");

            }

        }
    }
}
