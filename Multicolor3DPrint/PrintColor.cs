using System.Drawing;

namespace Multicolor3DPrint
{
  public class PrintColor
  {
    public Color Color;
    public decimal ProportionOfRed;
    public decimal ProportionOfGreen;
    public decimal ProportionOfBlue;

    public byte Red { get; private set; }
    public byte Green { get; private set; }
    public byte Blue { get; private set; }

    internal void CalcProportion(Color color)
    {
      Red = color.R;
      Green = color.G;
      Blue = color.B;

      var hundredPercent = Red + Green + Blue;

      ProportionOfRed = (decimal)Red / hundredPercent;
      ProportionOfGreen = (decimal)Green / hundredPercent;
      ProportionOfBlue = (decimal)Blue / hundredPercent;

      Color = color;
    }
  }
}