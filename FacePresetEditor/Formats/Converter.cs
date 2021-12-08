using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using S3.Formats;

namespace FacePresetEditor.Formats
{
    public static class Converter
    {
        public static void BatchConvertXMLs(string[] infiles, bool s3pe)
        {
            foreach(var element in infiles)
            {
                var wrapper = new FacePresetWrapper();
                XMLFile.Deserialize(element, wrapper);
                var outputName = Path.GetFileNameWithoutExtension(element) + ".compblend";
                if (s3pe)
                    outputName = "S3_051DF2DD_00000000_"+FNV64.GetHash(wrapper.facePreset.name).ToString("X16")+"%%+CBLN.compblend";
                var outputPath = Path.Combine(Path.GetDirectoryName(element), outputName);
                using (BinaryWriter writer = new BinaryWriter(new FileStream(outputPath, FileMode.Create)))
                    CBLNFile.Serialize(writer, wrapper.facePreset);
            }
        }
    }
}
