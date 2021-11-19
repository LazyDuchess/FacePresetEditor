using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S3.CAS;
using S3.Common;
using S3.Utils;
using static System.Windows.Forms.ListViewItem;
using System.IO;
using S3.Formats;
using FacePresetEditor.Formats;

namespace FacePresetEditor
{
    public partial class MainForm : Form
    {
        public const int SliderMaxValue = 50;
        public float sliderMultiplyAmount = 1f;
        public MainForm()
        {
            InitializeComponent();
            Program.editorEnvironment = new EditorEnvironment(this);
            comboBoxPresetType.SelectedIndex = 0;
            Program.editorEnvironment.MarkDirty(false);
            trackBarSliderAmount.Maximum = SliderMaxValue;
            trackBarSliderAmount.Minimum = -SliderMaxValue;
        }

        public void InitSliderControls(int selected)
        {
            var am = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].amount;
            var divAm = Math.Ceiling(am);
            if (divAm > sliderMultiplyAmount)
                setMultiply((int)divAm);
            buttonRemoveSlider.Enabled = true;
            flowLayoutPanelSlider.Enabled = true;
            textBoxSliderName.Text = Program.editorEnvironment.openFacePreset.faceBlendMetadata[selected].name;
            textBoxSliderInstance.Text = "0x"+Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].faceBlendTGI.instance.ToString("X16");
            textBoxSliderGroup.Text = "0x" + Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].faceBlendTGI.group.ToString("X8");
            textBoxSliderType.Text = "0x" + Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].faceBlendTGI.type.ToString("X8");
            trackBarSliderAmount.Value = (int)Math.Round(Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].amount*SliderMaxValue/sliderMultiplyAmount);
            numericUpDownSliderAmount.Value = (decimal)Program.editorEnvironment.openFacePreset.facePreset.faceBlends[selected].amount;
        }

        public void DisableSliderControls()
        {
            buttonRemoveSlider.Enabled = false;
            flowLayoutPanelSlider.Enabled = false;
        }

        private void textBoxPresetName_TextChanged(object sender, EventArgs e)
        {
            Program.editorEnvironment.MarkDirty(true);
            Program.editorEnvironment.openFacePreset.facePreset.name = textBoxPresetName.Text;
        }

        private void buttonAddSlider_Click(object sender, EventArgs e)
        {
            var newFaceBlend = new FaceBlendValue();
            newFaceBlend.amount = 0f;
            newFaceBlend.faceBlendTGI = new TGI(EditorEnvironment.DefaultSliderType,EditorEnvironment.DefaultSliderGroup,EditorEnvironment.DefaultSliderInstance);
            Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Add(newFaceBlend);
            var newFaceBlendMetadata = new FaceBlendValueMetadata();
            newFaceBlendMetadata.name = "Unnamed";
            Program.editorEnvironment.openFacePreset.faceBlendMetadata.Add(newFaceBlendMetadata);
            updateSliderList();
            listViewSliders.Select();
            listViewSliders.SelectedIndices.Clear();
            listViewSliders.SelectedIndices.Add(listViewSliders.Items.Count - 1);
            InitSliderControls(listViewSliders.Items.Count-1);
            Program.editorEnvironment.MarkDirty(true);
        }

        public void updateSliderText()
        {
            for (var i = 0; i < listViewSliders.Items.Count; i++)
            {
                var item = listViewSliders.Items[i];
                item.Text = Program.editorEnvironment.openFacePreset.faceBlendMetadata[i].name;
                var amountItem = item.SubItems[1];
                amountItem.Text = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[i].amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
                var tgiItem = item.SubItems[2];
                tgiItem.Text = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[i].faceBlendTGI.ToString();
            }
        }
        public void updateSliderList()
        {
            listViewSliders.Items.Clear();
            for (var i= 0;i<Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Count;i++)
            {
                var item = new ListViewItem();
                item.Text = Program.editorEnvironment.openFacePreset.faceBlendMetadata[i].name;
                var amountItem = new ListViewSubItem();
                amountItem.Text = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[i].amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
                var tgiItem = new ListViewSubItem();
                tgiItem.Text = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[i].faceBlendTGI.ToString();
                item.SubItems.Add(amountItem);
                item.SubItems.Add(tgiItem);
                listViewSliders.Items.Add(item);
            }
        }

        private void buttonRemoveSlider_Click(object sender, EventArgs e)
        {
            Program.editorEnvironment.openFacePreset.facePreset.faceBlends.RemoveAt(listViewSliders.SelectedIndices[0]);
            Program.editorEnvironment.openFacePreset.faceBlendMetadata.RemoveAt(listViewSliders.SelectedIndices[0]);
            var selectionIndex = listViewSliders.SelectedIndices[0];
            listViewSliders.SelectedIndices.Clear();
            updateSliderList();
            if (Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Count <= selectionIndex)
            {

                if (Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Count > 0)
                {
                    listViewSliders.SelectedIndices.Add(Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Count - 1);
                }

            }
            else
                listViewSliders.SelectedIndices.Add(selectionIndex);
            listViewSliders.Select();
            if (listViewSliders.SelectedIndices.Count == 0)
                DisableSliderControls();
            Program.editorEnvironment.MarkDirty(true);
        }

        private void listViewSliders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSliders.SelectedIndices.Count == 0)
                return;
            InitSliderControls(listViewSliders.SelectedIndices[0]);
        }

        int GetSelectedSliderIndex()
        {
            return listViewSliders.SelectedIndices[0];
        }

        FaceBlendValue GetFaceBlend(int index)
        {
            return Program.editorEnvironment.openFacePreset.facePreset.faceBlends[index];
        }

        FaceBlendValueMetadata GetFaceBlendMetadata(int index)
        {
            return Program.editorEnvironment.openFacePreset.faceBlendMetadata[index];
        }

        private void textBoxSliderName_TextChanged(object sender, EventArgs e)
        {
            GetFaceBlendMetadata(GetSelectedSliderIndex()).name = textBoxSliderName.Text;
            updateSliderText();
            Program.editorEnvironment.MarkDirty(true);
        }

        private void trackBarSliderAmount_Scroll(object sender, EventArgs e)
        {
            var floatValue = ((float)trackBarSliderAmount.Value / SliderMaxValue) * sliderMultiplyAmount;
            numericUpDownSliderAmount.Value = (decimal)floatValue;
            GetFaceBlend(GetSelectedSliderIndex()).amount = floatValue;
            updateSliderText();
            Program.editorEnvironment.MarkDirty(true);
        }

        private void numericUpDownSliderAmount_ValueChanged(object sender, EventArgs e)
        {
            var floatValue = (float)numericUpDownSliderAmount.Value;
            trackBarSliderAmount.Value = (int)Math.Round(floatValue * (SliderMaxValue/sliderMultiplyAmount));
            GetFaceBlend(GetSelectedSliderIndex()).amount = floatValue;
            updateSliderText();
            Program.editorEnvironment.MarkDirty(true);
        }

        public void setSliderValue(float val)
        {
            var max = Math.Ceiling(Math.Abs(val));
            if (max > (float)numericUpDownSliderMultiply.Maximum)
            {
                max = (float)numericUpDownSliderMultiply.Maximum;
                val = (float)numericUpDownSliderMultiply.Maximum;
            }
            if (max > sliderMultiplyAmount)
                setMultiply((int)max);
            numericUpDownSliderAmount.Value = (decimal)val;
            trackBarSliderAmount.Value = (int)Math.Round(val * (SliderMaxValue/sliderMultiplyAmount));
            GetFaceBlend(GetSelectedSliderIndex()).amount = val;
            updateSliderText();
            Program.editorEnvironment.MarkDirty(true);
        }

        private void textBoxSliderInstance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetFaceBlend(GetSelectedSliderIndex()).faceBlendTGI.instance = Hex.longFromString(textBoxSliderInstance.Text);
                updateSliderText();
                Program.editorEnvironment.MarkDirty(true);
            }
            catch(Exception ex)
            {

            }
            
        }

        private void textBoxSliderGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetFaceBlend(GetSelectedSliderIndex()).faceBlendTGI.group = Hex.intFromString(textBoxSliderGroup.Text);
                updateSliderText();
                Program.editorEnvironment.MarkDirty(true);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBoxSliderType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetFaceBlend(GetSelectedSliderIndex()).faceBlendTGI.type = Hex.intFromString(textBoxSliderType.Text);
                updateSliderText();
                Program.editorEnvironment.MarkDirty(true);
            }
            catch (Exception ex)
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.editorEnvironment = new EditorEnvironment(this);
            updateEverything();
            Program.editorEnvironment.MarkDirty(false);
        }

        void updateEverything()
        {
            textBoxPresetName.Text = Program.editorEnvironment.openFacePreset.facePreset.name;
            switch(Program.editorEnvironment.openFacePreset.facePreset.presetType)
            {
                case PresetType.Eyes:
                    comboBoxPresetType.SelectedIndex = 0;
                    break;
                case PresetType.Nose:
                    comboBoxPresetType.SelectedIndex = 1;
                    break;
                case PresetType.Mouth:
                    comboBoxPresetType.SelectedIndex = 2;
                    break;
                case PresetType.Face:
                    comboBoxPresetType.SelectedIndex = 3;
                    break;
            }
            DisableSliderControls();
            updateSliderList();
        }

        private void comboBoxPresetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var presetType = PresetType.Eyes;
            switch(comboBoxPresetType.SelectedIndex)
            {
                case 0:
                    presetType = PresetType.Eyes;
                    break;
                case 1:
                    presetType = PresetType.Nose;
                    break;
                case 2:
                    presetType = PresetType.Mouth;
                    break;
                case 3:
                    presetType = PresetType.Face;
                    break;
            }
            Program.editorEnvironment.openFacePreset.facePreset.presetType = presetType;
            Program.editorEnvironment.MarkDirty(true);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var importDialog = new OpenFileDialog();
            importDialog.Filter = "Sims 3 Face Preset Files(*.compblend)|*.compblend|All files(*.*)|*.*";
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                Program.editorEnvironment.openFacePreset = new FacePresetWrapper();
                Program.editorEnvironment.filePath = "";
                Program.editorEnvironment.fileName = Path.GetFileNameWithoutExtension(importDialog.FileName);
                using (BinaryReader reader = new BinaryReader(new FileStream(importDialog.FileName, FileMode.Open)))
                {
                    CBLNFile.Deserialize(reader, Program.editorEnvironment.openFacePreset.facePreset);
                }
                Program.editorEnvironment.openFacePreset.faceBlendMetadata.Clear();
                for(var i=0;i<Program.editorEnvironment.openFacePreset.facePreset.faceBlends.Count;i++)
                {
                    var blendMetadata = new FaceBlendValueMetadata();
                    blendMetadata.name = "Slider " + i.ToString();
                    Program.editorEnvironment.openFacePreset.faceBlendMetadata.Add(blendMetadata);
                }
                updateEverything();
                Program.editorEnvironment.MarkDirty(false);
            }
           
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var importDialog = new SaveFileDialog();
            importDialog.Filter = "Sims 3 Face Preset Files(*.compblend)|*.compblend|All files(*.*)|*.*";
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(importDialog.FileName, FileMode.Create)))
                {
                    CBLNFile.Serialize(writer, Program.editorEnvironment.openFacePreset.facePreset);
                }
            }
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var importDialog = new OpenFileDialog();
            importDialog.Filter = "Preset Editor Files(*.facepreset)|*.facepreset|All files(*.*)|*.*";
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                Program.editorEnvironment.openFacePreset = new FacePresetWrapper();
                using (BinaryReader reader = new BinaryReader(new FileStream(importDialog.FileName, FileMode.Open)))
                {
                    S3FaceTemplateFile.Deserialize(reader, Program.editorEnvironment.openFacePreset);
                }
                Program.editorEnvironment.filePath = importDialog.FileName;
                Program.editorEnvironment.fileName = Path.GetFileNameWithoutExtension(importDialog.FileName);
                updateEverything();
                Program.editorEnvironment.MarkDirty(false);
            }
            
        }

        void Save()
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream(Program.editorEnvironment.filePath, FileMode.Create)))
            {
                S3FaceTemplateFile.Serialize(writer, Program.editorEnvironment.openFacePreset);
            }
            Program.editorEnvironment.MarkDirty(false);
        }

        void SaveAs()
        {
            var exportDialog = new SaveFileDialog();
            exportDialog.Filter = "Preset Editor Files(*.facepreset)|*.facepreset|All files(*.*)|*.*";
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                Program.editorEnvironment.filePath = exportDialog.FileName;
                Program.editorEnvironment.fileName = Path.GetFileNameWithoutExtension(exportDialog.FileName);
                Save();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.editorEnvironment.filePath == "")
                SaveAs();
            else
                Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var nraasForm = new NRaasForm();
            nraasForm.parentForm = this;
            nraasForm.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.editorEnvironment.dirty && Program.editorEnvironment.filePath != "")
                saveToolStripMenuItem.Enabled = false;
            else
                saveToolStripMenuItem.Enabled = true;
        }

        void setMultiply(int amount)
        {
            if (amount > (int)numericUpDownSliderMultiply.Maximum)
                amount = (int)numericUpDownSliderMultiply.Maximum;
            sliderMultiplyAmount = (float)amount;
            numericUpDownSliderMultiply.Value = (decimal)amount;
            updateMultiply();
        }

        void updateMultiply()
        {
            numericUpDownSliderAmount.Maximum = (decimal)sliderMultiplyAmount;
            numericUpDownSliderAmount.Minimum = (decimal)-sliderMultiplyAmount;
        }

        private void numericUpDownSliderMultiply_ValueChanged(object sender, EventArgs e)
        {
            var currentFaceBlend = Program.editorEnvironment.openFacePreset.facePreset.faceBlends[listViewSliders.SelectedIndices[0]];
            
            sliderMultiplyAmount = (float)numericUpDownSliderMultiply.Value;
            if (Math.Abs(currentFaceBlend.amount) > sliderMultiplyAmount)
                currentFaceBlend.amount = sliderMultiplyAmount;
            updateMultiply();
            trackBarSliderAmount.Value = (int)(currentFaceBlend.amount * SliderMaxValue / sliderMultiplyAmount);
            numericUpDownSliderAmount.Value = (decimal)currentFaceBlend.amount;
        }
    }
}
