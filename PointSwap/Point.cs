using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSwap
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

        public void PointSwap()
        {
            T swap;

            swap = x;
            x = y;
            y = swap;
        }

    }
}
