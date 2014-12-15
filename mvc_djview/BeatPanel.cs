using System.Drawing;
using System.Windows.Forms;

namespace mvc_djview
{
    public partial class BeatPanel : Panel, IBeatable
    {
        public void HandleBeat(PresenterModel sender, BeatEventArgs e)
        {
            var red = 255;
            var green = 255 - e.BeatsPerSecond;
            var blue = 0;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
