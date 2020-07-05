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
        private string AudioNameCore = "";
        private string LogName = "";
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
            string userAudioFolder= Path.Combine(Cfg.AudioRootPath, UInfo.UserId.ToString());
            if (!Directory.Exists(userAudioFolder))
                Directory.CreateDirectory(userAudioFolder);
            string userLogFolder = Path.Combine(Cfg.RecordRootPath, UInfo.UserId.ToString());
            if (!Directory.Exists(userLogFolder))
                Directory.CreateDirectory(userLogFolder);
            LogName = Path.Combine(userLogFolder, TrOp.CurrrentIndex + ".txt");
            // HACK: now we only use single file mode.
            //NameCore= Path.Combine(userFolder, $"{TrOp.CurrrentIndex.ToString("0000")}_{DateTime.Now.ToString("yyyyMMddhhmmss")}");
            AudioNameCore = Path.Combine(userAudioFolder, $"{TrOp.CurrrentIndex.ToString("0000")}");
            SaveToWav();
            SaveToLog();
            SaveToTextGrid();
        }        

        private void SaveToWav()
        {
            MciCommands.FilePath = AudioNameCore + ".wav";
            if (File.Exists(MciCommands.FilePath))
                File.Delete(MciCommands.FilePath);
            MciCommands.MciSave();
            MciCommands.MciClose();
        }

        private void SaveToLog()
        {
            string info = $"{ UInfo}\t{TrOp.CurrrentIndex}\t{TrOp.CurrentTrans}\t{MciCommands.FilePath}";
            File.WriteAllText(LogName, info);
        }
        private void SaveToTextGrid()
        {
            long audioFileLength = new FileInfo(MciCommands.FilePath).Length;
            double audioLength = 1.0 * audioFileLength / Cfg.BytesPerSecond;
            TextGrid tg = new TextGrid(TrOp.CurrentTrans, audioLength);
            tg.Save(AudioNameCore + ".TextGrid");
        }
    }
}
