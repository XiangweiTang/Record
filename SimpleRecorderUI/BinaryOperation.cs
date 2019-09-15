using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleRecorderUI
{
    static partial class Common
    {
        public static byte[] ReadBytes(string filePath, int offset, int length)
        {
            using(FileStream fs=new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Sanity.Requires(fs.Length >= offset + length, "File length error.");
                fs.Seek(offset, SeekOrigin.Begin);
                using(BinaryReader br=new BinaryReader(fs))
                {                    
                    return br.ReadBytes(length);
                }                
            }
        }

        public static void WriteBytes(string filePath, byte[] bytes, int offset)
        {
            using(FileStream fs=new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                Sanity.Requires(fs.Length > offset + bytes.Length, "File length error.");
                fs.Seek(offset, SeekOrigin.Begin);
                using(BinaryWriter br=new BinaryWriter(fs))
                {
                    br.Write(bytes);
                }
            }
        }

        public static void AppendBytes(string filePath, byte[] bytes)
        {
            using(FileStream fs=new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
