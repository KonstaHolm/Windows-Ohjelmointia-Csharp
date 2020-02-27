using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_9._2
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int counter = 0;
        bool entryFlag = false;
        


        public Form1()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if(entryFlag = false)
            {
                timer.Interval = 200;
            }
            entryFlag = true;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            Bitmap myImage = new Bitmap(@"C:/Koulu/Windows-ohjelmointi/Materiaaleja-20200107/Media/Media/Duke/"+ counter + ".png");
            pictureBox1.Image = (Image)myImage;
            if(counter == 10)
            {
                counter = 0;
            }
        }

    }
}
