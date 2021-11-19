using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S3.CAS;

namespace FacePresetEditor
{
    public class FacePresetWrapper
    {
        public FacePreset facePreset = new FacePreset();
        public List<FaceBlendValueMetadata> faceBlendMetadata = new List<FaceBlendValueMetadata>();
    }
}
