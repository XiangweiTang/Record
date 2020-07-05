using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    class TextGrid
    {
        string currentTextGrid;
        public TextGrid(string text, double length)
        {
            currentTextGrid = string.Format(Common.TextGridTemplate, length, text);
        }
        public void Save(string path)
        {
            File.WriteAllText(path, currentTextGrid);
        }
    }
}
