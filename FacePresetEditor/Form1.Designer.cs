namespace FacePresetEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPresetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPresetType = new System.Windows.Forms.ComboBox();
            this.listViewSliders = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTGI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanelSlider = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSliderName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSliderInstance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSliderGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSliderType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarSliderAmount = new System.Windows.Forms.TrackBar();
            this.numericUpDownSliderAmount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSliderMultiply = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddSlider = new System.Windows.Forms.Button();
            this.buttonRemoveSlider = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchConvertXMLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSliderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSliderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSliderMultiply)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBoxPresetName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPresetType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(672, 68);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preset Name:";
            // 
            // textBoxPresetName
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxPresetName, true);
            this.textBoxPresetName.Location = new System.Drawing.Point(103, 3);
            this.textBoxPresetName.Name = "textBoxPresetName";
            this.textBoxPresetName.Size = new System.Drawing.Size(552, 22);
            this.textBoxPresetName.TabIndex = 1;
            this.textBoxPresetName.TextChanged += new System.EventHandler(this.textBoxPresetName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preset Type:";
            // 
            // comboBoxPresetType
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxPresetType, true);
            this.comboBoxPresetType.FormattingEnabled = true;
            this.comboBoxPresetType.Items.AddRange(new object[] {
            "Eyes",
            "Nose",
            "Mouth",
            "Face"});
            this.comboBoxPresetType.Location = new System.Drawing.Point(98, 31);
            this.comboBoxPresetType.Name = "comboBoxPresetType";
            this.comboBoxPresetType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPresetType.TabIndex = 3;
            this.comboBoxPresetType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPresetType_SelectedIndexChanged);
            // 
            // listViewSliders
            // 
            this.listViewSliders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSliders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAmount,
            this.columnHeaderTGI});
            this.listViewSliders.HideSelection = false;
            this.listViewSliders.Location = new System.Drawing.Point(13, 123);
            this.listViewSliders.MultiSelect = false;
            this.listViewSliders.Name = "listViewSliders";
            this.listViewSliders.Size = new System.Drawing.Size(672, 199);
            this.listViewSliders.TabIndex = 2;
            this.listViewSliders.UseCompatibleStateImageBehavior = false;
            this.listViewSliders.View = System.Windows.Forms.View.Details;
            this.listViewSliders.SelectedIndexChanged += new System.EventHandler(this.listViewSliders_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Amount";
            this.columnHeaderAmount.Width = 85;
            // 
            // columnHeaderTGI
            // 
            this.columnHeaderTGI.Text = "TGI";
            this.columnHeaderTGI.Width = 354;
            // 
            // flowLayoutPanelSlider
            // 
            this.flowLayoutPanelSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelSlider.Controls.Add(this.label3);
            this.flowLayoutPanelSlider.Controls.Add(this.textBoxSliderName);
            this.flowLayoutPanelSlider.Controls.Add(this.label6);
            this.flowLayoutPanelSlider.Controls.Add(this.textBoxSliderInstance);
            this.flowLayoutPanelSlider.Controls.Add(this.label7);
            this.flowLayoutPanelSlider.Controls.Add(this.textBoxSliderGroup);
            this.flowLayoutPanelSlider.Controls.Add(this.label8);
            this.flowLayoutPanelSlider.Controls.Add(this.textBoxSliderType);
            this.flowLayoutPanelSlider.Controls.Add(this.label4);
            this.flowLayoutPanelSlider.Controls.Add(this.trackBarSliderAmount);
            this.flowLayoutPanelSlider.Controls.Add(this.numericUpDownSliderAmount);
            this.flowLayoutPanelSlider.Controls.Add(this.button1);
            this.flowLayoutPanelSlider.Controls.Add(this.label9);
            this.flowLayoutPanelSlider.Controls.Add(this.numericUpDownSliderMultiply);
            this.flowLayoutPanelSlider.Enabled = false;
            this.flowLayoutPanelSlider.Location = new System.Drawing.Point(13, 367);
            this.flowLayoutPanelSlider.Name = "flowLayoutPanelSlider";
            this.flowLayoutPanelSlider.Size = new System.Drawing.Size(672, 227);
            this.flowLayoutPanelSlider.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slider Name:";
            // 
            // textBoxSliderName
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.textBoxSliderName, true);
            this.textBoxSliderName.Location = new System.Drawing.Point(98, 3);
            this.textBoxSliderName.Name = "textBoxSliderName";
            this.textBoxSliderName.Size = new System.Drawing.Size(557, 22);
            this.textBoxSliderName.TabIndex = 3;
            this.textBoxSliderName.TextChanged += new System.EventHandler(this.textBoxSliderName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Instance:";
            // 
            // textBoxSliderInstance
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.textBoxSliderInstance, true);
            this.textBoxSliderInstance.Location = new System.Drawing.Point(74, 31);
            this.textBoxSliderInstance.Name = "textBoxSliderInstance";
            this.textBoxSliderInstance.Size = new System.Drawing.Size(581, 22);
            this.textBoxSliderInstance.TabIndex = 8;
            this.textBoxSliderInstance.Text = "0x0000000000000000";
            this.textBoxSliderInstance.TextChanged += new System.EventHandler(this.textBoxSliderInstance_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Group:";
            // 
            // textBoxSliderGroup
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.textBoxSliderGroup, true);
            this.textBoxSliderGroup.Location = new System.Drawing.Point(61, 59);
            this.textBoxSliderGroup.Name = "textBoxSliderGroup";
            this.textBoxSliderGroup.Size = new System.Drawing.Size(594, 22);
            this.textBoxSliderGroup.TabIndex = 12;
            this.textBoxSliderGroup.Text = "0x00000000";
            this.textBoxSliderGroup.TextChanged += new System.EventHandler(this.textBoxSliderGroup_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Type:";
            // 
            // textBoxSliderType
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.textBoxSliderType, true);
            this.textBoxSliderType.Location = new System.Drawing.Point(53, 87);
            this.textBoxSliderType.Name = "textBoxSliderType";
            this.textBoxSliderType.Size = new System.Drawing.Size(602, 22);
            this.textBoxSliderType.TabIndex = 13;
            this.textBoxSliderType.Text = "0x0358B08A";
            this.textBoxSliderType.TextChanged += new System.EventHandler(this.textBoxSliderType_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanelSlider.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Slider Amount:";
            // 
            // trackBarSliderAmount
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.trackBarSliderAmount, true);
            this.trackBarSliderAmount.Location = new System.Drawing.Point(3, 132);
            this.trackBarSliderAmount.Maximum = 50;
            this.trackBarSliderAmount.Minimum = -50;
            this.trackBarSliderAmount.Name = "trackBarSliderAmount";
            this.trackBarSliderAmount.Size = new System.Drawing.Size(669, 56);
            this.trackBarSliderAmount.TabIndex = 4;
            this.trackBarSliderAmount.Scroll += new System.EventHandler(this.trackBarSliderAmount_Scroll);
            // 
            // numericUpDownSliderAmount
            // 
            this.numericUpDownSliderAmount.DecimalPlaces = 8;
            this.numericUpDownSliderAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSliderAmount.Location = new System.Drawing.Point(3, 194);
            this.numericUpDownSliderAmount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSliderAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownSliderAmount.Name = "numericUpDownSliderAmount";
            this.numericUpDownSliderAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSliderAmount.TabIndex = 6;
            this.numericUpDownSliderAmount.ValueChanged += new System.EventHandler(this.numericUpDownSliderAmount_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Set NRaas Numeric Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Multiply:";
            // 
            // numericUpDownSliderMultiply
            // 
            this.flowLayoutPanelSlider.SetFlowBreak(this.numericUpDownSliderMultiply, true);
            this.numericUpDownSliderMultiply.Location = new System.Drawing.Point(430, 194);
            this.numericUpDownSliderMultiply.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSliderMultiply.Name = "numericUpDownSliderMultiply";
            this.numericUpDownSliderMultiply.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSliderMultiply.TabIndex = 16;
            this.numericUpDownSliderMultiply.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSliderMultiply.ValueChanged += new System.EventHandler(this.numericUpDownSliderMultiply_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sliders:";
            // 
            // buttonAddSlider
            // 
            this.buttonAddSlider.Location = new System.Drawing.Point(13, 329);
            this.buttonAddSlider.Name = "buttonAddSlider";
            this.buttonAddSlider.Size = new System.Drawing.Size(103, 32);
            this.buttonAddSlider.TabIndex = 7;
            this.buttonAddSlider.Text = "Add";
            this.buttonAddSlider.UseVisualStyleBackColor = true;
            this.buttonAddSlider.Click += new System.EventHandler(this.buttonAddSlider_Click);
            // 
            // buttonRemoveSlider
            // 
            this.buttonRemoveSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveSlider.Enabled = false;
            this.buttonRemoveSlider.Location = new System.Drawing.Point(582, 328);
            this.buttonRemoveSlider.Name = "buttonRemoveSlider";
            this.buttonRemoveSlider.Size = new System.Drawing.Size(103, 32);
            this.buttonRemoveSlider.TabIndex = 8;
            this.buttonRemoveSlider.Text = "Remove";
            this.buttonRemoveSlider.UseVisualStyleBackColor = true;
            this.buttonRemoveSlider.Click += new System.EventHandler(this.buttonRemoveSlider_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchConvertXMLsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // batchConvertXMLsToolStripMenuItem
            // 
            this.batchConvertXMLsToolStripMenuItem.Name = "batchConvertXMLsToolStripMenuItem";
            this.batchConvertXMLsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.batchConvertXMLsToolStripMenuItem.Text = "Batch Convert XMLs";
            this.batchConvertXMLsToolStripMenuItem.Click += new System.EventHandler(this.batchConvertXMLsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 606);
            this.Controls.Add(this.buttonRemoveSlider);
            this.Controls.Add(this.buttonAddSlider);
            this.Controls.Add(this.flowLayoutPanelSlider);
            this.Controls.Add(this.listViewSliders);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Face Preset Editor - Untitled";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelSlider.ResumeLayout(false);
            this.flowLayoutPanelSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSliderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSliderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSliderMultiply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPresetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPresetType;
        private System.Windows.Forms.ListView listViewSliders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSliderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarSliderAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSliderAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSliderInstance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSliderGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSliderType;
        private System.Windows.Forms.Button buttonAddSlider;
        private System.Windows.Forms.Button buttonRemoveSlider;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderTGI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownSliderMultiply;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchConvertXMLsToolStripMenuItem;
    }
}

