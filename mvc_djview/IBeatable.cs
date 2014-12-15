namespace mvc_djview
{
    public interface IBeatable
    {
        void HandleBeat(PresenterModel sender, BeatEventArgs e);
    }
}