using System;
using System.IO;
namespace DealingException
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);

                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e.Message}");


            }
            finally
            {
                Console.WriteLine("종료 in Finally");
            }
            Console.WriteLine("종료");



        }
    }
}
