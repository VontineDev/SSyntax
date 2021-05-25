using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace TreadAndTask
{
    class Program
    {
        static void Main(string[] args)
        {

            var srcFile = Console.ReadLine();
            //string srcFile = args[0];

            Action<object> FileCopyAction = (object state) =>
             {
                 string[] paths = (string[])state;
                 
                 
                 File.CreateText(paths[0]);
                 File.Copy(paths[0], paths[1]);

                 Console.WriteLine("TaskID:{0}, ThreadID:{1},  {2} was copied to {3}",
                                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);

                 Console.WriteLine($"TaskID:{Task.CurrentId}, ThreadID:{Thread.CurrentThread.ManagedThreadId},  {paths[0]} was copied to {paths[1]}");
             };

            Task t1 = new Task(
                FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
          {
              FileCopyAction(new string[] { srcFile, srcFile + ".copy2}" });
          });

            t1.Start();

            Task t3 = new Task(
                FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });
        }
    }
}
