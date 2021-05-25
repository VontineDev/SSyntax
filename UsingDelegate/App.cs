using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate
{
    class App
    {
        delegate int MyDelegate(int a, int b);

        //Action<int, int> act;
        //Func<int, int, int> func;

        class Calc
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }

            public void VoidPlus(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void VoidMinus(int a, int b)
            {
                Console.WriteLine(a - b);
            }

        }

        public App()
        {
            Calc calc = new Calc();
            MyDelegate Callback;
            Action<int, int> actIntInt;

            Func<int, int, int> funcIntIntInt;
            Callback = new MyDelegate(calc.Plus);
            
            //Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(calc.Minus);

            //Console.WriteLine(Callback(3, 4));


            actIntInt = new Action<int, int>(calc.VoidPlus)
                      + new Action<int, int>(calc.VoidMinus);

            actIntInt(4, 5);

            funcIntIntInt = new Func<int, int, int>(calc.Plus);


            var ans = funcIntIntInt(3, 4);
            Console.WriteLine(ans);




        }
    }
}
