using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                                               

        }

        public class Auto
        {

            public Auto()
            {

            }

        }

        public class Kuorma
        {

            public int kuormanPaino;

            public Kuorma(int paino)
            {
                this.kuormanPaino = paino;
            }
        }

        public class KuormaAuto : Auto
        {

            private int vuosimalli;
            private Kuorma lasti;

            public KuormaAuto()
            {

            }

            public void TeeKuorma()
            {
                Kuorma tavarat = new Kuorma(5730);
                this.lasti = tavarat;
            }


        }

    }
}
