using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class Player
    {
        protected static Random random = new Random();
        protected ArrayList hand = new ArrayList();

        protected int pointsTotal;

        public Player() {
            pointsTotal = 0;
        }

        public bool wentOver() {
            if (pointsTotal >= 22)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool hasBlackJack() {
            if (hand.Count == 2 && pointsTotal == 21)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public abstract void push(ArrayList deck);

        public abstract string showCards();

        public abstract int getPointsTotal();
    }
}
