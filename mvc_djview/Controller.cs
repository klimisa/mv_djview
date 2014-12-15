namespace mvc_djview
{
    public class Controller
    {
        private readonly Form1 _view;
        private readonly PresenterModel _presenterModel;

        public Controller(Form1 view)
        {
            _view = view;
            _presenterModel = new PresenterModel();
        }

        public int BeatPerSecond
        {
            get { return _presenterModel.BeatsPerSecond; }
            set { _presenterModel.BeatsPerSecond = value; }
        }

        public void Subscriber(IBeatable beatable)
        {
            _presenterModel.Subscribe(beatable);
        }

        public void Unsubscribe(IBeatable beatable)
        {
            _presenterModel.Unsubscribe(beatable);
        }

        public void Stop()
        {
            _presenterModel.Stop();
        }

        public void Start()
        {
            _presenterModel.Start();
        }
    }
}
