using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "";
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string str2 = e.KeyCode.ToString();
            if (str2.Equals("Space"))
            {
                str2 = " ";
                str = str + str2;
            }
            if(str2.Length == 1)
            {
                str = str + str2;
                textBox1.Text = str;
            }
        }
    }
}
