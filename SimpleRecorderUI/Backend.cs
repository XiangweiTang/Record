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
        Config Cfg = null;
        public UserInfo UI { get; set; } = null;
        public TransOp TrOp { get; set; } = null;
        public Backend(Config cfg, UserInfo ui, TransOp trOp)
        {
            Cfg = cfg;
            UI = ui;
            TrOp = trOp;
        }

        public void StartRecord()
        {
            MciCommands.MciOpen();
            MciCommands.MciSet(Cfg.BitsPerSample, Cfg.Channel, Cfg.SampleRate, Cfg.ByteRate, Cfg.BlockAlign);
            MciCommands.MciRecord();
        }

        public void EndRecord()
        {
            string userFolder= Path.Combine(Cfg.AudioRootPath, UI.UserGuid.ToString());
            if (!Directory.Exists(userFolder))
                Directory.CreateDirectory(userFolder);
            MciCommands.FilePath = Path.Combine(userFolder, $"{TrOp.CurrrentIndex.ToString("0000")}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.wav");
            MciCommands.MciSave();
            MciCommands.MciClose();
            string info = $"{ UI.ToString()}\t{TrOp.CurrrentIndex}\t{TrOp.TransArray[TrOp.CurrrentIndex]}\t{MciCommands.FilePath}";
            File.AppendAllLines(Cfg.RecordPath, new string[] { info });
        }        
    }
}
