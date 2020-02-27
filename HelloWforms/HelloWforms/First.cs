using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWforms
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "You press Click Me";
        }
    }
}
