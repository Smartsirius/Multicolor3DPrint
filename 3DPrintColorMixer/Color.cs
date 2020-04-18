using System;

namespace ColorMixer
{
  class Color
  {
    internal double Red { get; private set; }
    internal double Green { get; private set; }
    internal double Blue { get; private set; }

    internal double RedPropotion { get; private set; }
    internal double GreenPropotion { get; private set; }
    internal double BluePropotion { get; private set; }
    internal System.Drawing.Color ActiveColor { get; set; }

    public Color()
    {
    }

    internal void SetProportion(System.Drawing.Color color)
    {
      Red = color.R;
      Green = color.G;
      Blue = color.B;

      var hundredPercent = Red + Green + Blue;

      RedPropotion = Red / hundredPercent;
      GreenPropotion = Green / hundredPercent;
      BluePropotion = Blue / hundredPercent;

      ActiveColor = color;
    }

    //internal void Set(double redP, double greenP, double blueP)
    //{
    //  RedPropotion = redP;
    //  GreenPropotion = greenP;
    //  BluePropotion = blueP;

    //  ActiveColor = System.Drawing.Color.FromArgb(255, (int)Red, (int)Green, (int)Blue);
    //}
  }
}
