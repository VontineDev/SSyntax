using System;
using System.Threading;
namespace ThreadPractice2_Locking
{
    class Program
    {
        public static int gold;
        //lock에 사용될 객체
        public static object lockGold = new object();
        static void Main(string[] args)
        {
            Program.gold = 0;

            Thread thread0 = new Thread(() => Hunt());
            thread0.Start();
            Thread thread1 = new Thread(() => BuyItem());
            thread1.Start();

            Console.WriteLine($"골드 양 {Program.gold}");

        }

        private static void BuyItem()
        {
            Console.WriteLine("아이템 구매 시작");

            for (int i = 0; i < 100; i++)
            {
                lock (Program.lockGold)
                {
                    Program.gold -= 1;
                    Console.WriteLine($"소비후 골드 {Program.gold}");
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("아이템 구매 종료");

        }

        private static void Hunt()
        {
            Console.WriteLine("사냥 시작");

            for (int i = 0; i < 100; i++)
            {
                lock (Program.lockGold)
                {
                    Program.gold += 10;
                    Console.WriteLine($"사냥후    골드 {Program.gold}");
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("사냥 종료");

        }
    }
}
