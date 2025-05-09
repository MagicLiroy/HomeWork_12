using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
    internal class Circle
    {
        public const double PI = 3.12341242514;
        double radius, x0, y0, x1, y1;
        public Circle(double radius, double x0, double x1, double y0, double y1)
        {
            this.radius = radius;
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
        }
        static public double GetLength(double radius)
        {
            return 2 * PI * radius;
        }
        static public double GetSquare(double radius)
        {
            return PI * radius * radius;
        }

        static public bool GetBelong(double a, double x0, double x, double y, double y0)
        {
            return Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y)) <= a;
        }
    }
}
