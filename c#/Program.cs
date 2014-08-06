using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var I = 1; I <= 100; I++)
            {
                Console.WriteLine(FizzBuzz.GetTheFizz(I));
            }
            Console.Read();
        }
    }
}
