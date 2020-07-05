using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorderUI
{
    class Backend
    {
        public Config Cfg { get; set; } = null;
        public UserInfo UInfo { get; set; } = null;
        public TransOp TrOp { get; set; } = null;
        private string NameCore = "";
        public Backend()
        {
        }
        public void StartRecord()
        {
            MciCommands.MciOpen();
            MciCommands.MciSet(Cfg.BitsPerSample, Cfg.Channel, Cfg.SampleRate, Cfg.ByteRate, Cfg.BlockAlign);
            MciCommands.MciRecord();
        }

        public void EndRecord()
        {
            string userFolder= Path.Combine(Cfg.AudioRootPath, UInfo.UserId.ToString());
            if (!Directory.Exists(userFolder))
                Directory.CreateDirectory(userFolder);
            NameCore= Path.Combine(userFolder, $"{TrOp.CurrrentIndex.ToString("0000")}_{DateTime.Now.ToString("yyyyMMddhhmmss")}");
            SaveToWav();
            SaveToLog();
            SaveToTextGrid();
        }        

        private void SaveToWav()
        {
            MciCommands.FilePath = NameCore + ".wav";
            MciCommands.MciSave();
            MciCommands.MciClose();
        }

        private void SaveToLog()
        {
            string info = $"{ UInfo.ToString()}\t{TrOp.CurrrentIndex}\t{TrOp.CurrentTrans}\t{MciCommands.FilePath}";
            File.AppendAllLines(Cfg.RecordPath, new string[] { info });
        }
        private void SaveToTextGrid()
        {
            long audioFileLength = new FileInfo(MciCommands.FilePath).Length;
            double audioLength = 1.0 * audioFileLength / Cfg.BytesPerSecond;
            TextGrid tg = new TextGrid(TrOp.CurrentTrans, audioLength);
            tg.Save(NameCore + ".TextGrid");
        }
    }
}
