using System.Globalization;
using System.Windows.Forms;

namespace mvc_djview
{
    public partial class BeatTextBox : TextBox, IBeatable
    {
        public void HandleBeat(PresenterModel sender, BeatEventArgs e)
        {
            Text = e.BeatsPerSecond.ToString(CultureInfo.InvariantCulture);
        }
    }
}
