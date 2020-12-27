using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Palindrome
    {
        string possiblePalindrome;

        bool checkPalindrome = false;

        public Palindrome() : this("racecar") {

        }

        public Palindrome(string toCheck) {
            possiblePalindrome = toCheck;
            checkPalindrome = isPalindrome(toCheck);
        }

        public bool isPalindrome(string possiblePalindrome) {
            if (possiblePalindrome.Length <= 1) {
                return true;
            } else {
                return (possiblePalindrome[0] == possiblePalindrome[possiblePalindrome.Length - 1]) && isPalindrome(possiblePalindrome.Substring(1, possiblePalindrome.Length - 2));
            }
        }

        public bool getCheckPalindrome() {
            return checkPalindrome;
        }

        public string getPossiblePalindrome() {
            return possiblePalindrome;
        }

        public override string ToString()
        {
            string isOrIsnt = "";
            if (!checkPalindrome) isOrIsnt = "not ";
            return String.Format("The word {0} is {1}a palindrome.", possiblePalindrome, isOrIsnt);
        }

    }
}
