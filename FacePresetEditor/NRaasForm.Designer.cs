namespace FacePresetEditor
{
    partial class NRaasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NRaasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMCNumber = new System.Windows.Forms.TextBox();
            this.buttonMCOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type in the numeric slider value as provided by NRaas MasterController.\r\n";
            // 
            // textBoxMCNumber
            // 
            this.textBoxMCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMCNumber.Location = new System.Drawing.Point(310, 56);
            this.textBoxMCNumber.Name = "textBoxMCNumber";
            this.textBoxMCNumber.Size = new System.Drawing.Size(156, 30);
            this.textBoxMCNumber.TabIndex = 2;
            // 
            // buttonMCOK
            // 
            this.buttonMCOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMCOK.Location = new System.Drawing.Point(310, 111);
            this.buttonMCOK.Name = "buttonMCOK";
            this.buttonMCOK.Size = new System.Drawing.Size(156, 59);
            this.buttonMCOK.TabIndex = 3;
            this.buttonMCOK.Text = "OK";
            this.buttonMCOK.UseVisualStyleBackColor = true;
            this.buttonMCOK.Click += new System.EventHandler(this.buttonMCOK_Click);
            // 
            // NRaasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMCOK);
            this.Controls.Add(this.textBoxMCNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NRaasForm";
            this.Text = "Set NRaas Numeric Slider Value";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NRaasForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMCNumber;
        private System.Windows.Forms.Button buttonMCOK;
    }
}