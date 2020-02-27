using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            textBox1.Text = "panel1 MouseEnter";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            textBox1.Text = "panel1 MouseLeave";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            textBox1.Text = "panel1 MouseMove";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            textBox1.Text = "button1 MouseEnter";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            textBox1.Text = "button1 MouseLeave";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            textBox1.Text = "button1 MouseMove";
        }
    }
}
