using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Dealer : Player
    {
        public Dealer() : base() {
            
        }

        public bool shouldKeepGoing() {
            if (pointsTotal <= 16 || hand.Count == 2 && pointsTotal == 17)
            {
                //soft 17 so he has to continue
                return true;
            }else {
                return false;
            }
        }

        public override void push(ArrayList deck){
            manageDecks(deck);
            calculatePoints();   
        }

        private void manageDecks(ArrayList deck) {
            int cardIndex = random.Next(deck.Count);
            Card card = (Card)deck[cardIndex];
            hand.Add(card);
            deck.RemoveAt(cardIndex);
        }

        private void calculatePoints()
        {
            Card card = (Card)hand[hand.Count - 1];

            if (card.getValue() == "Ace")
            {

                if (pointsTotal >= 11)
                {
                    pointsTotal++;
                }
                else
                {
                    pointsTotal += 11;

                }
            }
            else
            {
                pointsTotal += card.getPoints();
            }
        }

        public int getVisibleCardPoints() {
            int points = pointsTotal;
            Card hidden = (Card)hand[0];
            if (hidden.getValue() == "Ace")
            {
                points -= 11;
            }
            else
            {
                points -= hidden.getPoints();
            }

            return points;
        }

        public string showAllCards()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hand.Count; i++)
            {
                sb.Append(hand[i].ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public override string showCards() {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hand.Count; i++)
            {
                if (i == 0)
                {
                    sb.Append("Hidden Card");
                }
                else {
                    sb.Append(hand[i].ToString());   
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public override int getPointsTotal() {
            return pointsTotal;
        }

    }
}
