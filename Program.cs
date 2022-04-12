using System;
using System.Threading;
namespace comnsole2
{
    class Program
    {
        static int iterations = 10;
        static int currentIteration = 0;
        static void Main(string[] args)
        {
            Recurs();
        }
        static void Recurs()
        {
            currentIteration++;
            Console.WriteLine(currentIteration);
            var thread=new Thread(delegate ()
            {
                Thread.Sleep(1000);
                if (currentIteration < iterations) Recurs();
            });
            thread.Start();
        }
    }
}
