using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Iteration
    {
        int fibIndex;
        decimal fibNum;

        public Iteration(int index) {
            fibIndex = index;
            fibNum = CalculateF(index);
        }

        public decimal CalculateF(int fibIndex) {
            int numOne = 1;
            int numTwo = 1;
            int sum = 0;
            for (int i = 1; i < fibIndex; i++) {
                sum = numOne + numTwo;
                numOne = numTwo;
                numTwo = sum;
            }
            return (decimal)numOne;
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
