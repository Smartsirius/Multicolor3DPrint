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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcodeTextBox
            // 
            this.gcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcodeTextBox.Location = new System.Drawing.Point(202, 12);
            this.gcodeTextBox.Name = "gcodeTextBox";
            this.gcodeTextBox.Size = new System.Drawing.Size(366, 310);
            this.gcodeTextBox.TabIndex = 0;
            this.gcodeTextBox.Text = "";
            // 
            // buttonCalcGcodeFromColor
            // 
            this.buttonCalcGcodeFromColor.Location = new System.Drawing.Point(24, 21);
            this.buttonCalcGcodeFromColor.Name = "buttonCalcGcodeFromColor";
            this.buttonCalcGcodeFromColor.Size = new System.Drawing.Size(114, 66);
            this.buttonCalcGcodeFromColor.TabIndex = 1;
            this.buttonCalcGcodeFromColor.Text = "Aus Farbe GCode erzeugen";
            this.buttonCalcGcodeFromColor.UseVisualStyleBackColor = true;
            this.buttonCalcGcodeFromColor.Click += new System.EventHandler(this.ButtonCalcFromColor_Click);
            // 
            // buttonCalcColorFromGcode
            // 
            this.buttonCalcColorFromGcode.Location = new System.Drawing.Point(24, 93);
            this.buttonCalcColorFromGcode.Name = "buttonCalcColorFromGcode";
            this.buttonCalcColorFromGcode.Size = new System.Drawing.Size(114, 66);
            this.buttonCalcColorFromGcode.TabIndex = 2;
            this.buttonCalcColorFromGcode.Text = "Farbe aus GCode berechnen";
            this.buttonCalcColorFromGcode.UseVisualStyleBackColor = true;
            this.buttonCalcColorFromGcode.Click += new System.EventHandler(this.ButtonCalcFromGcode_Click);
            // 
            // buttonLED
            // 
            this.buttonLED.AllowDrop = true;
            this.buttonLED.Enabled = false;
            this.buttonLED.Location = new System.Drawing.Point(26, 165);
            this.buttonLED.Name = "buttonLED";
            this.buttonLED.Size = new System.Drawing.Size(114, 66);
            this.buttonLED.TabIndex = 3;
            this.buttonLED.UseVisualStyleBackColor = true;
            // 
            // buttonE0
            // 
            this.buttonE0.BackColor = System.Drawing.Color.Red;
            this.buttonE0.Location = new System.Drawing.Point(118, 236);
            this.buttonE0.Name = "buttonE0";
            this.buttonE0.Size = new System.Drawing.Size(20, 20);
            this.buttonE0.TabIndex = 7;
            this.buttonE0.UseVisualStyleBackColor = false;
            this.buttonE0.Click += new System.EventHandler(this.buttonE0_Click);
            // 
            // buttonE1
            // 
            this.buttonE1.BackColor = System.Drawing.Color.Lime;
            this.buttonE1.Location = new System.Drawing.Point(118, 260);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(20, 20);
            this.buttonE1.TabIndex = 8;
            this.buttonE1.UseVisualStyleBackColor = false;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // buttonE2
            // 
            this.buttonE2.BackColor = System.Drawing.Color.Blue;
            this.buttonE2.Location = new System.Drawing.Point(118, 284);
            this.buttonE2.Name = "buttonE2";
            this.buttonE2.Size = new System.Drawing.Size(20, 20);
            this.buttonE2.TabIndex = 9;
            this.buttonE2.UseVisualStyleBackColor = false;
            this.buttonE2.Click += new System.EventHandler(this.buttonE2_Click);
            // 
            // labelExtruder1
            // 
            this.labelExtruder1.AutoSize = true;
            this.labelExtruder1.Location = new System.Drawing.Point(23, 240);
            this.labelExtruder1.Name = "labelExtruder1";
            this.labelExtruder1.Size = new System.Drawing.Size(55, 13);
            this.labelExtruder1.TabIndex = 10;
            this.labelExtruder1.Text = "Extruder 1";
            // 
            // labelExtruder2
            // 
            this.labelExtruder2.AutoSize = true;
            this.labelExtruder2.Location = new System.Drawing.Point(23, 264);
            this.labelExtruder2.Name = "labelExtruder2";
            this.labelExtruder2.Size = new System.Drawing.Size(55, 13);
            this.labelExtruder2.TabIndex = 11;
            this.labelExtruder2.Text = "Extruder 2";
            // 
            // labelExtruder3
            // 
            this.labelExtruder3.AutoSize = true;
            this.labelExtruder3.Location = new System.Drawing.Point(23, 288);
            this.labelExtruder3.Name = "labelExtruder3";
            this.labelExtruder3.Size = new System.Drawing.Size(55, 13);
            this.labelExtruder3.TabIndex = 12;
            this.labelExtruder3.Text = "Extruder 3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusMessage.Text = "Ok";
            // 
            // ColorMixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.statusStrip1);
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
            this.Text = "3DPrintColorMixer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
    }
}

