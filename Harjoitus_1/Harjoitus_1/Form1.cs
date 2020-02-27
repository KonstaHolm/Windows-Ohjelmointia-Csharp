using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(textBoxInput.Text, out a);

            if (a == 1)
            {
                labelResult.Text = "You won a new boat!!!";
            } 
            else if (a == 2)
            {
                labelResult.Text = "You won 1000€!!!";
            }
            else if (a == 3)
            {
                labelResult.Text = "You won a new house!!!";
            }
            else if (a != 1 || a != 2 || a != 3)
            {
                labelResult.Text = "Unknown selection!";
            }
            
        }
    }
}
