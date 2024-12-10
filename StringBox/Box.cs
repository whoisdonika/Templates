using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBox
{
    public class Box
    {
        private string data;

        public Box(string data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{data.GetType().FullName} : {data}";
        }
    }
}
