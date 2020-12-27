using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Formula : FindFib
    {
        int fibIndex;
        decimal fibNum;

        public Formula(int index) {
            fibIndex = index;
            fibNum = CalculateF(index);
        }

        public decimal CalculateF(int n) {
            return Math.Round(((decimal)Math.Pow(((1 + Math.Sqrt(5)) / 2), n) - (decimal)Math.Pow(1 - Math.Sqrt(5) / 2, n)) / (decimal)Math.Sqrt(5));
        }

        public string toString() {
            string ordinal;
            switch (fibIndex) {
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
