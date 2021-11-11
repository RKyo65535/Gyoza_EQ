using System;
using NAudio.Wave;
using NAudio.Extras;

namespace AIUEO_EQ
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("wavファイルへのパスを入力してください。(拡張子は抜きで)");
            string originalFileName =  Console.ReadLine();
            
            //あいうえお分の5こ
            AudioFileReader[] reader = new AudioFileReader[StaticParamaters.AIUEONum];

            try
            {
                for(int i=0;i< StaticParamaters.AIUEONum; i++)
                {
                    //ファイル読みこみ
                    reader[i] = new AudioFileReader(originalFileName+".wav");

                }
            }
            catch(Exception e)
            {

            }

            if (reader == null)
            {
                Console.WriteLine("読み込みに失敗しました。");
                return -1;
            }



            //良い感じにいイコライズしてくれる奴
            Equalizer[] equalizers = new Equalizer[StaticParamaters.AIUEONum];
            //ファイル名の決定
            string[] filenames =
            {
                originalFileName + "_A.wav" ,
                originalFileName + "_I.wav",
                originalFileName + "_U.wav",
                originalFileName + "_E.wav",
                originalFileName + "_O.wav"
            };

            //ここでファイルの生成
            for (int i = 0; i < StaticParamaters.AIUEONum; i++)
            {
                equalizers[i] = new Equalizer(reader[i], StaticParamaters.band[i]);
                WaveFileWriter.CreateWaveFile16(filenames[i],equalizers[i]);
            }


            //成功
            Console.WriteLine("成功しました。");
            return 1;

        }
    }
}
