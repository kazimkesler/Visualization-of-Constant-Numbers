using System;
using System.Drawing;
public static class Trigonometry
{
    public static double DegreeToRadian(double degree)
    {
        return degree * Math.PI / 180.0;
    }
    public static PointF UnitPoint(double degree)
    {
        return new PointF((float)Math.Cos(degree), (float)Math.Sin(degree));
    }
}
