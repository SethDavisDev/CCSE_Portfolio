using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] arr1 = new char[10][];
            char[][] arr2 = new char[10][];
            char[][] arr3 = new char[10][];
            char[][] arr4 = new char[10][];

            int numStars = 1;
            int numUnders = 4;
            //loop through the outer array once
            for (int i = 0; i < arr1.Length; i++)
            {
                /*call method that builds the inner character array based on how
                 * many of each symbol should be added
                 */
                arr1[i] = fillBoardLine('*','_',arr1.Length - i, 10 - (arr1.Length - i), 10);
                arr2[i] = fillBoardLine('_', '*',10 - (i + 1) , (i + 1) , 10);
                arr3[i] = fillBoardLine('_', '*', i, arr1.Length - i, 10);
                arr4[i] = fillBoardLine('-', '*',numUnders, numStars, 10);

                if (i < 4) {
                    numStars += 2;
                    numUnders -= 1;
                }
                if (i > 4) {
                    numStars -= 2;
                    numUnders += 1;
                }
            }

            //print the arrays
            Console.WriteLine("Board A");
            print(arr1);
            Console.WriteLine();
            Console.WriteLine("Board B");
            print(arr2);
            Console.WriteLine();
            Console.WriteLine("Board C");
            print(arr3);
            Console.WriteLine();
            Console.WriteLine("Board D");
            print(arr4);
            Console.ReadKey();
        }

        public static void print(char[][] board) {
            for (int a = 0; a < board.Length; a++)
            {
                for (int b = 0; b < board[a].Length; b++)
                {
                    Console.Write(board[a][b]);
                }
                Console.WriteLine();
            }
        }
        
        //function for building any given line of the pattern 
        public static char[] fillBoardLine(char first, char sec, int numFirst, int numSec, int lineLength)
        {
            //temp that holds the chars we build
            char[] line = new char[lineLength];
            //figures out if we have empty space
            int totalChars = numSec + numFirst;
            int numEmpty = lineLength - (numFirst + numSec);

            //goes through each element of our pattern line array
            for (int i = 0; i < lineLength; i++)
            {
                //add first character until we run out of them
                if (i < numFirst)
                {
                    line[i] = first;
                }
                //using else if and total chars here instead of math 
                else if (i < totalChars)
                {
                    line[i] = sec;
                }
                //this might be useless because initialized char arrays might already have spaces in them
                if (i >= totalChars && i < lineLength)
                {
                    line[i] = ' ';
                }
            }
            return line;
        }
    }
}
