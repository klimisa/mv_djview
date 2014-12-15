using System;
using System.Windows.Forms;

namespace mvp_djview
{
    public partial class Form1 : Form, IView
    {
        private Presenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            _presenter.Start();
        }

        public int BeatPerMinute { get; set; }
    }
}
