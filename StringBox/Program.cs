using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many boxes would you like to add? - ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write( $"Enter the data for box number {i} : ");
                string data = Console.ReadLine();

                Box box = new Box(data);

                Console.WriteLine( box.ToString());
            }
        }
    }
}
