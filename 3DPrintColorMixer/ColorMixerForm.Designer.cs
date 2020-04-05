namespace ColorMixer
{
  partial class ColorMixerForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorMixerForm));
      this.gcodeTextBox = new System.Windows.Forms.RichTextBox();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.buttonCalcGcodeFromColor = new System.Windows.Forms.Button();
      this.buttonCalcColorFromGcode = new System.Windows.Forms.Button();
      this.buttonLED = new System.Windows.Forms.Button();
      this.buttonE0 = new System.Windows.Forms.Button();
      this.buttonE1 = new System.Windows.Forms.Button();
      this.buttonE2 = new System.Windows.Forms.Button();
      this.labelExtruder1 = new System.Windows.Forms.Label();
      this.labelExtruder2 = new System.Windows.Forms.Label();
      this.labelExtruder3 = new System.Windows.Forms.Label();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
      this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // gcodeTextBox
      // 
      resources.ApplyResources(this.gcodeTextBox, "gcodeTextBox");
      this.gcodeTextBox.Name = "gcodeTextBox";
      // 
      // buttonCalcGcodeFromColor
      // 
      resources.ApplyResources(this.buttonCalcGcodeFromColor, "buttonCalcGcodeFromColor");
      this.buttonCalcGcodeFromColor.Name = "buttonCalcGcodeFromColor";
      this.buttonCalcGcodeFromColor.UseVisualStyleBackColor = true;
      this.buttonCalcGcodeFromColor.Click += new System.EventHandler(this.ButtonCalcFromColor_Click);
      // 
      // buttonCalcColorFromGcode
      // 
      resources.ApplyResources(this.buttonCalcColorFromGcode, "buttonCalcColorFromGcode");
      this.buttonCalcColorFromGcode.Name = "buttonCalcColorFromGcode";
      this.buttonCalcColorFromGcode.UseVisualStyleBackColor = true;
      this.buttonCalcColorFromGcode.Click += new System.EventHandler(this.ButtonCalcFromGcode_Click);
      // 
      // buttonLED
      // 
      resources.ApplyResources(this.buttonLED, "buttonLED");
      this.buttonLED.AllowDrop = true;
      this.buttonLED.Name = "buttonLED";
      this.buttonLED.UseVisualStyleBackColor = true;
      // 
      // buttonE0
      // 
      resources.ApplyResources(this.buttonE0, "buttonE0");
      this.buttonE0.BackColor = System.Drawing.Color.Red;
      this.buttonE0.Name = "buttonE0";
      this.buttonE0.UseVisualStyleBackColor = false;
      this.buttonE0.Click += new System.EventHandler(this.buttonE0_Click);
      // 
      // buttonE1
      // 
      resources.ApplyResources(this.buttonE1, "buttonE1");
      this.buttonE1.BackColor = System.Drawing.Color.Lime;
      this.buttonE1.Name = "buttonE1";
      this.buttonE1.UseVisualStyleBackColor = false;
      this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
      // 
      // buttonE2
      // 
      resources.ApplyResources(this.buttonE2, "buttonE2");
      this.buttonE2.BackColor = System.Drawing.Color.Blue;
      this.buttonE2.Name = "buttonE2";
      this.buttonE2.UseVisualStyleBackColor = false;
      this.buttonE2.Click += new System.EventHandler(this.buttonE2_Click);
      // 
      // labelExtruder1
      // 
      resources.ApplyResources(this.labelExtruder1, "labelExtruder1");
      this.labelExtruder1.Name = "labelExtruder1";
      // 
      // labelExtruder2
      // 
      resources.ApplyResources(this.labelExtruder2, "labelExtruder2");
      this.labelExtruder2.Name = "labelExtruder2";
      // 
      // labelExtruder3
      // 
      resources.ApplyResources(this.labelExtruder3, "labelExtruder3");
      this.labelExtruder3.Name = "labelExtruder3";
      // 
      // statusStrip
      // 
      resources.ApplyResources(this.statusStrip, "statusStrip");
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage});
      this.statusStrip.Name = "statusStrip";
      // 
      // toolStripStatusMessage
      // 
      resources.ApplyResources(this.toolStripStatusMessage, "toolStripStatusMessage");
      this.toolStripStatusMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripStatusMessage.Name = "toolStripStatusMessage";
      // 
      // comboBoxLanguages
      // 
      resources.ApplyResources(this.comboBoxLanguages, "comboBoxLanguages");
      this.comboBoxLanguages.FormattingEnabled = true;
      this.comboBoxLanguages.Name = "comboBoxLanguages";
      this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguages_SelectedIndexChanged);
      // 
      // ColorMixerForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.comboBoxLanguages);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.labelExtruder3);
      this.Controls.Add(this.labelExtruder2);
      this.Controls.Add(this.labelExtruder1);
      this.Controls.Add(this.buttonE2);
      this.Controls.Add(this.buttonE1);
      this.Controls.Add(this.buttonE0);
      this.Controls.Add(this.buttonLED);
      this.Controls.Add(this.buttonCalcColorFromGcode);
      this.Controls.Add(this.buttonCalcGcodeFromColor);
      this.Controls.Add(this.gcodeTextBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ColorMixerForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorMixerForm_FormClosing);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.RichTextBox gcodeTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonCalcGcodeFromColor;
        private System.Windows.Forms.Button buttonCalcColorFromGcode;
        private System.Windows.Forms.Button buttonLED;
        private System.Windows.Forms.Button buttonE0;
        private System.Windows.Forms.Button buttonE1;
        private System.Windows.Forms.Button buttonE2;
        private System.Windows.Forms.Label labelExtruder1;
        private System.Windows.Forms.Label labelExtruder2;
        private System.Windows.Forms.Label labelExtruder3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
    }
}

