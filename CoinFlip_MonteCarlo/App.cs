using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip_MonteCarlo
{
    class Vector2
    {
        double X, Y;
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance() => Math.Sqrt(X * X + Y * Y);
    }

    class App
    {
        static Random rand = new Random();
        public App()
        {
            const int N = 1000000;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (CoinFlip())
                {
                    count++;
                }
            }
            Console.WriteLine((double)count / N);



            int[] probabilities = new int[51];

            for (int i = 0; i < N; i++)
            {
                probabilities[Roll10Dices() - 10]++;
            }

            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine($"Probability of {i + 10} is {(double)probabilities[i] / N}");

            }

            //Console.WriteLine($"10 Dices Sum : {sum}");

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (ShootDart())
                {
                    sum++;
                }
            }
            var pi = ((double)sum / N) * 4;

            Console.WriteLine($"pi is {pi}");


            Console.WriteLine($"Calculate Pi by Euler: {CalcPiByEuler(10000)}");

        }
        int Roll10Dices()
        {

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += RollDice();
            }
            return sum;
        }
        bool CoinFlip()
        {
            return rand.NextDouble() < 0.5;
        }

        int RollDice()
        {
            var a = rand.NextDouble();
            int sum = 0;
            if (a > 0.8333)
            {
                sum += 6;
            }
            else if (a > 0.6666)
            {
                sum += 5;
            }
            else if (a > 0.4999)
            {
                sum += 4;
            }
            else if (a > 0.3333)
            {
                sum += 3;
            }
            else if (a > 0.1666)
            {
                sum += 2;
            }
            else
            {
                sum += 1;
            }
            return sum;
        }

        bool ShootDart()
        {
            var vec = new Vector2(rand.NextDouble(), rand.NextDouble());

            return vec.Distance() <= 1.0 ? true : false;
        }

        double CalcPiByEuler(int N)
        {
            double sum = 0;

            for (int i = 1; i < N; i++)
            {
                sum += ((double)1 / (i * i));
            }

            return Math.Sqrt(sum * 6);
        }

    }
}
