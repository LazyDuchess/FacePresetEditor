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
                var rawPresetInt = reader.ReadInt32();
            if (rawPresetInt == 128)
                rawPresetInt = (int)PresetType.Face;
            facePreset.presetType = (PresetType)rawPresetInt;
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
                writer.Write(2);
                BinaryWriterExtensions.WriteString(writer, facePreset.name);
                writer.Write((int)facePreset.presetType);
                writer.Write(73744);
                writer.Write(facePreset.faceBlends.Count);
                foreach(var element in facePreset.faceBlends)
                {
                    writer.Write(element.amount);
                    element.faceBlendTGI.Serialize(writer);
                }
        }
    }
}
