using System;
using System.Collections.Generic;
using System.Text;

namespace NAudio.Extras
{
    /// <summary>
    /// イコライザーの要素たち
    /// </summary>
    public class EqualizerBand
    {
        public float Frequency { get; set; }
        public float Gain { get; set; }
        public float Bandwidth { get; set; }
    }
}
