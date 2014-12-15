using System;
using System.Windows.Forms;

namespace mvc_djview
{
    public partial class Form1 : Form
    {
        private readonly Controller _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new Controller(this);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            _controller.BeatPerSecond = int.Parse(txtBPM.Text);
            _controller.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _controller.Stop();
        }

        private void trkBeat_Scroll(object sender, EventArgs e)
        {
            _controller.BeatPerSecond = trkBeat.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controller.Subscriber(pnlColor);
            _controller.Subscriber(txtBPM);
            _controller.Subscriber(txtCurrentBPM);
            
        }
    }
}
