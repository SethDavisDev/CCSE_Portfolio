//Name: Seth Davis
//Class Name: CCSE 1322L 
//section: 03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p1 = new Palindrome("rotor");
            Palindrome p2 = new Palindrome("iceburg");
            Palindrome p3 = new Palindrome("tattarrattat");

            Console.WriteLine(p1.getPossiblePalindrome() + " - return " + p1.getCheckPalindrome() +" - "+ p1.ToString());
            Console.WriteLine(p2.getPossiblePalindrome() + " - return " + p2.getCheckPalindrome() + " - " + p2.ToString());
            Console.WriteLine(p3.getPossiblePalindrome() + " - return " + p3.getCheckPalindrome() + " - " + p3.ToString());
            Console.ReadKey();
        }
    }
}
