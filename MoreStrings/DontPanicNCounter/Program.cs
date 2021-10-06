using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontpanic = ("dont panic").ToUpper();

            int counter = 0;

            foreach (char character in dontpanic)
            {
                if (character == 'N')
                {
                    counter++;
                }
            }
            Console.WriteLine($"{dontpanic}s on {counter} N tähte");
        }
    }
}
