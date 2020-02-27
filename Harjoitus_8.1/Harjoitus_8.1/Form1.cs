using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            linkLabel1.AutoSize = true;
            linkLabel1.Text = "Visit iltasanomat";
            this.Text = "Iltasanomat linkki";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.iltasanomat.fi");

        }
    }
}
