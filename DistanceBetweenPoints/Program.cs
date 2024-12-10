using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 = new Point<double>(1.0, 2.0);
            Point<double> point2 = new Point<double>(4.0, 6.0);
           
            double distance = point1.DistanceTo(point2);
            Console.WriteLine(distance);
        }
    }
}
