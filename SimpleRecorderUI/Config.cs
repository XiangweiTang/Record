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
        // SampleRate   4   0   4
        // Channel  2   4   6
        // BitsPerSample    2   6   8
        // TransPathHeader  4   8   12
        // TransPath(Unicode)   512 12  524
        // WorkPathHeader   4   524 528
        // WorkPath(Unicode)    528 512  1040
        const int BYTE_LENGTH = 4 + 2 + 2 + 4 + 512 + 4 + 512;
        public bool SettingExists => File.Exists(SettingPath);
        private string SettingPath = @"setting.bin";
        public string WorkRootPath { get; set; } = "";
        public string AudioRootPath => Path.Combine(WorkRootPath, "Audios");
        public string TransPath { get; set; } = "";
        public string RecordPath => Path.Combine(WorkRootPath, "Record.txt");        
        public int SampleRate { get; set; } = 24000;
        public short Channel { get; set; } = 1;
        public short BitsPerSample { get; set; } = 16;
        public int ByteRate => SampleRate * BlockAlign;
        public int BlockAlign => Channel * BitsPerSample / 8;
        public int BytesPerSecond = 1;
        public Config() { }
        public void LoadWithInput(params string[] args)
        {
            WorkRootPath = args[0];
            if (string.IsNullOrWhiteSpace(WorkRootPath))
                WorkRootPath = @".\";
            TransPath = args[1].Trim('"');
            if (string.IsNullOrWhiteSpace(TransPath))
                TransPath = "";

            try { SampleRate = int.Parse(args[2]); }
            catch { SampleRate = 16000; }

            try { Channel = short.Parse(args[3]); }
            catch { Channel = 1; }

            try { BitsPerSample = short.Parse(args[4]); }
            catch { BitsPerSample = 16; }
            BytesPerSecond = SampleRate * Channel * BitsPerSample / 8;
        }        

        public void LoadFromFile()
        {
            var bytes = File.ReadAllBytes(SettingPath);
            SampleRate = BitConverter.ToInt32(bytes, 0);
            Channel = BitConverter.ToInt16(bytes, 4);
            BitsPerSample = BitConverter.ToInt16(bytes, 6);
            int workPathLength = BitConverter.ToInt32(bytes, 8);            
            WorkRootPath = Encoding.Unicode.GetString(bytes, 12, workPathLength);
            int transPathLength = BitConverter.ToInt32(bytes, 524);
            TransPath = Encoding.Unicode.GetString(bytes, 528, transPathLength);
        }

        public void SaveToFile()
        {
            byte[] bytes = new byte[BYTE_LENGTH];
            File.WriteAllBytes(SettingPath, bytes);
            Common.WriteBytes(SettingPath, BitConverter.GetBytes(SampleRate), 0);
            Common.WriteBytes(SettingPath, BitConverter.GetBytes(Channel), 4);
            Common.WriteBytes(SettingPath, BitConverter.GetBytes(BitsPerSample), 6);
            Common.WriteBytes(SettingPath, BitConverter.GetBytes(WorkRootPath.Length * 2), 8);
            Common.WriteBytes(SettingPath, Encoding.Unicode.GetBytes(WorkRootPath), 12);
            Common.WriteBytes(SettingPath, BitConverter.GetBytes(TransPath.Length * 2), 524);
            Common.WriteBytes(SettingPath, Encoding.Unicode.GetBytes(TransPath), 528);
        }
    }
}
