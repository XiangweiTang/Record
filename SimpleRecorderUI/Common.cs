using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SimpleRecorderUI
{
    static class Common
    {
        public static string TextGridTemplate { get; }
        static Common()
        {
            string path = "SimpleRecorderUI.Internal.TextGridTemplate.txt";
            TextGridTemplate = ReadEmbedAll(path);
        }
        public static byte[] ReadBytes(string filePath, int length)
        {
            using(FileStream fs=new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int intLength = fs.Length > int.MaxValue ? length : Math.Min(length, (int)fs.Length);
                using(BinaryReader br=new BinaryReader(fs))
                {
                    return br.ReadBytes(intLength);
                }
            }
        }
        public static byte[] ReadBytes(string filePath, int offset, int length)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Sanity.Requires(fs.Length >= offset + length, "File length error.");
                fs.Seek(offset, SeekOrigin.Begin);
                using (BinaryReader br = new BinaryReader(fs))
                {
                    return br.ReadBytes(length);
                }
            }
        }

        public static void WriteBytes(string filePath, byte[] bytes, int offset)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                Sanity.Requires(fs.Length > offset + bytes.Length, "File length error.");
                fs.Seek(offset, SeekOrigin.Begin);
                using (BinaryWriter br = new BinaryWriter(fs))
                {
                    br.Write(bytes);
                }
            }
        }

        public static void AppendBytes(string filePath, byte[] bytes)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public static IEnumerable<string> ReadEmbed(string internalPath)
        {
            Assembly asmb = Assembly.GetExecutingAssembly();
            using(StreamReader sr=new StreamReader(asmb.GetManifestResourceStream(internalPath)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    yield return line;
            }
        }
        public static string ReadEmbedAll(string internalPath)
        {
            Assembly asmb = Assembly.GetExecutingAssembly();
            using (StreamReader sr = new StreamReader(asmb.GetManifestResourceStream(internalPath)))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
