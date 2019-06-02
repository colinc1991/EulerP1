using System;

namespace EulerP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (IsMultiple(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum of all multiples of 3 and 5 less than 1000 is {sum}");
        }

        public static bool IsMultiple(int numIn)
        {
            if (numIn % 3 == 0 || numIn % 5 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
