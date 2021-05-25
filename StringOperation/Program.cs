using System;

namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World!";
            var s2 = "Hello" + " World!";
            var s3 = 2 + "Hello";
            var s4 = 2 + 3 + "Hello";
            var s5 = "Hello" + 2;
            var s6 = "Hello" + 2 + 3;

            var i1 = int.Parse("123");
            var i2 = int.Parse("abc");

            var i3 = 0;
            var ok = int.TryParse("123", out i3);

            ok = int.TryParse("abc", out i3);

        }
    }
}
