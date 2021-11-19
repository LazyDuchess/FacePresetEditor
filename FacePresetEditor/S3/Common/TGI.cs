using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using S3.Utils;

namespace S3.Common
{
    public class TGI
    {
        public long instance;
        public int type;
        public int group;
        public override string ToString()
        {
            var insHexValue = "0x"+instance.ToString("X16");
            var typeHexValue = "0x"+type.ToString("X8");
            var groupHexValue = "0x"+group.ToString("X8");
            return typeHexValue + "-" + groupHexValue + "-" + insHexValue;
        }

        public TGI()
        {

        }
        public TGI(string type, string group, string instance)
        {
            this.type = Hex.intFromString(type);
            this.group = Hex.intFromString(group);
            this.instance = Hex.longFromString(instance);
        }

        public TGI Deserialize(BinaryReader reader)
        {
                var buffer = reader.ReadBytes(16);
                Deserialize(buffer);
            return this;
        }

        public TGI Deserialize(byte[] data)
        {
            this.instance = BitConverter.ToInt64(data, 0);
            this.group = BitConverter.ToInt32(data, 8);
            this.type = BitConverter.ToInt32(data, 12);
            return this;
        }

        public TGI Serialize(BinaryWriter writer)
        {
            writer.Write(Serialize());
            return this;
        }

        public byte[] Serialize()
        {
            var serializedBytes = new byte[16];
            var instanceBytes = BitConverter.GetBytes(instance);
            var groupBytes = BitConverter.GetBytes(group);
            var typeBytes = BitConverter.GetBytes(type);
            instanceBytes.CopyTo(serializedBytes, 0);
            groupBytes.CopyTo(serializedBytes, 8);
            typeBytes.CopyTo(serializedBytes, 12);
            return serializedBytes;
        }
    }
}
