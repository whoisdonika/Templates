using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPoint
{
    public class Point<T>
    {
        private T x, y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public string Print()
        {
            return $"x = {this.x} \ny = {this.y}";
        }

        public static Point<double> FindMidpoint(Point<T> p1, Point<T> p2)
        {
            double x1 = Convert.ToDouble(p1.X);
            double y1 = Convert.ToDouble(p1.Y);
            double x2 = Convert.ToDouble(p2.X);
            double y2 = Convert.ToDouble(p2.Y);

            double xMidpoint = (x1 + x2) / 2;
            double yMidpoint = (y1 + y2) / 2;
            return new Point<double>(xMidpoint, yMidpoint);
        }
    }
}
