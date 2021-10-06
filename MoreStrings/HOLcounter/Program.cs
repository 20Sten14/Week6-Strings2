using System;

namespace HOLcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWrold = "Hello World!";

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            foreach (char character in HelloWrold)
            {
                if (character == 'n')
                {
                    counter1++;
                }
            }
            foreach (char character in HelloWrold)
            {
                if (character == 'o')
                {
                    counter2++;
                }
            }
            foreach (char character in HelloWrold)
            {
                if (character == 'l')
                {
                    counter3++;
                }
            }
            Console.WriteLine($"{HelloWrold}s on {counter1} N tähte,  {counter2} O tähte ja {counter3} L tähte.");

        }
    }
}
