using System.Media;
using System.Timers;

namespace mvp_djview
{
    public class ModelBo
    {
        private static Timer _timer;

        private double _interval = 500;
        private int _beatsPerSecond;

        public ModelBo()
        {
            _timer = new Timer(Interval);
            _timer.Elapsed += OnTimedEvent;
        }

        public double Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
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
//                OnBeat(new BeatEventArgs(_beatsPerSecond));
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            // Play Beep
            try
            {
                // old XP support
                //Console.Beep(2000, 10);

                // Vista / Windows 7 support
                SystemSounds.Beep.Play();

            }
            catch { } // Do nothing
        }
    }
}
