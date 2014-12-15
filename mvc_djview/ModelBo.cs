using System.Media;
using System.Timers;

namespace mvc_djview
{
    public class ModelBo
    {
        private static Timer _timer;

        private double _interval = 500;

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
