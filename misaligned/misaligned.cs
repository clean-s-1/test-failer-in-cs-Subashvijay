using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
    {
        static int printColorMap(string[] majorColors, string[] minorColors)
        {

            int i, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[j]);
                }
            }
            return i * j;
        }
        static void Main(string[] args)
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int result = printColorMap(majorColors, minorColors);
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
