using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Card
    {
        string value;
        string suit;
        bool isFace;
        int points;

        public Card(string val, string su) {
            value = val;
            suit = su;
            isFace = checkFace();
            points = checkPoints();
        }

        public string getValue() {
            return value;
        }

        public string getSuit(){
            return suit;
        }

        public bool getIsFace() {
            return isFace;
        }

        public int getPoints() {
            return points;
        }

        public bool checkFace() {
            if (value == "Jack" || value == "Queen" || value == "King") return true;
            else return false;    
        }

        public int checkPoints() {
            if (isFace) return 10;
            else if (Int32.TryParse(value, out int result))
            {
                return result;
            }
            else {
                //value is either ace or not a correct card value
                //either way we handle aces seperately because of their 
                //high low behavior 
                return 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", value, suit);
        }
    }
}
