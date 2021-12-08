using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Utils
{
    public static class Hex
    {
        public static uint uintFromString(string str)
        {
            return Convert.ToUInt32(str, 16);
        }

        public static ulong ulongFromString(string str)
        {
            return Convert.ToUInt64(str, 16);
        }
    }
}
