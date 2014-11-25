using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mvc_djview
{
    public class Controller
    {
        private readonly Form1 _view;
        private readonly Model _model;

        public Controller(Form1 view)
        {
            _view = view;
            _model = new Model();
        }

        public int BeatPerSecond
        {
            get { return _model.BeatsPerSecond; }
            set { _model.BeatsPerSecond = value; }
        }

        public void Subscriber(IBeatable beatable)
        {
            _model.Subscribe(beatable);
        }

        public void Unsubscribe(IBeatable beatable)
        {
            _model.Unsubscribe(beatable);
        }

        public void Stop()
        {
            _model.Stop();
        }

        public void Start()
        {
            _model.Start();
        }
    }
}
