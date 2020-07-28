using System;
using System.Reflection.Metadata;

namespace Geometry
{
    public class Triangle
    {
        public static double Area(double baseTri, double height) => (baseTri * height) / 2;

        public static double Hypoteneuse(double SideA, double SideB) => Math.Sqrt(SideA * SideA + SideB * SideB);
    }
}
