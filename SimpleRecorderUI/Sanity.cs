using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    static class Sanity
    {
        public static void Requires(bool b, string message = "")
        {
            if (!b)
                throw new Exception(message);
        }
    }
}
