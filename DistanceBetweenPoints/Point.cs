using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
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
        public double DistanceTo(Point<T> other)
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);

            double x2 = Convert.ToDouble(other.X);
            double y2 = Convert.ToDouble(other.Y);

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

