using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyList
{
    class App
    {

        public App()
        {
            int a = 3;
            int b = 4;

            float c = 3.5f;
            float d = 4.6f;


            var e = Add<int>(a, b);
            Console.WriteLine(e);

        }

        public T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;

            return a + b;
        }

    }

}
