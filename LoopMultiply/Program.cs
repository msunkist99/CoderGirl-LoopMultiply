using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());
            int total = 0;

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 
            for (int i = 2; i < 21; i++)
            {
                total += (number * i);
                Console.WriteLine((number * i) + " - " + total);
            }

            // TODO: When the loop is finished, output the sum of all previous values.
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
