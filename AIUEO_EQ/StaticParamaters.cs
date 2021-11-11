using NAudio.Extras;


namespace AIUEO_EQ
{
    class StaticParamaters
    {
        public static int AIUEONum = 5;

        public static float minusBand = 10; 
        public static float plusBand = 5f;

        static float minusGain = -45;
        static float f1Gain = 30;
        static float f2Gain = 25;
        static float f3Gain = 20;
        static float f4Gain = 15;

        //f1    f2    f3      f4
        //あいうえおの順番に
        //800   1200  2500    3500
        //300   2300  2900    3500
        //300   1200  2500    3500
        //500   1900  2500    3500
        //500   800   2500    3500

        public static EqualizerBand[][] band = new EqualizerBand[][]
        {
            //あ
            new EqualizerBand[]
            {
                new EqualizerBand {Bandwidth = minusBand, Frequency = 100, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 200, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 400, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 800, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 1200, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 2400, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 4800, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 9600, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 19200, Gain = minusGain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 800, Gain =f1Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 1200, Gain =f2Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2500, Gain =f3Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 3500, Gain =f4Gain},
            },
            //い
            new EqualizerBand[]
            {
                new EqualizerBand {Bandwidth = minusBand, Frequency = 100, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 200, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 400, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 800, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 1200, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 2400, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 4800, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 9600, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 19200, Gain = minusGain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 300, Gain =f1Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2300, Gain =f2Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2900, Gain =f3Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 3500, Gain =f4Gain},
            },
            //う
            new EqualizerBand[]
            {
                new EqualizerBand {Bandwidth = minusBand, Frequency = 100, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 200, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 400, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 800, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 1200, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 2400, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 4800, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 9600, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 19200, Gain = minusGain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 400, Gain =f1Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 1200, Gain =f2Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2500, Gain =f3Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 3500, Gain =f4Gain},
            },
            //え
            new EqualizerBand[]
            {
                new EqualizerBand {Bandwidth = minusBand, Frequency = 100, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 200, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 400, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 800, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 1200, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 2400, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 4800, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 9600, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 19200, Gain = minusGain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 500, Gain =f1Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 1900, Gain =f2Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2500, Gain =f3Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 3500, Gain =f4Gain},
            },
            //お
            new EqualizerBand[]
            {
                new EqualizerBand {Bandwidth = minusBand, Frequency = 100, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 200, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 400, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 800, Gain =minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 1200, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 2400, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 4800, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 9600, Gain = minusGain},
                new EqualizerBand {Bandwidth = minusBand, Frequency = 19200, Gain = minusGain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 500, Gain =f1Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 800, Gain =f2Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 2500, Gain =f3Gain},
                new EqualizerBand {Bandwidth = plusBand, Frequency = 3500, Gain =f4Gain},
            },
        };


    }
}
