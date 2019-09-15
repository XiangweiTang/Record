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
            string userFolder= Path.Combine(Cfg.AudioRootPath, UInfo.UserGuid.ToString());
            if (!Directory.Exists(userFolder))
                Directory.CreateDirectory(userFolder);
            MciCommands.FilePath = Path.Combine(userFolder, $"{TrOp.CurrrentIndex.ToString("0000")}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.wav");
            MciCommands.MciSave();
            MciCommands.MciClose();
            string info = $"{ UInfo.ToString()}\t{TrOp.CurrrentIndex}\t{TrOp.CurrentTrans}\t{MciCommands.FilePath}";
            File.AppendAllLines(Cfg.RecordPath, new string[] { info });
        }        
    }
}
