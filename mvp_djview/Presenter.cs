using System.Net.Configuration;

namespace mvp_djview
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly ModelBo _model = new ModelBo();
        private int _bpm = 120;

        public Presenter(IView view)
        {
            _view = view;
        }

        public int BeatPerMinute
        {
            get { return _bpm; }
            set
            {
                _bpm = value;
                _model.Interval = _bpm;
                //foreach (IBeatable beatable in _view.Beatables)
                //{
                //    beatable.
                //}
            }
        }

        public void Start()
        {
            _model.Start();
        }

        public void Stop()
        {
            _model.Stop();
        }
    }
}
