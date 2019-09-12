using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorderUI
{
    class Config
    {
        private string WorkRootPath = "";
        public string AudioRootPath => Path.Combine(WorkRootPath, "Audios");
        public string TransPath => Path.Combine(WorkRootPath, "Trans.txt");
        public string RecordPath => Path.Combine(WorkRootPath, "Record.txt");
        public int SampleRate { get; set; } = 24000;
        public int Channel { get; set; } = 1;
        public int BitsPerSample { get; set; } = 16;
        public int ByteRate => SampleRate * BlockAlign;
        public int BlockAlign => Channel * BitsPerSample / 8;
        public Config() { }
        public void Load(params string[] args)
        {
            WorkRootPath = args[0];
            SampleRate = int.Parse(args[1]);
            Channel = int.Parse(args[2]);
            BitsPerSample = int.Parse(args[3]);
        }
    }
}
