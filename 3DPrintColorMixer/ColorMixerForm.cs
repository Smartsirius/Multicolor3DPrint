using _3DPrintColorMixer.Properties;
using System;
using System.ComponentModel;
using System.Globalization;
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

    internal ColorMixerForm()
    {
      InitializeComponent();
      _currentLocale = new CultureInfo(Settings.Default.Language.ToString());
      ChangeLanguage(_currentLocale.Name);
      comboBoxLanguages.Items.Add(new CultureInfo("de-DE"));
      comboBoxLanguages.Items.Add(new CultureInfo("en-US"));
      comboBoxLanguages.DisplayMember = "DisplayName";
      comboBoxLanguages.ValueMember = "ShortName";
      comboBoxLanguages.Sorted = true;

      int idx = comboBoxLanguages.Items.IndexOf(_currentLocale);
      comboBoxLanguages.SelectedIndex = idx;

      // add mathematics to calculate back to color
      buttonCalcColorFromGcode.Enabled = false;

      //initalize extruder color buttons
      buttonE0.BackColor = System.Drawing.Color.Red;
      buttonE1.BackColor = System.Drawing.Color.Green;
      buttonE2.BackColor = System.Drawing.Color.Blue;

      _extruderNumber = 0;

      _color = new Color();

      _extruder0 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Red);
      _extruder0.Color = _color;
      _extruder0.Propotion = (int)_color.Red;

      _extruder1 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Green);
      _extruder1.Color = _color;
      _extruder1.Propotion = (int)_color.Green;

      _extruder2 = new Extruder();
      _color.SetProportion(System.Drawing.Color.Blue);
      _extruder2.Color = _color;
      _extruder2.Propotion = (int)_color.Blue;

    }

    private void ButtonCalcFromColor_Click(object sender, EventArgs e)
    {

      colorDialog.ShowDialog();

      _color.SetProportion(colorDialog.Color);

      // Cancel at Black or White color
      if (colorDialog.Color.Name.ToUpper() == "WHITE" || colorDialog.Color.Name.ToUpper() == "BLACK")
      {
        MessageBox.Show(this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      _extruder0.Color = _color;
      _extruder0.Propotion = (int)(_color.RedPropotion);
      _extruder1.Color = _color;
      _extruder1.Propotion = (int)(_color.GreenPropotion);
      _extruder2.Color = _color;
      _extruder2.Propotion = (int)(_color.BluePropotion);

      buttonLED.BackColor = _color.ActiveColor;
      if (_extruder0.Propotion == 100 || _extruder1.Propotion == 100 || _extruder2.Propotion == 100)
      {
        if (_extruder0.Propotion == 100)
          _extruderNumber = 0;
        if (_extruder1.Propotion == 100)
          _extruderNumber = 1;
        if (_extruder2.Propotion == 100)
          _extruderNumber = 2;
      }
      else
      {
        _extruderNumber = 4;
      }
      WriteGCode();
    }

    private void WriteGCode()
    {
      gcodeTextBox.Text = string.Format("M163 S0 P{0:f}\nM163 S1 P{1:f}\nM163 S2 P{2:f}\nM164 S{3}\nT{3}\n",
        (double)_extruder0.Propotion,
        (double)_extruder1.Propotion,
        (double)_extruder2.Propotion,
        _extruderNumber);
      gcodeTextBox.SelectAll();
      gcodeTextBox.Copy();
    }

    private void ButtonCalcFromGcode_Click(object sender, EventArgs e)
    {
      ParseGCode(gcodeTextBox.Text);

      // The sum of the extruder propotions can not be higher than 100 percent
      if (_extruder0.Propotion + _extruder1.Propotion + _extruder2.Propotion > 100)
      {
        MessageBox.Show(this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      _color.Set(_extruder0.Propotion, _extruder1.Propotion, _extruder2.Propotion);
      buttonLED.BackColor = _color.ActiveColor;
    }

    private void ParseGCode(string gcode)
    {
      string[] lines = gcode.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      foreach (var line in lines)
      {
        if (line.Contains("M163 S0 P"))
        {
          int pPos = line.IndexOf("P");
          var value = line.Substring(pPos + 1, line.Length - pPos - 1);
          _extruder0.Propotion = (int)double.Parse(value);
        }
        if (line.Contains("M163 S1 P"))
        {
          int pPos = line.IndexOf("P");
          var value = line.Substring(pPos + 1, line.Length - pPos - 1);
          _extruder1.Propotion = (int)double.Parse(value);
        }
        if (line.Contains("M163 S2 P"))
        {
          int pPos = line.IndexOf("P");
          var value = line.Substring(pPos + 1, line.Length - pPos - 1);
          _extruder2.Propotion = (int)double.Parse(value);
        }
      }
    }

    private void buttonE0_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      buttonE0.BackColor = colorDialog.Color;
    }

    private void buttonE1_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      buttonE1.BackColor = colorDialog.Color;
    }

    private void buttonE2_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      buttonE2.BackColor = colorDialog.Color;
    }

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

    private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
    {
      ChangeLanguage(((CultureInfo)((ComboBox)sender).SelectedItem).Name);
      buttonCalcGcodeFromColor.Focus();
    }

    private void ColorMixerForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.Save();
    }
  }
}
