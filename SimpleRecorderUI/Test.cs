using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorderUI
{
    class Test
    {
        public Test()
        {
            string audioPath = @"D:\Tmp\Audio\Work\Audios\1\0002_20190930095431.wav";
            string path = @"D:\Tmp\Audio\bin1.txt";
            Wave w = new Wave();
            w.DeepParse(audioPath);
            File.WriteAllLines(path, w.ToDouble().Select(x => x.ToString()));
        }
    }
}
