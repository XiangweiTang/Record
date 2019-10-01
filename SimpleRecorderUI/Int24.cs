using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    public static class Int24
    {
        public static int FromBytes(byte[] bytes, int offset)
        {
            Sanity.Requires(bytes.Length >= offset + 3, "Int24 parse error, index out of boundary.");
            int n = (bytes[offset]) | (bytes[offset + 1] << 8) | (bytes[offset + 2] << 16);
            if (n <= Constants.INT24_MAX_VALUE)
                return n;
            return n - Constants.INT24_MOD;
        }
    }
}
