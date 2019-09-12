using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorder
{
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

        public static void MciSet(int bitsPerSample, int channel, int samplesPerSec, int bytesPerSec, int align)
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
