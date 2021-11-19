using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.CAS
{
    public enum PresetType
    {
        Eyes = 1,
        Nose = 2,
        Mouth = 4,
        Face = 128
    }
    public class FacePreset
    {
        public int version = 2;
        public string name = "";
        public PresetType presetType = PresetType.Eyes;
        public int formatFlags = 73744;
        public List<FaceBlendValue> faceBlends = new List<FaceBlendValue>();
    }
}
