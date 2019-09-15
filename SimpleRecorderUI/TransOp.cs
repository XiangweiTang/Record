using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorderUI
{
    class TransOp
    {
        public string CurrentTrans => TransArray[CurrrentIndex];
        public readonly string[] TransArray = new string[1] { "" };
        public int CurrrentIndex { get; private set; } = 0;
        public TransOp(string transPath)
        {
            if (File.Exists(transPath))
                TransArray = File.ReadAllLines(transPath);
            if (TransArray.Length == 0)
                TransArray = new string[1] { "" };
        }

        public void ChangeIndex(int i)
        {
            CurrrentIndex += i;
            ValidateIndex();
        }

        public void SetIndex(int i)
        {
            CurrrentIndex = i;
            ValidateIndex();
        }

        private void ValidateIndex()
        {
            if (CurrrentIndex >= TransArray.Length)
                CurrrentIndex = TransArray.Length - 1;
            if (CurrrentIndex < 0)
                CurrrentIndex = 0;
        }
    }
}
