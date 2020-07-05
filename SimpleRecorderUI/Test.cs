using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    class Test
    {
        public Test()
        {
            TextGrid tg = new TextGrid("abc", 216);
            tg.Save(@"D:\tmp\Audio\ihudodo1.TextGrid");
        }
    }
}
