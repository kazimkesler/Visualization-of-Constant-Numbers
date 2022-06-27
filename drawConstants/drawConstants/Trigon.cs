using System;
using System.Drawing;
public static class Trigon
{
    public enum Regions { First, Second, Third, Fourth }
    public static double Slope(Point A, Point B)
    {
        double m = (double)Math.Abs(B.Y - A.Y) / Math.Abs(B.X - A.X);
        if (A.X <= B.X && A.Y < B.Y)
            return m = -m;
        else if (A.X >= B.X && A.Y > B.Y)
            return m = -m;
        return m;
    }
    public static double SlopeAngle(double slope) { return Math.Atan(slope); }
    public static double RadiantoDegree(double radian) { return (double)(radian * 180 / Math.PI); }
    public static double DegreeToRadian(double degree) { return degree * Math.PI / 180.0; }
    public static Regions Degree360(ref double degree, Point point, Point origin)
    {
        if (point.X <= origin.X && point.Y < origin.Y)
        {
            degree = 180 - degree;
            return Regions.Second;
        }
        else if (point.X < origin.X && point.Y >= origin.Y)
        {
            degree = 180 + degree;
            return Regions.Third;
        }
        else if (point.X >= origin.X && point.Y > origin.Y)
        {
            degree = 360 - degree;
            return Regions.Fourth;
        }
        else return Regions.First;
    }
    public static PointF CosAndSin(double degree)
    {
        return new PointF((float)Math.Cos(degree), (float)Math.Sin(degree));
    }
}
