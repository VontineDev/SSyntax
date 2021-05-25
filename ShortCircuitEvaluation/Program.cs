using System;

namespace ShortCircuitEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (func2() && func1())
            {
                Console.WriteLine("IF");

            }
            else
            {
                Console.WriteLine("ELSE");

            }
        }

        static bool func1()
        {
            Console.WriteLine("func1");
            return false;

        }
        static bool func2()
        {
            Console.WriteLine("func2");
            return true;
        }

    }
}
