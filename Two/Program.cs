using System.Collections.Generic;
using System;
using System.IO;

namespace csharp
{
    public class Program
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("..\\..\\..\\Input.txt");
            int sum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                sum += getRequiredFuel(int.Parse(input[i]));
            }

            Console.WriteLine("{0} fuel required.", sum);
        }

        public static int evaluate(int opcode)
        {
            int result = 0;

            if(mass < 3)
            {
                return 0;
            }

            result = (mass / 3) - 2;
            return result;
        }
    }
}
