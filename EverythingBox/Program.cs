using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var boxInt = new Box<int>(123123);
            var boxString = new Box<string>("life in a box");

            Console.WriteLine(boxInt.ToString());
            Console.WriteLine(boxString.ToString());
        }
    }
}
