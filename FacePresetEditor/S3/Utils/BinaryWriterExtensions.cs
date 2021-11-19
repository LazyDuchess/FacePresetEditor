using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace S3.Utils
{
    public static class BinaryWriterExtensions
    {
        public static void WriteString(BinaryWriter writer, string str)
        {
            writer.Write(str.Length);
            writer.Write(Encoding.Unicode.GetBytes(str));
        }
    }
}
