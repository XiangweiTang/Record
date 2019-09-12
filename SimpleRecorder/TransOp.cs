using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorder
{
    class TransOp
    {
        private readonly string[] TransArray = new string[0];
        public static int CurrrentIndex { get; private set; } = 0;
        public TransOp(string transPath)
        {
            TransArray = File.ReadAllLines(transPath);
        }

        public string MoveNext()
        {
            ChangeIndex(1);
            return TransArray[CurrrentIndex];
        }

        public string MovePrevious()
        {
            ChangeIndex(-1);
            return TransArray[CurrrentIndex];
        }

        public string MoveNNext(int n)
        {
            ChangeIndex(n);
            return TransArray[CurrrentIndex];
        }

        public string MoveNPrevious(int n)
        {
            ChangeIndex(-n);
            return TransArray[CurrrentIndex];
        }

        public string JumpToN(int n)
        {
            SetIndex(n);
            return TransArray[CurrrentIndex];
        }

        private void ChangeIndex(int i)
        {
            CurrrentIndex += i;
            ValidateIndex();
        }

        private void SetIndex(int i)
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
