using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using S3.Formats;
using S3.Utils;

namespace FacePresetEditor.Formats
{
    public static class S3FaceTemplateFile
    {
        public const int Version = 1;
        public static void Deserialize(BinaryReader reader, FacePresetWrapper facePreset)
        {
            CBLNFile.Deserialize(reader, facePreset.facePreset);
            var ver = reader.ReadInt32();
            for (var i = 0; i < facePreset.facePreset.faceBlends.Count; i++)
            {
                var elm = new FaceBlendValueMetadata();
                elm.name = BinaryReaderExtensions.ReadString(reader);
                facePreset.faceBlendMetadata.Add(elm);
            }
        }
        public static void Serialize(BinaryWriter writer, FacePresetWrapper facePreset)
        {
            CBLNFile.Serialize(writer, facePreset.facePreset);
            writer.Write(Version);
            foreach(var element in facePreset.faceBlendMetadata)
            {
                BinaryWriterExtensions.WriteString(writer, element.name);
            }
        }
    }
}
