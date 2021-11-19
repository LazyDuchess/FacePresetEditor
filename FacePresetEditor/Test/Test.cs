using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FacePresetEditor.Formats;
using S3.CAS;
using S3.Formats;


namespace FacePresetEditor.Test
{
    public static class Test
    {
        public static void RunTest()
        {
            var diag = new OpenFileDialog();
            diag.Title = "Open CBLN File";
            diag.ShowDialog();
            var fWrapper = new FacePresetWrapper();
            fWrapper.facePreset = new FacePreset();
            fWrapper.faceBlendMetadata = new List<FaceBlendValueMetadata>();
            var readStream = new FileStream(diag.FileName, FileMode.Open);
            var reader = new BinaryReader(readStream, System.Text.Encoding.Unicode);
            CBLNFile.Deserialize(reader, fWrapper.facePreset);
            reader.Close();
            for (var i = 0; i < fWrapper.facePreset.faceBlends.Count; i++)
            {
                var metadata = new FaceBlendValueMetadata();
                metadata.name = i.ToString();
                fWrapper.faceBlendMetadata.Add(metadata);
            }
            var diag2 = new SaveFileDialog();
            diag2.Title = "Save S3FaceTemplate File";
            diag2.ShowDialog();
            var writeStream = new FileStream(diag2.FileName, FileMode.Create);
            var writer = new BinaryWriter(writeStream, System.Text.Encoding.Unicode);
            S3FaceTemplateFile.Serialize(writer, fWrapper);
            writer.Close();
        }
    }
}
