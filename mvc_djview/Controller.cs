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

        public void Load()
        {
            _view.BeatPerSecond = _model.BeatsPerSecond;
        }
    }
}
