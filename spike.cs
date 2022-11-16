using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace TopDownGame
{
    class spike
    {
        public int direction;
        public int spikeLeft;
        public int spikeTop;
        
        private int speed = 20;
        private PictureBox Spike = new PictureBox();
        private Timer spikeTimer = new Timer();

        // tao Spike, tham chieu toi form 
        public void MakeBullet(Form form)
        {
            // set thuoc tinh cho hinh anh cua Spike
            Spike.BackColor = Color.Transparent;
            Spike.SizeMode = PictureBoxSizeMode.StretchImage;
            Spike.Size =new Size (16,16);
            Spike.Image = Properties.Resources.saw;
            Spike.Tag = "spike";
            Spike.Left = spikeLeft;
            Spike.Top = spikeTop;
          
            // them hinh anh vao form
            form.Controls.Add(Spike);
            Spike.BringToFront();
            // khoi tao timer cho Spike
            spikeTimer.Interval = speed;
            spikeTimer.Tick += new EventHandler(SpikeTimerEvent);
            spikeTimer.Start();

        }
        // 
        private void SpikeTimerEvent(object sender, EventArgs e)
        {

            if (direction == 3)
            {
                Spike.Left -= speed;
            }

            if (direction == 4)
            {
                Spike.Left += speed;
            }

            if (direction == 1)
            {
                Spike.Top -= speed;
            }

            if (direction == 2)
            {
                Spike.Top += speed;
            }
          
            // huy hinh anh khi ra khoi tam nhin
            if (Spike.Left < 10 || Spike.Left > 950 || Spike.Top < 10 || Spike.Top > 600)
            {
                spikeTimer.Stop();
                spikeTimer.Dispose();
                Spike.Dispose();
                spikeTimer = null;
                Spike = null;
            }



        }



    }
}

