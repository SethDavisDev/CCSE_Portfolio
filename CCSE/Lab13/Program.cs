//Name: Seth Davis
//Class Name: cse 1322L
//Section: 03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Threads th1 = new Threads("Thread 1", rand);
            Threads th2 = new Threads("Thread 2", rand);
            Thread thread1 = new Thread(th1.Run);
            Thread thread2 = new Thread(th2.Run);
            thread1.Start();
            thread2.Start();
        
            Console.ReadKey();
        }
    }
}
