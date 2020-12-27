//Name: Seth Davis
//Class: CSE 1322L
//Section: 03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertBase(4873, 35));
            Console.WriteLine(ConvertBase(3, 3));
            Console.WriteLine(ConvertBase(14, 16));
            Console.ReadKey();

        }

        public static string ConvertBase(int n, int b) {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E',
                                'F', 'G', 'H', 'I', 'J',
                                'K', 'L', 'M', 'N', 'O',
                                'P', 'Q', 'R', 'S', 'T',
                                'U', 'V', 'W', 'X', 'Y', 'Z'}; 
            if (n < b)
            {
                if (n >= 10) {
                    return Char.ToString(alphabet[n - 10]);
                }
                return n.ToString();
            }
            else {
                int current = n % b;
                char placeVal;
                if (current >= 10)
                {
                    placeVal = alphabet[current - 10];
                }
                else {
                    placeVal = Char.Parse(current.ToString());
                }

                return ConvertBase(n / b, b) + placeVal;
            }
            
        }
    }


}
