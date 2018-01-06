using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLable.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("MMM:dd:yyyy");
            weekdayLabel.Text = DateTime.Now.ToString("dddd");

            if (hourMinuteLable.Text == "16:20")
            {
                wplayer.URL = @"C:\Users\Michael\Source\Repos\Clock\Clock\bin\Debug\BobMarley-DontWorryBeHappy.mp3";
                wplayer.controls.play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
