using _3DPrintColorMixer.Properties;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ColorMixer
{
  internal partial class ColorMixerForm : Form
  {
    CultureInfo _currentLocale;
    Color _color;
    private Extruder _extruder0;
    private Extruder _extruder1;
    private Extruder _extruder2;
    private int _extruderNumber;

    private CultureInfo _en = new CultureInfo("en-US", false);

    internal ColorMixerForm()
    {
      InitializeComponent();
      buttonExtruder1.BackColor = Settings.Default.Extruder1_Color;
      buttonExtruder2.BackColor = Settings.Default.Extruder2_Color;
      buttonExtruder3.BackColor = Settings.Default.Extruder3_Color;
      buttonExtruder4.BackColor = Settings.Default.Extruder4_Color;
      buttonExtruder5.BackColor = Settings.Default.Extruder5_Color;
      buttonExtruder6.BackColor = Settings.Default.Extruder6_Color;
      buttonExtruder7.BackColor = Settings.Default.Extruder7_Color;
      buttonExtruder8.BackColor = Settings.Default.Extruder8_Color;
      buttonExtruder9.BackColor = Settings.Default.Extruder9_Color;
      buttonExtruder10.BackColor = Settings.Default.Extruder10_Color;
      buttonExtruder11.BackColor = Settings.Default.Extruder11_Color;
      buttonExtruder12.BackColor = Settings.Default.Extruder12_Color;
      buttonExtruder13.BackColor = Settings.Default.Extruder13_Color;
      buttonExtruder14.BackColor = Settings.Default.Extruder14_Color;
      buttonExtruder15.BackColor = Settings.Default.Extruder15_Color;
      buttonExtruder16.BackColor = Settings.Default.Extruder16_Color;
      _currentLocale = new CultureInfo(Settings.Default.Language.ToString());
      ChangeLanguage(_currentLocale.Name);
      comboBoxLanguages.Items.Add(new CultureInfo("de-DE"));
      comboBoxLanguages.Items.Add(new CultureInfo("en-US"));
      comboBoxLanguages.DisplayMember = "DisplayName";
      comboBoxLanguages.ValueMember = "ShortName";
      comboBoxLanguages.Sorted = true;

      int idx = comboBoxLanguages.Items.IndexOf(_currentLocale);
      comboBoxLanguages.SelectedIndex = idx;

      _extruderNumber = 0;

      _color = new Color();

      _extruder0 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Red);
      _extruder0.Color = _color;
      _extruder0.Propotion = _color.Red;

      _extruder1 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Green);
      _extruder1.Color = _color;
      _extruder1.Propotion = _color.Green;

      _extruder2 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Blue);
      _extruder2.Color = _color;
      _extruder2.Propotion = _color.Blue;
    }

    private void WriteGCode()
    {
      var text = string.Format("M163 S0 P{0}\nM163 S1 P{1}\nM163 S2 P{2}\nM164 S{3}\nT{3}\n",
        _extruder0.Propotion.ToString("0.00", _en.NumberFormat),
        _extruder1.Propotion.ToString("0.00", _en.NumberFormat),
        _extruder2.Propotion.ToString("0.00", _en.NumberFormat),
        _extruderNumber);
      GCodeRichTextBox.Text += text;
    }

    //private void ButtonCalcFromGcode_Click(object sender, EventArgs e)
    //{
    //  ParseGCode(gcodeTextBox.Text);

    //  // The sum of the extruder propotions can not be higher than 100 percent that are represented by value 10
    //  if (_extruder0.Propotion + _extruder1.Propotion + _extruder2.Propotion > 10)
    //  {
    //    MessageBox.Show(this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    return;
    //  }
    //  _color.Set(_extruder0.Propotion, _extruder1.Propotion, _extruder2.Propotion);
    //}

    //private void ParseGCode(string gcode)
    //{
    //  string[] lines = gcode.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    //  foreach (var line in lines)
    //  {
    //    if (line.Contains("M163 S0 P"))
    //    {
    //      int pPos = line.IndexOf("P");
    //      var value = line.Substring(pPos + 1, line.Length - pPos - 1);
    //      _extruder0.Propotion = double.Parse(value);
    //    }
    //    if (line.Contains("M163 S1 P"))
    //    {
    //      int pPos = line.IndexOf("P");
    //      var value = line.Substring(pPos + 1, line.Length - pPos - 1);
    //      _extruder1.Propotion = double.Parse(value);
    //    }
    //    if (line.Contains("M163 S2 P"))
    //    {
    //      int pPos = line.IndexOf("P");
    //      var value = line.Substring(pPos + 1, line.Length - pPos - 1);
    //      _extruder2.Propotion = double.Parse(value);
    //    }
    //  }
    //}

   
    // change the language in real time 
    private void ChangeLanguage(string lang)
    {
      _currentLocale = new CultureInfo(lang);
      Settings.Default.Language = _currentLocale.Name;
      foreach (Control c in this.Controls)
      {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(ColorMixerForm));
        resources.ApplyResources(c, "$this");
        RefreshResources(this, resources);
      }
    }

    // refresh all the controls e sub-controls of the form 
    private void RefreshResources(Control ctrl, ComponentResourceManager res)
    {
      ctrl.SuspendLayout();
      res.ApplyResources(ctrl, ctrl.Name, _currentLocale);
      foreach (Control control in ctrl.Controls)
        RefreshResources(control, res); // recursion
      ctrl.ResumeLayout(false);
    }

    private void ComboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
    {
      ChangeLanguage(((CultureInfo)((ComboBox)sender).SelectedItem).Name);
    }

    private void ColorMixerForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.Save();
    }

    private void ToolStripButtonGenerateGcode_Click(object sender, EventArgs e)
    {
      GCodeRichTextBox.Clear();
      var extruderButtons = extruderTableLayoutPanel.Controls;
      foreach (var extruderButton in extruderButtons)
      {
        var extruder = (Button)extruderButton;
        _color.SetProportion(extruder.BackColor);

        // Cancel at Black or White color
        if (extruder.BackColor.Name.ToUpper() == "WHITE" || extruder.BackColor.Name.ToUpper() == "BLACK")
        {
          MessageBox.Show(this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        _extruder0.Propotion = _color.RedPropotion;
        _extruder1.Propotion = _color.GreenPropotion;
        _extruder2.Propotion = _color.BluePropotion;

        if (_extruder0.Propotion == 1 || _extruder1.Propotion == 1 || _extruder2.Propotion == 1)
        {
          if (_extruder0.Propotion == 1)
            _extruderNumber = 0;
          if (_extruder1.Propotion == 1)
            _extruderNumber = 1;
          if (_extruder2.Propotion == 1)
            _extruderNumber = 2;
        }
        else
        {
          _extruderNumber = int.Parse(extruder.Text);
        }
        WriteGCode(); 
      }
      GCodeRichTextBox.SelectAll();
      GCodeRichTextBox.Copy();
    }

    private void ButtonExtruder1_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder1_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder2_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder2_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder3_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder3_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder4_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder4_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder5_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder5_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder6_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder6_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder7_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder7_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder8_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder8_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder9_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder9_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder10_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder10_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder11_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder11_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder12_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder12_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder13_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder13_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder14_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder14_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder15_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder15_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
    private void ButtonExtruder16_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      ((Button)sender).BackColor = colorDialog.Color;
      Settings.Default.Extruder16_Color = colorDialog.Color;
      GCodeRichTextBox.Focus();
    }
  }
}
