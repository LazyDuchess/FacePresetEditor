using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using S3.CAS;
using S3.Common;
using S3.Utils;

namespace S3.Formats
{
    public static class CBLNFile
    {
        public static void Deserialize(BinaryReader reader, FacePreset facePreset)
        {
                facePreset.version = reader.ReadInt32();
                //facePreset.name = reader.ReadString();
                facePreset.name = BinaryReaderExtensions.ReadString(reader);
                facePreset.presetType = (PresetType)reader.ReadInt32();
                facePreset.formatFlags = reader.ReadInt32();
                var partAmount = reader.ReadInt32();
                for(var i=0;i<partAmount;i++)
                {
                    var part = new FaceBlendValue();
                    part.amount = reader.ReadSingle();
                    part.faceBlendTGI = new TGI().Deserialize(reader);
                    facePreset.faceBlends.Add(part);
                }
        }

        public static void Serialize(BinaryWriter writer, FacePreset facePreset)
        {
                writer.Write(facePreset.version);
                BinaryWriterExtensions.WriteString(writer, facePreset.name);
                writer.Write((int)facePreset.presetType);
                writer.Write(facePreset.formatFlags);
                writer.Write(facePreset.faceBlends.Count);
                foreach(var element in facePreset.faceBlends)
                {
                /*
                    var floatBytes = BitConverter.GetBytes(element.amount);
                    floatBytes[0] = 0x0;
                    floatBytes[1] = 0x0;
                    writer.Write(floatBytes);*/
                writer.Write(element.amount);
                    element.faceBlendTGI.Serialize(writer);
                }
        }
    }
}
