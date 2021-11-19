using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacePresetEditor
{
    public partial class NRaasForm : Form
    {
        public MainForm parentForm;
        public NRaasForm()
        {
            InitializeComponent();
        }

        private void buttonMCOK_Click(object sender, EventArgs e)
        {
            var parsedInt = 0;
            if (int.TryParse(textBoxMCNumber.Text, out parsedInt))
            {
                var finalFloat = (float)parsedInt / 256f;
                parentForm.setSliderValue(finalFloat);
            }
            this.Close();
        }

        private void NRaasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
