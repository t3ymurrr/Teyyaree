using System;
using System.Media;
using System.Windows.Forms;

namespace Teyyare
{
    public partial class Form1 : Form
    {
        int speed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayAudio(string fileName)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(fileName);
                player.Play();
            }
            catch
            {
            }
        }

        private void btnEnis_Click(object sender, EventArgs e)
        {
            PlayAudio("inishazirliklari.wav");
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            PlayAudio("turbulans.wav");
        }

        private void btnKemerler_Click(object sender, EventArgs e)
        {
            PlayAudio("kemerler.wav");
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            PlayAudio("tesekkurler.wav");
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            PlayAudio("beep.wav");
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            pbLight.Visible = !pbLight.Visible;
            PlayAudio("isikacmakapamasesi.wav");
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            speed += 5;
            if (speed > 0)
            {
                timerPlane.Start();
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            speed -= 5;
            if (speed <= 0)
            {
                speed = 0;
                timerPlane.Stop();
            }
        }

        private void timerPlane_Tick(object sender, EventArgs e)
        {
            pbPlane.Top -= speed;
            pbLight.Top -= speed;

            if (pbPlane.Bottom < 0)
            {
                pbPlane.Top = panelLeft.Height;
                pbLight.Top = pbPlane.Top - 20;
            }
        }
    }
}