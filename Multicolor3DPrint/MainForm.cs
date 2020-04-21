using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static Multicolor3DPrint.Machine;

namespace Multicolor3DPrint
{
  public partial class MainForm : Form
  {
    Settings settings;
    readonly CultureInfo languageForNumberFormat = new CultureInfo("en-US", false);
    readonly Machine myPrinter;

    public MainForm()
    {
      InitializeComponent();
      // Make a standard machine in case no settings.json will be found
      myPrinter = new Machine
      {
        NumberOfExtruders = 3,
        NumberOfVirtualTools = 10,
        HotEnd = HotEndTyp.ThreeInOne
      };
      for (int i = 0; i < myPrinter.NumberOfExtruders; i++)
      {
        myPrinter.Extruders.Add(new Extruder() { Name = string.Format("extruder{0}", i), Number = i, Color = Color.White });
      }
      for (int i = 0; i < myPrinter.NumberOfVirtualTools; i++)
      {
        myPrinter.VirtualTools.Add(new Extruder() { Name = string.Format("virtualtool{0}", i), Number = i + myPrinter.NumberOfExtruders, Color = Color.White });
      }

      // Read settings and overwrite standard machine
      settings = new Settings();
      settings.ReadSettings();
      if (settings == null)
      {
        settings.Machine = myPrinter;
      }
      else
      {
        myPrinter = settings.Machine;
      }

      // generate Buttons
      foreach (Extruder extruder in myPrinter.Extruders)
      {
        Button btn = new Button
        {
          Width = 50,
          Height = 50,
          Name = extruder.Name,
          Text = extruder.Number.ToString(),
          BackColor = extruder.Color
        };
        btn.Click += new EventHandler(ButtonExtruder_Click);
        flowLayoutPanelBottom.Controls.Add(btn);
      }
      foreach (Extruder virtualTool in myPrinter.VirtualTools)
      {
        Button btn = new Button
        {
          Width = 50,
          Height = 50,
          Name = virtualTool.Name,
          Text = virtualTool.Number.ToString(),
          BackColor = virtualTool.Color
        };
        btn.Click += new EventHandler(ButtonExtruder_Click);
        flowLayoutPanelVirtualTools.Controls.Add(btn);
      }
    }

    private void ButtonExtruder_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      Button item = ((Button)sender);
      item.BackColor = colorDialog.Color;
      Extruder result = settings.Machine.Extruders.Find(x => x.GetName() == item.Name);
      if (result == null)
      {
        result = settings.Machine.VirtualTools.Find(x => x.GetName() == item.Name);
      }
      result.Color = item.BackColor;
      richTextBoxCode.Focus();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      settings.Machine = myPrinter;
      settings.WriteSettings();
    }

    private void ToolStripButtonGenerateCode_Click(object sender, EventArgs e)
    {
      richTextBoxCode.Clear();
      foreach (var virtualTool in myPrinter.VirtualTools)
      {
        // Cancel at Black or White color
        if (virtualTool.Color.Name.ToUpper() == "WHITE" || virtualTool.Color.Name.ToUpper() == "BLACK")
        {
          MessageBox.Show(this, "Color white or black are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        // if not 3in1 nozzle on machine cancel because we need red, green and blue
        if (myPrinter.HotEnd != HotEndTyp.ThreeInOne)
          return;

        string text = string.Empty;

        Extruder redExtr = new Extruder();
        Extruder greenExtr = new Extruder();
        Extruder blueExtr = new Extruder();

        myPrinter.PrintColor.CalcProportion(virtualTool.Color);

        foreach (var item in flowLayoutPanelBottom.Controls)
        {
          // find colors in all real extruders
          Extruder extruder = myPrinter.Extruders.Find(x => x.GetColor() == Color.Red);
          if (extruder == null)
          {
            MessageBox.Show(this, "No Extruder with color Red found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          redExtr = extruder;

          extruder = myPrinter.Extruders.Find(x => x.GetColor() == Color.Lime);
          if (extruder == null)
          {
            MessageBox.Show(this, "No Extruder with color Green found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          greenExtr = extruder;

          extruder = myPrinter.Extruders.Find(x => x.GetColor() == Color.Blue);
          if (extruder == null)
          {
            MessageBox.Show(this, "No Extruder with color Blue found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          blueExtr = extruder;
        }
        Extruder currentVirtualTool = myPrinter.VirtualTools.Find(x => x.GetColor() == myPrinter.PrintColor.Color);
        if (currentVirtualTool != null)
        {
          text += string.Format("M163 S{0} P{1}\n", redExtr.Number, myPrinter.PrintColor.ProportionOfRed.
           ToString("0.000", languageForNumberFormat.NumberFormat));
          text += string.Format("M163 S{0} P{1}\n", greenExtr.Number, myPrinter.PrintColor.ProportionOfGreen.
           ToString("0.000", languageForNumberFormat.NumberFormat));
          text += string.Format("M163 S{0} P{1}\n", blueExtr.Number, myPrinter.PrintColor.ProportionOfBlue.
           ToString("0.000", languageForNumberFormat.NumberFormat));
          text += string.Format("M164 S{0}\nT{0}\n", currentVirtualTool.Number);
          richTextBoxCode.Text += text;
          richTextBoxCode.SelectAll();
          richTextBoxCode.Copy();
        }
      }
    }
  }
}
