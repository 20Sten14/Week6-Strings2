using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontpanic = ("Don't panic.").ToUpper();
            for (int i = dontpanic.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(dontpanic[i]);
            }
        }
    }
}
