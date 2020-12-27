using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Recursion : FindFib
    {
        int fibIndex;
        decimal fibNum;

        public Recursion(int index)
        {
            fibIndex = index;
            fibNum = CalculateF(index);
        }

        public int getIndex() {
            return fibIndex;
        }

        public void setIndex(int i) {
            fibIndex = i;
            CalculateF(i);
        }

        public decimal CalculateF(int n)
        {
            return helper(n, 1, 1);
        }

        /*
         * Fib(n) 
         *      if n == 1
         *          return 1
         *      elif n == 2
         *          return 1
         *      else
         *          return Fib(n-2) + Fib(n-1)
         *      end
         * end
         * */


        public decimal helper(int index, ulong firstNum, ulong secondNum) {
            if (index == 1)
            {
                return firstNum;
            }
            else if (index == 2)
            {
                return secondNum;
            }
            else return helper(index - 1, secondNum, firstNum + secondNum);
        }


        public string toString()
        {
            string ordinal;
            switch (fibIndex)
            {
                case 1:
                    ordinal = "st";
                    break;
                case 2:
                    ordinal = "nd";
                    break;
                case 3:
                    ordinal = "rd";
                    break;
                default:
                    ordinal = "th";
                    break;
            }

            return String.Format("the {0}{1} number of the fibonacci sequence is {2}", fibIndex, ordinal, fibNum);

        }

    }
}
