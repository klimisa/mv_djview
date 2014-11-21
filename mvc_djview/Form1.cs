using System;
using System.Globalization;
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

        public int BeatPerSecond
        {
            get { return Convert.ToInt32(txtBPM.Text); }
            set { txtBPM.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public int CurrentBeatPerSecond
        {
            get { return Convert.ToInt32(txtCurrentBPM.Text); }
            set { txtBPM.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controller.Load();
        }
    }
}
