using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Threads
    {
        private string name;
        private Random randomTimer;
        private int time;

        public Threads(string name, Random randomTimer) {
            this.name = name;
            this.randomTimer = randomTimer;
            time = randomTimer.Next(1000);
        }

        public void Run() {
            try
            {
                Console.WriteLine("Name: {0}, sleep time: {1}", name, time);
                Thread.Sleep(time);
                Console.WriteLine("{0} now awake", name);
            }
            catch (ThreadInterruptedException ignored){

            }
        }
    }
}
