using System;
namespace MyLib
{
    public static class Xyz
    {
        public static double MySquare(this int x) => x * x;
        public static double MySquareRoot(this int x) => Math.Sqrt(x);

        public static double MySin(this int x) => Math.Sin(x);

        public static double MyCos(this int x) => Math.Cos(x);
    }
}