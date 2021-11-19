using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacePresetEditor
{
    //TODO - Move Form specific stuff to the form code, doesn't make sense here.
    public class EditorEnvironment
    {
        public const string DefaultSliderInstance = "0x0000000000000000";
        public const string DefaultSliderGroup = "0x00000000";
        public const string DefaultSliderType = "0x0358B08A";

        public string filePath = "";
        public string fileName = "Untitled";
        public FacePresetWrapper openFacePreset = new FacePresetWrapper();
        public bool dirty = false;
        public Form form = null;

        public void MarkDirty(bool dirty)
        {
            this.dirty = dirty;
            UpdateTitle();
        }
        public void UpdateTitle()
        {
            if (form == null)
                return;
            form.Text = "Face Preset Editor - " + fileName;
            if (dirty)
                form.Text += "*";
        }
        public EditorEnvironment(Form form = null)
        {
            this.form = form;
            UpdateTitle();
        }
    }
}
