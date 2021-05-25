using System;

namespace OverFlowException
{
    class Program
    {
        static void Main(string[] args)
        {
            //long l = 0xffffffff;
            //int i = (int)l;
            //uint u = 0xffffffff;

            //var i = 1;
            //Console.WriteLine(i / 0);

            var j = 1.0;
            Console.WriteLine(j / 0);

        }
    }
}
