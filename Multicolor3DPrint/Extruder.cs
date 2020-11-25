using System.Drawing;

namespace Multicolor3DPrint
{
  public class Extruder
  {
    public string Name;
    public int Number;
    public Color Color;
    
    internal string GetName()
    {
      return Name;
    }

    internal int GetNumber()
    {
      return Number;
    }

    internal Color GetColor()
    {
      return Color;
    }
  }
}
