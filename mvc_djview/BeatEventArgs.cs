using System;

namespace mvc_djview
{
    public class BeatEventArgs: EventArgs
    {
        public int BeatsPerSecond { get; private set; }

        public BeatEventArgs(int beatsPerSecond)
        {
            BeatsPerSecond = beatsPerSecond;
        }
    }
}