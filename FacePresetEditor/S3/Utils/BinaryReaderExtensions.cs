using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace S3.Utils
{
    public static class BinaryReaderExtensions
    {
        public static string ReadString(BinaryReader reader)
        {
            var strLen = reader.ReadInt32();
            var str = "";
            for(var i = 0; i < strLen; i++)
            {
                str += BitConverter.ToChar(reader.ReadBytes(2), 0);
            }
            return str;
        }
    }
}
