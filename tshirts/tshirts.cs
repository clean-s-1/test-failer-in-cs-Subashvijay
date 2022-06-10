using System;
using System.Diagnostics;

namespace TshirtSpace
{
    class Tshirt
    {
        static string Size(int cms)
        {
            if (cms <= 38)
            {
                return "S";
            }

            if (cms is > 38 and < 42)
            {
                return "M";
            }

            return "L";
        }
        static void Main(string[] args)
        {
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
