//Name: Seth Davis
//Class Name: cse 1322L 
//section: 03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion r = new Recursion(40);
            Console.WriteLine(r.toString());
            Formula f = new Formula(40);
            Console.WriteLine(f.toString());
            Iteration iter = new Iteration(40);
            Console.WriteLine(iter.toString());
            Console.ReadKey();
        }
    }
}
