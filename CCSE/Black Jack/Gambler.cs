using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Gambler : Player
    {
        int lowestPoints;

        public Gambler() {
            lowestPoints = 0;
        }

        public override void push(ArrayList deck)
        {
            manageDecks(deck);
            calculatePoints();
        }

        private void manageDecks(ArrayList deck)
        {
            int cardIndex = random.Next(deck.Count);
            Card card = (Card)deck[cardIndex];
            hand.Add(card);
            deck.RemoveAt(cardIndex);
        }

        private void calculatePoints()
        {
            int numAces = 0;
            Card card = (Card)hand[hand.Count - 1];

            if (card.getValue() == "Ace")
            {
                lowestPoints++;
                if (pointsTotal >= 11)
                {
                    pointsTotal++;
                }
                else {
                    pointsTotal += 11;

                }
            }
            else {
                pointsTotal += card.getPoints();
                lowestPoints += card.getPoints();
            }
            if (pointsTotal == 21) lowestPoints = pointsTotal;
            if (pointsTotal > 21) pointsTotal = lowestPoints;
            
        }

        public override string showCards()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hand.Count; i++)
            {
                sb.Append(hand[i].ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }
    

        public override int getPointsTotal()
        {
            return pointsTotal;
        }
        public int getLowPoints() {
            return lowestPoints;
        }
    }
}
