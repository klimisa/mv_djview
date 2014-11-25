namespace mvc_djview
{
    public interface IBeatable
    {
        void HandleBeat(Model sender, BeatEventArgs e);
    }
}