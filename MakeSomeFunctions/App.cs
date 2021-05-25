using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSomeFunctions
{
    class App
    {
        public App()
        {
            //var a = 4;
            //var b = 7;
            //Console.WriteLine($"a:{a},b:{b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"a:{a},b:{b}---AfterSwap");

            //int[] values = { 5, 7, 3, 7, 1 };

            //ShowArr(values);

            //var min = Min(values);
            //Console.WriteLine(min);

            //var sum = Sum(values);

            //Console.WriteLine(sum);

            //var evenSum = EvenSum(values);

            //Console.WriteLine($"evenSum:{evenSum}");

            //var isContain = Contains(values, 9);

            //Console.WriteLine(isContain);

            //var mean = Mean(values);

            //Console.WriteLine(mean);

            //int d = 4, e = 6, f = 2;

            //float rootA, rootB;

            //(rootA, rootB) = Roots(d, e, f);
            //Console.WriteLine($"Quadratic Equation : {d}x^2+{e}x+{f}=0");
            //Console.WriteLine($"posRoot:{rootA},negRoot:{rootB}");

            int[] arr = { 5, 3, 7, 6, 9, 2 };

            ShowArr(arr);

            var arr2 = SelectionSort(arr);
            ShowArr(arr2);

            Console.WriteLine();

            ShowArr(arr);

            var arr3 = BubbleSort(arr);
            ShowArr(arr3);

            Console.WriteLine("Get Sqrt");
            Console.WriteLine(Math.Sqrt(3));

            Console.WriteLine(Sqrt(3));


        }
        #region Swap,Min,Sum...etc
        void ShowArr(int[] vs)
        {

            foreach (var v in vs)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
        public void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        int Min(int[] values)
        {
            int a = values[0];

            foreach (var v in values)
            {
                if (v < a)
                {
                    a = v;
                }
            }
            return a;
        }

        int Min2(int[] vs)
        {
            int result = int.MaxValue; //우리가 찾는 값은 미니멈이므로 최대치를 넣어준다.
            foreach (var v in vs)
            {
                if (v < result)
                {
                    result = v;
                }
            }
            return result;
        }
        int Sum(int[] vs)
        {
            var sum = 0;
            foreach (var v in vs)
            {
                sum += v;
            }
            return sum;
        }
        float EvenSum(int[] vs)
        {
            float sum = 0;
            foreach (var v in vs)
            {
                if (v % 2 == 0)
                {
                    sum += v;
                }
            }
            return sum;
        }
        bool Contains(int[] values, int value)
        {
            foreach (var v in values)
            {
                if (v == value)
                {
                    return true;
                }
            }
            return false;
        }
        float Mean(int[] values)
        {
            float sum = 0;
            foreach (var v in values)
            {
                sum += v;
            }
            return sum / values.Length;
        }
        #endregion

        //Make This Tuple
        (float, float) Roots(float a, float b, float c)
        {
            float positiveRoot;
            float negativeRoot;
            float discriminant = MathF.Sqrt((b * b) - (4 * a * c));
            Console.WriteLine($"discriminant : {discriminant}");

            positiveRoot = (-b + discriminant) / (2 * a);
            negativeRoot = (-b - discriminant) / (2 * a);

            return ((-b + discriminant) / (2 * a), (-b - discriminant) / (2 * a));
            //return (positiveRoot, negativeRoot);
        }

        #region Sorts
        int[] SelectionSort(int[] vs)
        {
            var vc = new int[vs.Length];
            vs.CopyTo(vc, 0);
            var result = new int[vs.Length];
            var temp = int.MaxValue;
            for (int i = 0; i < vc.Length; i++)
            {
                int k = 0;
                temp = int.MaxValue;
                for (int j = 0; j < vc.Length; j++)
                {
                    if (temp > vc[j])
                    {
                        temp = vc[j];
                        k = j;
                    }
                }
                result[i] = temp;
                vc[k] = int.MaxValue;
            }
            return result;
        }

        int[] BubbleSort(int[] vs)
        {
            var vc = new int[vs.Length];
            vs.CopyTo(vc, 0);
            int[] result = new int[vc.Length];

            for (int i = 0; i < vc.Length; i++)
            {
                for (int j = 0; j < vc.Length - i - 1; j++)
                {
                    if (vc[j] > vc[j + 1])
                    {
                        var temp = vc[j];
                        vc[j] = vc[j + 1];
                        vc[j + 1] = temp;
                    }
                }
            }
            result = vc;
            return result;
        }



        #endregion


        int[] InsertionSort(int[] vs)
        {
            var vc = new int[vs.Length];
            vs.CopyTo(vc, 0);
            int[] result = new int[vc.Length];



            return result;
        }


        double Sqrt(double t)
        {
            double Xn = 1;
            for (int i = 0; i < 10; i++)
            {
                Xn = Xn - ((Xn * Xn - t) / (2 * Xn));
            }
            return Xn;
        }

        static public void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int j = 1; j < array.Length; j++)
            {
                T key = array[j];
                int i = j - 1;
                while ((i < 0) && (array[i].CompareTo(key) > 0))
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }
                array[i + 1] = key;
            }
        }
    }
}
