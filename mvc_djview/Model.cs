using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Timers;


namespace mvc_djview
{


    public class Model
    {
        public delegate void BeatChangedHandler<T>(T sender, BeatEventArgs e);
        public event BeatChangedHandler<Model> BeatChanged;

        private static Timer _timer;

        private int _beatsPerSecond = 120;
        private double _interval = 500;

        public Model()
        {
            _timer = new Timer(_interval);
            _timer.Elapsed += OnTimedEvent;
        }

        public int BeatsPerSecond {
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

        private void OnBeat(BeatEventArgs args)
        {
            //fire event BeatChanged
            if (BeatChanged != null)
                BeatChanged(this, args);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
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
