using System.Collections.Generic;

namespace Multicolor3DPrint
{
  public partial class Machine
  {
    public int NumberOfExtruders;
    public int NumberOfVirtualTools;
    public HotEndTyp HotEnd;
    public PrintColor PrintColor;
    public List<Extruder> Extruders;
    public List<Extruder> VirtualTools;

    public Machine()
    {
      Extruders = new List<Extruder>();
      VirtualTools = new List<Extruder>();
      PrintColor = new PrintColor();
    }
  }
}
