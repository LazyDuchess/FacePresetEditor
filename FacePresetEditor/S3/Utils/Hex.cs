using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Utils
{
    public static class Hex
    {
        public static int intFromString(string str)
        {
            return Convert.ToInt32(str, 16);
        }

        public static long longFromString(string str)
        {
            return Convert.ToInt64(str, 16);
        }
    }
}
