using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace Multicolor3DPrint
{
  public class Settings
  {
    private string applicationPath;
    private string settingsFile;

    public CultureInfo Language;
    public Machine Machine;

    public Settings()
    {
      applicationPath = AppDomain.CurrentDomain.BaseDirectory;
      settingsFile = Path.Combine(applicationPath, @"settings.json");
      Language = new CultureInfo("en-US", false);
      Machine = new Machine();
      Machine.HotEnd = Machine.HotEndTyp.Seperate;
      Machine.NumberOfExtruders = 1;
      Machine.NumberOfVirtualTools = 1;
    }

    public void WriteSettings()
    {
      JsonSerializer serializer = new JsonSerializer();

      using (StreamWriter sw = new StreamWriter(settingsFile))
      using (JsonWriter writer = new JsonTextWriter(sw))
      {
        serializer.Serialize(writer, this);
      }
    }

    public void ReadSettings()
    {
      if (!File.Exists(settingsFile))
        return;

      string content;
      using (StreamReader reader = new StreamReader(settingsFile))
      {
        content = reader.ReadToEnd();
        Settings newSettings = JsonConvert.DeserializeObject<Settings>(content);

        if (newSettings == null)
          return;

        Language = newSettings.Language;
        if (Language == null)
        {
          Language = new CultureInfo("en-US", false);
        }

        Machine.NumberOfExtruders = newSettings.Machine.NumberOfExtruders;
        if (Machine.NumberOfExtruders == 0)
        {
          Machine.NumberOfExtruders = 1;
        }

        Machine.NumberOfVirtualTools = newSettings.Machine.NumberOfVirtualTools;
        if (Machine.NumberOfVirtualTools == 0)
        {
          Machine.NumberOfVirtualTools = 1;
        }

        Machine.HotEnd = newSettings.Machine.HotEnd;

        Machine.VirtualTools = newSettings.Machine.VirtualTools;
        if (Machine.VirtualTools == null)
        {
          Machine.VirtualTools = new List<Extruder>
          {
            new Extruder() { Number = 1, Color = Color.White }
          };
        }
        Machine.Extruders = newSettings.Machine.Extruders;
        if (Machine.Extruders == null)
        {
          Machine.Extruders = new List<Extruder>
          {
            new Extruder() { Number = 0, Color = Color.White }
          };
        }
      }
    }
  }
}