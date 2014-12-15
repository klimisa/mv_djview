namespace mvc_djview
{
    public class PresenterModel
    {
        public delegate void BeatChangedHandler<T>(T sender, BeatEventArgs e);
        public event BeatChangedHandler<PresenterModel> BeatChanged;

        private int _beatsPerSecond = 120;

        private readonly ModelBo _timer;

        private double _interval;

        public PresenterModel()
        {
            _timer = new ModelBo();
        }

        public int BeatsPerSecond
        {
            get { return _beatsPerSecond; }
            set
            {
                _beatsPerSecond = value;
                _interval = (60D * 1000) / _beatsPerSecond;
                _timer.Interval = _interval;

                // Fire BeatChanged Event
                OnBeat(new BeatEventArgs(_beatsPerSecond));
            }
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void OnBeat(BeatEventArgs args)
        {
            //fire event BeatChanged
            if (BeatChanged != null)
                BeatChanged(this, args);
        }

        public void Subscribe(IBeatable beatable)
        {
            BeatChanged += beatable.HandleBeat;
        }

        public void Unsubscribe(IBeatable beatable)
        {
            BeatChanged -= beatable.HandleBeat;
        }
    }
}
