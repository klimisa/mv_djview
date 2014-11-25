using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mvc_djview
{
    public partial class BeatTextBox : TextBox, IBeatable
    {
        public void HandleBeat(Model sender, BeatEventArgs e)
        {
            Text = e.BeatsPerSecond.ToString(CultureInfo.InvariantCulture);
        }
    }
}
