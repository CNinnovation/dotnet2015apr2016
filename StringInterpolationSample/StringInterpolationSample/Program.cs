using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            string s = $"{today:D}";
            Console.WriteLine(s);

            int x = 3;
            int y = 5;
            FormattableString fs = $"{x} + {y} = {x + y}";

            Console.WriteLine(fs);

        }
    }
}
