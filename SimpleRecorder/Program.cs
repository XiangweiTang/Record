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
        }

        static void AddNewUser(byte age, bool gender, string transFilePath, string audioRootFolderPath, string recordFilePath)
        {
            var user = new UserInfo(age, gender);
            string audioFolderPath = Path.Combine(audioRootFolderPath, user.UserId.ToString());
            RecordAudios(transFilePath, audioFolderPath);
            File.AppendAllLines(recordFilePath, new string[] { user.ToString() });
        }

        static void RecordAudios(string transFilePath, string audioFolderPath)
        {
            if (!Directory.Exists(audioFolderPath))
                Directory.CreateDirectory(audioFolderPath);
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
}
