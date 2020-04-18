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
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.GCodeRichTextBox = new System.Windows.Forms.RichTextBox();
      this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
      this.extruderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.buttonExtruder16 = new System.Windows.Forms.Button();
      this.buttonExtruder15 = new System.Windows.Forms.Button();
      this.buttonExtruder14 = new System.Windows.Forms.Button();
      this.buttonExtruder13 = new System.Windows.Forms.Button();
      this.buttonExtruder12 = new System.Windows.Forms.Button();
      this.buttonExtruder11 = new System.Windows.Forms.Button();
      this.buttonExtruder10 = new System.Windows.Forms.Button();
      this.buttonExtruder9 = new System.Windows.Forms.Button();
      this.buttonExtruder8 = new System.Windows.Forms.Button();
      this.buttonExtruder7 = new System.Windows.Forms.Button();
      this.buttonExtruder6 = new System.Windows.Forms.Button();
      this.buttonExtruder5 = new System.Windows.Forms.Button();
      this.buttonExtruder4 = new System.Windows.Forms.Button();
      this.buttonExtruder3 = new System.Windows.Forms.Button();
      this.buttonExtruder2 = new System.Windows.Forms.Button();
      this.buttonExtruder1 = new System.Windows.Forms.Button();
      this.gcodeTextBox = new System.Windows.Forms.RichTextBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonGenerateGcode = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonImportPrusaSlicerIni = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonExportPrusaSlicerIni = new System.Windows.Forms.ToolStripButton();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.extruderTableLayoutPanel.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.GCodeRichTextBox);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.comboBoxLanguages);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.extruderTableLayoutPanel);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.gcodeTextBox);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(980, 532);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.RightToolStripPanelVisible = false;
      this.toolStripContainer1.Size = new System.Drawing.Size(980, 557);
      this.toolStripContainer1.TabIndex = 15;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
      // 
      // GCodeRichTextBox
      // 
      this.GCodeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GCodeRichTextBox.Location = new System.Drawing.Point(0, 0);
      this.GCodeRichTextBox.Name = "GCodeRichTextBox";
      this.GCodeRichTextBox.Size = new System.Drawing.Size(793, 487);
      this.GCodeRichTextBox.TabIndex = 16;
      this.GCodeRichTextBox.Text = "";
      // 
      // comboBoxLanguages
      // 
      this.comboBoxLanguages.Dock = System.Windows.Forms.DockStyle.Right;
      this.comboBoxLanguages.FormattingEnabled = true;
      this.comboBoxLanguages.Location = new System.Drawing.Point(793, 0);
      this.comboBoxLanguages.Name = "comboBoxLanguages";
      this.comboBoxLanguages.Size = new System.Drawing.Size(187, 21);
      this.comboBoxLanguages.TabIndex = 14;
      this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguages_SelectedIndexChanged);
      // 
      // extruderTableLayoutPanel
      // 
      this.extruderTableLayoutPanel.AutoSize = true;
      this.extruderTableLayoutPanel.ColumnCount = 16;
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder1, 0, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder2, 1, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder3, 2, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder4, 3, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder5, 4, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder6, 5, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder7, 6, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder8, 7, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder9, 8, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder10, 9, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder11, 10, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder12, 11, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder13, 12, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder14, 13, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder15, 14, 0);
      this.extruderTableLayoutPanel.Controls.Add(this.buttonExtruder16, 15, 0);
      this.extruderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.extruderTableLayoutPanel.Location = new System.Drawing.Point(0, 487);
      this.extruderTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
      this.extruderTableLayoutPanel.Name = "extruderTableLayoutPanel";
      this.extruderTableLayoutPanel.RowCount = 1;
      this.extruderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.extruderTableLayoutPanel.Size = new System.Drawing.Size(980, 45);
      this.extruderTableLayoutPanel.TabIndex = 15;
      // 
      // buttonExtruder16
      // 
      this.buttonExtruder16.AutoSize = true;
      this.buttonExtruder16.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder16.Location = new System.Drawing.Point(915, 0);
      this.buttonExtruder16.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder16.Name = "buttonExtruder16";
      this.buttonExtruder16.Size = new System.Drawing.Size(65, 45);
      this.buttonExtruder16.TabIndex = 15;
      this.buttonExtruder16.Text = "16";
      this.buttonExtruder16.UseVisualStyleBackColor = true;
      this.buttonExtruder16.Click += new System.EventHandler(this.ButtonExtruder16_Click);
      // 
      // buttonExtruder15
      // 
      this.buttonExtruder15.AutoSize = true;
      this.buttonExtruder15.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder15.Location = new System.Drawing.Point(854, 0);
      this.buttonExtruder15.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder15.Name = "buttonExtruder15";
      this.buttonExtruder15.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder15.TabIndex = 14;
      this.buttonExtruder15.Text = "15";
      this.buttonExtruder15.UseVisualStyleBackColor = true;
      this.buttonExtruder15.Click += new System.EventHandler(this.ButtonExtruder15_Click);
      // 
      // buttonExtruder14
      // 
      this.buttonExtruder14.AutoSize = true;
      this.buttonExtruder14.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder14.Location = new System.Drawing.Point(793, 0);
      this.buttonExtruder14.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder14.Name = "buttonExtruder14";
      this.buttonExtruder14.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder14.TabIndex = 13;
      this.buttonExtruder14.Text = "14";
      this.buttonExtruder14.UseVisualStyleBackColor = true;
      this.buttonExtruder14.Click += new System.EventHandler(this.ButtonExtruder14_Click);
      // 
      // buttonExtruder13
      // 
      this.buttonExtruder13.AutoSize = true;
      this.buttonExtruder13.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder13.Location = new System.Drawing.Point(732, 0);
      this.buttonExtruder13.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder13.Name = "buttonExtruder13";
      this.buttonExtruder13.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder13.TabIndex = 12;
      this.buttonExtruder13.Text = "13";
      this.buttonExtruder13.UseVisualStyleBackColor = true;
      this.buttonExtruder13.Click += new System.EventHandler(this.ButtonExtruder13_Click);
      // 
      // buttonExtruder12
      // 
      this.buttonExtruder12.AutoSize = true;
      this.buttonExtruder12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder12.Location = new System.Drawing.Point(671, 0);
      this.buttonExtruder12.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder12.Name = "buttonExtruder12";
      this.buttonExtruder12.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder12.TabIndex = 11;
      this.buttonExtruder12.Text = "12";
      this.buttonExtruder12.UseVisualStyleBackColor = true;
      this.buttonExtruder12.Click += new System.EventHandler(this.ButtonExtruder12_Click);
      // 
      // buttonExtruder11
      // 
      this.buttonExtruder11.AutoSize = true;
      this.buttonExtruder11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder11.Location = new System.Drawing.Point(610, 0);
      this.buttonExtruder11.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder11.Name = "buttonExtruder11";
      this.buttonExtruder11.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder11.TabIndex = 10;
      this.buttonExtruder11.Text = "11";
      this.buttonExtruder11.UseVisualStyleBackColor = true;
      this.buttonExtruder11.Click += new System.EventHandler(this.ButtonExtruder11_Click);
      // 
      // buttonExtruder10
      // 
      this.buttonExtruder10.AutoSize = true;
      this.buttonExtruder10.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder10.Location = new System.Drawing.Point(549, 0);
      this.buttonExtruder10.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder10.Name = "buttonExtruder10";
      this.buttonExtruder10.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder10.TabIndex = 9;
      this.buttonExtruder10.Text = "10";
      this.buttonExtruder10.UseVisualStyleBackColor = true;
      this.buttonExtruder10.Click += new System.EventHandler(this.ButtonExtruder10_Click);
      // 
      // buttonExtruder9
      // 
      this.buttonExtruder9.AutoSize = true;
      this.buttonExtruder9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder9.Location = new System.Drawing.Point(488, 0);
      this.buttonExtruder9.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder9.Name = "buttonExtruder9";
      this.buttonExtruder9.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder9.TabIndex = 8;
      this.buttonExtruder9.Text = "9";
      this.buttonExtruder9.UseVisualStyleBackColor = true;
      this.buttonExtruder9.Click += new System.EventHandler(this.ButtonExtruder9_Click);
      // 
      // buttonExtruder8
      // 
      this.buttonExtruder8.AutoSize = true;
      this.buttonExtruder8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder8.Location = new System.Drawing.Point(427, 0);
      this.buttonExtruder8.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder8.Name = "buttonExtruder8";
      this.buttonExtruder8.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder8.TabIndex = 7;
      this.buttonExtruder8.Text = "8";
      this.buttonExtruder8.UseVisualStyleBackColor = true;
      this.buttonExtruder8.Click += new System.EventHandler(this.ButtonExtruder8_Click);
      // 
      // buttonExtruder7
      // 
      this.buttonExtruder7.AutoSize = true;
      this.buttonExtruder7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder7.Location = new System.Drawing.Point(366, 0);
      this.buttonExtruder7.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder7.Name = "buttonExtruder7";
      this.buttonExtruder7.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder7.TabIndex = 6;
      this.buttonExtruder7.Text = "7";
      this.buttonExtruder7.UseVisualStyleBackColor = true;
      this.buttonExtruder7.Click += new System.EventHandler(this.ButtonExtruder7_Click);
      // 
      // buttonExtruder6
      // 
      this.buttonExtruder6.AutoSize = true;
      this.buttonExtruder6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder6.Location = new System.Drawing.Point(305, 0);
      this.buttonExtruder6.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder6.Name = "buttonExtruder6";
      this.buttonExtruder6.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder6.TabIndex = 5;
      this.buttonExtruder6.Text = "6";
      this.buttonExtruder6.UseVisualStyleBackColor = true;
      this.buttonExtruder6.Click += new System.EventHandler(this.ButtonExtruder6_Click);
      // 
      // buttonExtruder5
      // 
      this.buttonExtruder5.AutoSize = true;
      this.buttonExtruder5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder5.Location = new System.Drawing.Point(244, 0);
      this.buttonExtruder5.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder5.Name = "buttonExtruder5";
      this.buttonExtruder5.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder5.TabIndex = 4;
      this.buttonExtruder5.Text = "5";
      this.buttonExtruder5.UseVisualStyleBackColor = true;
      this.buttonExtruder5.Click += new System.EventHandler(this.ButtonExtruder5_Click);
      // 
      // buttonExtruder4
      // 
      this.buttonExtruder4.AutoSize = true;
      this.buttonExtruder4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder4.Location = new System.Drawing.Point(183, 0);
      this.buttonExtruder4.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder4.Name = "buttonExtruder4";
      this.buttonExtruder4.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder4.TabIndex = 3;
      this.buttonExtruder4.Text = "4";
      this.buttonExtruder4.UseVisualStyleBackColor = true;
      this.buttonExtruder4.Click += new System.EventHandler(this.ButtonExtruder4_Click);
      // 
      // buttonExtruder3
      // 
      this.buttonExtruder3.AutoSize = true;
      this.buttonExtruder3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder3.Location = new System.Drawing.Point(122, 0);
      this.buttonExtruder3.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder3.Name = "buttonExtruder3";
      this.buttonExtruder3.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder3.TabIndex = 2;
      this.buttonExtruder3.Text = "3";
      this.buttonExtruder3.UseVisualStyleBackColor = true;
      this.buttonExtruder3.Click += new System.EventHandler(this.ButtonExtruder3_Click);
      // 
      // buttonExtruder2
      // 
      this.buttonExtruder2.AutoSize = true;
      this.buttonExtruder2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder2.Location = new System.Drawing.Point(61, 0);
      this.buttonExtruder2.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder2.Name = "buttonExtruder2";
      this.buttonExtruder2.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder2.TabIndex = 1;
      this.buttonExtruder2.Text = "2";
      this.buttonExtruder2.UseVisualStyleBackColor = true;
      this.buttonExtruder2.Click += new System.EventHandler(this.ButtonExtruder2_Click);
      // 
      // buttonExtruder1
      // 
      this.buttonExtruder1.AutoSize = true;
      this.buttonExtruder1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonExtruder1.Location = new System.Drawing.Point(0, 0);
      this.buttonExtruder1.Margin = new System.Windows.Forms.Padding(0);
      this.buttonExtruder1.Name = "buttonExtruder1";
      this.buttonExtruder1.Size = new System.Drawing.Size(61, 45);
      this.buttonExtruder1.TabIndex = 0;
      this.buttonExtruder1.Text = "1";
      this.buttonExtruder1.UseVisualStyleBackColor = true;
      this.buttonExtruder1.Click += new System.EventHandler(this.ButtonExtruder1_Click);
      // 
      // gcodeTextBox
      // 
      this.gcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gcodeTextBox.Location = new System.Drawing.Point(4058, 102);
      this.gcodeTextBox.Name = "gcodeTextBox";
      this.gcodeTextBox.Size = new System.Drawing.Size(366, 2233);
      this.gcodeTextBox.TabIndex = 0;
      this.gcodeTextBox.Text = "";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGenerateGcode,
            this.toolStripButtonImportPrusaSlicerIni,
            this.toolStripButtonExportPrusaSlicerIni});
      this.toolStrip1.Location = new System.Drawing.Point(3, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(579, 25);
      this.toolStrip1.TabIndex = 0;
      // 
      // toolStripButtonGenerateGcode
      // 
      this.toolStripButtonGenerateGcode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonGenerateGcode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateGcode.Image")));
      this.toolStripButtonGenerateGcode.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonGenerateGcode.Name = "toolStripButtonGenerateGcode";
      this.toolStripButtonGenerateGcode.Size = new System.Drawing.Size(173, 22);
      this.toolStripButtonGenerateGcode.Text = "toolStripButtonGenerateGcode";
      this.toolStripButtonGenerateGcode.Click += new System.EventHandler(this.ToolStripButtonGenerateGcode_Click);
      // 
      // toolStripButtonImportPrusaSlicerIni
      // 
      this.toolStripButtonImportPrusaSlicerIni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonImportPrusaSlicerIni.Enabled = false;
      this.toolStripButtonImportPrusaSlicerIni.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImportPrusaSlicerIni.Image")));
      this.toolStripButtonImportPrusaSlicerIni.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonImportPrusaSlicerIni.Name = "toolStripButtonImportPrusaSlicerIni";
      this.toolStripButtonImportPrusaSlicerIni.Size = new System.Drawing.Size(198, 22);
      this.toolStripButtonImportPrusaSlicerIni.Text = "toolStripButtonImportPrusaSlicerIni";
      // 
      // toolStripButtonExportPrusaSlicerIni
      // 
      this.toolStripButtonExportPrusaSlicerIni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonExportPrusaSlicerIni.Enabled = false;
      this.toolStripButtonExportPrusaSlicerIni.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExportPrusaSlicerIni.Image")));
      this.toolStripButtonExportPrusaSlicerIni.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonExportPrusaSlicerIni.Name = "toolStripButtonExportPrusaSlicerIni";
      this.toolStripButtonExportPrusaSlicerIni.Size = new System.Drawing.Size(196, 22);
      this.toolStripButtonExportPrusaSlicerIni.Text = "toolStripButtonExportPrusaSlicerIni";
      // 
      // ColorMixerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(980, 557);
      this.Controls.Add(this.toolStripContainer1);
      this.Name = "ColorMixerForm";
      this.Text = "3DPrintColorMixer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorMixerForm_FormClosing);
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.ContentPanel.PerformLayout();
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.extruderTableLayoutPanel.ResumeLayout(false);
      this.extruderTableLayoutPanel.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.RichTextBox gcodeTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateGcode;
        private System.Windows.Forms.TableLayoutPanel extruderTableLayoutPanel;
        private System.Windows.Forms.Button buttonExtruder16;
        private System.Windows.Forms.Button buttonExtruder15;
        private System.Windows.Forms.Button buttonExtruder14;
        private System.Windows.Forms.Button buttonExtruder13;
        private System.Windows.Forms.Button buttonExtruder12;
        private System.Windows.Forms.Button buttonExtruder11;
        private System.Windows.Forms.Button buttonExtruder10;
        private System.Windows.Forms.Button buttonExtruder9;
        private System.Windows.Forms.Button buttonExtruder8;
        private System.Windows.Forms.Button buttonExtruder7;
        private System.Windows.Forms.Button buttonExtruder6;
        private System.Windows.Forms.Button buttonExtruder5;
        private System.Windows.Forms.Button buttonExtruder4;
        private System.Windows.Forms.Button buttonExtruder3;
        private System.Windows.Forms.Button buttonExtruder2;
        private System.Windows.Forms.Button buttonExtruder1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImportPrusaSlicerIni;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportPrusaSlicerIni;
        private System.Windows.Forms.RichTextBox GCodeRichTextBox;
    }
}

