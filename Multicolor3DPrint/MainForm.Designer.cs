namespace Multicolor3DPrint
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonGenerateCode = new System.Windows.Forms.ToolStripButton();
      this.flowLayoutPanelVirtualTools = new System.Windows.Forms.FlowLayoutPanel();
      this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.splitContainerTop = new System.Windows.Forms.SplitContainer();
      this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
      this.toolStrip.SuspendLayout();
      this.toolStripContainer.ContentPanel.SuspendLayout();
      this.toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
      this.splitContainerTop.Panel1.SuspendLayout();
      this.splitContainerTop.Panel2.SuspendLayout();
      this.splitContainerTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // richTextBoxCode
      // 
      this.richTextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBoxCode.Location = new System.Drawing.Point(0, 0);
      this.richTextBoxCode.Name = "richTextBoxCode";
      this.richTextBoxCode.Size = new System.Drawing.Size(653, 448);
      this.richTextBoxCode.TabIndex = 0;
      this.richTextBoxCode.Text = "";
      // 
      // toolStrip
      // 
      this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGenerateCode});
      this.toolStrip.Location = new System.Drawing.Point(4, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(101, 25);
      this.toolStrip.TabIndex = 2;
      this.toolStrip.Text = "toolStrip";
      // 
      // toolStripButtonGenerateCode
      // 
      this.toolStripButtonGenerateCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateCode.Image")));
      this.toolStripButtonGenerateCode.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonGenerateCode.Name = "toolStripButtonGenerateCode";
      this.toolStripButtonGenerateCode.Size = new System.Drawing.Size(89, 22);
      this.toolStripButtonGenerateCode.Text = "Generate Code";
      this.toolStripButtonGenerateCode.Click += new System.EventHandler(this.ToolStripButtonGenerateCode_Click);
      // 
      // flowLayoutPanelVirtualTools
      // 
      this.flowLayoutPanelVirtualTools.AutoScroll = true;
      this.flowLayoutPanelVirtualTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.flowLayoutPanelVirtualTools.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanelVirtualTools.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanelVirtualTools.Name = "flowLayoutPanelVirtualTools";
      this.flowLayoutPanelVirtualTools.Size = new System.Drawing.Size(324, 448);
      this.flowLayoutPanelVirtualTools.TabIndex = 3;
      // 
      // toolStripContainer
      // 
      // 
      // toolStripContainer.ContentPanel
      // 
      this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainerMain);
      this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(984, 536);
      this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // toolStripContainer.LeftToolStripPanel
      // 
      this.toolStripContainer.LeftToolStripPanel.Enabled = false;
      this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer.Name = "toolStripContainer";
      // 
      // toolStripContainer.RightToolStripPanel
      // 
      this.toolStripContainer.RightToolStripPanel.Enabled = false;
      this.toolStripContainer.Size = new System.Drawing.Size(984, 561);
      this.toolStripContainer.TabIndex = 4;
      this.toolStripContainer.Text = "toolStripContainer";
      // 
      // toolStripContainer.TopToolStripPanel
      // 
      this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
      this.splitContainerMain.Name = "splitContainerMain";
      this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTop);
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.Controls.Add(this.flowLayoutPanelBottom);
      this.splitContainerMain.Size = new System.Drawing.Size(984, 536);
      this.splitContainerMain.SplitterDistance = 450;
      this.splitContainerMain.SplitterWidth = 2;
      this.splitContainerMain.TabIndex = 5;
      // 
      // splitContainerTop
      // 
      this.splitContainerTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
      this.splitContainerTop.Name = "splitContainerTop";
      // 
      // splitContainerTop.Panel1
      // 
      this.splitContainerTop.Panel1.Controls.Add(this.richTextBoxCode);
      // 
      // splitContainerTop.Panel2
      // 
      this.splitContainerTop.Panel2.Controls.Add(this.flowLayoutPanelVirtualTools);
      this.splitContainerTop.Size = new System.Drawing.Size(984, 450);
      this.splitContainerTop.SplitterDistance = 655;
      this.splitContainerTop.SplitterWidth = 3;
      this.splitContainerTop.TabIndex = 4;
      // 
      // flowLayoutPanelBottom
      // 
      this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
      this.flowLayoutPanelBottom.Size = new System.Drawing.Size(984, 84);
      this.flowLayoutPanelBottom.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 561);
      this.Controls.Add(this.toolStripContainer);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Multicolor3DPrint";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.toolStripContainer.ContentPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.PerformLayout();
      this.toolStripContainer.ResumeLayout(false);
      this.toolStripContainer.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.splitContainerTop.Panel1.ResumeLayout(false);
      this.splitContainerTop.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
      this.splitContainerTop.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVirtualTools;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
    }
}

