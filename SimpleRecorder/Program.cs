using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorder
{
    class Program
    {
        static void Main(string[] args)
        {
            string transFilePath = @"C:\Users\v-xianta\Documents\tmp\Trans.txt";
            string audioFolderPath = @"C:\Users\v-xianta\Documents\tmp\Audio";
            RecordAudios(transFilePath, audioFolderPath);
        }

        static void RecordAudios(string transFilePath, string audioFolderPath)
        {
            int id = 0;
            foreach(string trans in File.ReadLines(transFilePath))
            {
                RecordSingleAudio(trans, id.ToString(), audioFolderPath);
                id++;
            }
        }

        static void RecordSingleAudio(string trans, string id, string audioFolderPath)
        {
            Console.WriteLine("Please read the following sentence, press any key to start recording.");
            Console.WriteLine($"\t{trans}");
            Console.ReadLine();

            MciCommands.Alias = "sound";
            MciCommands.filePath= Path.Combine(audioFolderPath, id + ".wav");
            MciCommands.MciOpen();
            MciCommands.MciSet(16, 1, 24000, 48000, 2);
            MciCommands.MciRecord();

            Console.WriteLine("Press any key to stop recording.");
            Console.ReadLine();

            MciCommands.MciSave();
            MciCommands.MciClose();

            Console.WriteLine("*************************************");
        }
    }

    static class MciCommands
    {
        public static string Alias { get; set; } = "";
        public static string filePath { get; set; } = "";
        [DllImport("winmm.dll")]
        extern static void mciSendString(string cmdString, string returnString, int cchReturn, int callBack);
        public static void RunMci(string cmdString)
        {
            mciSendString(cmdString, "", 0, 0);
        }

        public static void MciOpen()
        {
            string cmdString = $"open new type waveaudio alias {Alias}";
            RunMci(cmdString);
        }

        public static void MciSet(int bitsPerSample, int channel, int samplesPerSec,int bytesPerSec, int align)
        {
            string cmdString = $"set {Alias} bitspersample {bitsPerSample} channels {channel} samplespersec {samplesPerSec} bytespersec {bytesPerSec} alignment {align}";
            RunMci(cmdString);
        }

        public static void MciRecord()
        {
            string cmdString = $"record {Alias}";
            RunMci(cmdString);
        }

        public static void MciSave()
        {
            string cmdString = $"save {Alias} {filePath}";
            RunMci(cmdString);
        }

        public static void MciClose()
        {
            string cmdString = $"close {Alias}";
            RunMci(cmdString);
        }
    }
}
