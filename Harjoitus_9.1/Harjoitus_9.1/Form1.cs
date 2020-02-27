using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Harjoitus_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Koulu\Windows-ohjelmointi\Materiaaleja-20200107\Media\Media\Animals4\bear.wav");
            splayer.Play();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Koulu\Windows-ohjelmointi\Materiaaleja-20200107\Media\Media\Animals4\elephant.wav");
            splayer.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Koulu\Windows-ohjelmointi\Materiaaleja-20200107\Media\Media\Animals4\lamb.wav");
            splayer.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Koulu\Windows-ohjelmointi\Materiaaleja-20200107\Media\Media\Animals4\wolf.wav");
            splayer.Play();
        }
    }
}
