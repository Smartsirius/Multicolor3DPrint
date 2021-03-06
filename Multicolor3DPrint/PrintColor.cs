﻿using System.Drawing;

namespace Multicolor3DPrint
{
  public class PrintColor
  {
    public Color Color;
    public double ProportionOfRed;
    public double ProportionOfGreen;
    public double ProportionOfBlue;

    public byte Red { get; private set; }
    public byte Green { get; private set; }
    public byte Blue { get; private set; }

    internal void CalcProportion(Color color)
    {
      Red = color.R;
      Green = color.G;
      Blue = color.B;

      var hundredPercent = Red + Green + Blue;

      ProportionOfRed = (double)Red / hundredPercent;
      ProportionOfGreen = (double)Green / hundredPercent;
      ProportionOfBlue = (double)Blue / hundredPercent;

      Color = color;
    }
  }
}