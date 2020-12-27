//Name: Seth Davis
//Class: CSE 1322L
//Section: 03
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //gettting the gamblers
            Console.WriteLine("How many players are there?");
            int numPlayers = Int32.Parse(Console.ReadLine());
            Gambler[] players = new Gambler[numPlayers];
            for (int i = 0; i < numPlayers; i++)
            {
                players[i] = new Gambler();
            }
            //and the dealer
            Dealer dealer = new Dealer();
            //setting up the deck of cards
            ArrayList standardDeck = new ArrayList();
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"  };
            string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
            values.Reverse();
            for (int i = 0; i < suits.Length; i++)
            {
                if (suits[i] == "Clubs") Array.Reverse(values);
                for (int j = 0; j < values.Length; j++)
                {
                    standardDeck.Add(new Card(values[j], suits[i]));
                }
            }

            //The Game

            //dealing the cards
            for (int i = 0; i < players.Length; i++)
            {
                players[i].push(standardDeck);
                Console.WriteLine("Player {0} has ", i + 1);
                Console.WriteLine(players[i].showCards()); 
            }
            dealer.push(standardDeck);
            Console.WriteLine("Dealer has:");
            Console.WriteLine(dealer.showCards());

            for (int i = 0; i < players.Length; i++)
            {
                players[i].push(standardDeck);
                Console.WriteLine("Player {0} has ", i + 1);
                Console.WriteLine(players[i].showCards());
            }
            dealer.push(standardDeck);
            Console.WriteLine("Dealer has:");
            Console.WriteLine(dealer.showCards());
            Console.WriteLine("Cards delt. Press enter to start");
            Console.ReadKey();
            //check for naturals
            bool gameOver = false;
            if (dealer.hasBlackJack()) {
                Console.WriteLine("Dealer has blackjack");
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].hasBlackJack())
                    {
                        Console.WriteLine("Player {0} tied with the dealer!", i + 1);
                    }
                    else {
                        Console.WriteLine("Player {0} lost", i + 1);
                    }
                }
                gameOver = true;
            }
            else {
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].hasBlackJack()) {
                        Console.WriteLine("Player {0} beat the dealer!", i + 1);
                        gameOver = true;
                    }
                }
            }
            

            if(!gameOver)
            {
                Console.Clear();
                for (int i = 0; i < players.Length; i++)
                {
                    int options = 0;
                    Console.WriteLine("Player {0}'s turn:", i + 1);
                    Console.WriteLine();
                    //each player's turn
                    while (options != 2)
                    {  
                        Console.WriteLine("Dealers Hand:");
                        Console.WriteLine(dealer.showCards());
                        Console.WriteLine("Points: " + dealer.getVisibleCardPoints());
                        Console.WriteLine();
                        Console.WriteLine("Your hand:");
                        Console.WriteLine(players[i].showCards());
                        if (players[i].getLowPoints() == players[i].getPointsTotal())
                        {
                            Console.WriteLine("Points: " + players[i].getPointsTotal());
                        }
                        else
                        {
                            Console.WriteLine("Points: {0},{1}", players[i].getLowPoints(), players[i].getPointsTotal());
                        }

                        Console.WriteLine("1. Hit, 2. Stay (type number for option)");
                        options = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (options)
                        {
                            case 1:
                                players[i].push(standardDeck);
                                break;
                            case 2:
                                break;

                        }
                        if (players[i].wentOver()) {
                            options = 2;
                        }
                        if (i < players.Length - 1)
                        {
                            Console.WriteLine("Next player's turn");
                        }
                        else {
                            Console.WriteLine("Dealer's turn");
                        }

                    }  
                }
                //dealers turn
                if (dealer.shouldKeepGoing()) {
                    dealer.push(standardDeck);
                }

                Console.WriteLine("Dealers Hand:");
                Console.WriteLine(dealer.showAllCards());
                Console.WriteLine("Points: " + dealer.getPointsTotal());
                if(dealer.wentOver()) Console.WriteLine("The Dealer busted!");
                Console.WriteLine();
                Console.WriteLine("Players' hands:");


                for (int i = 0; i < players.Length; i++)
                {
                    Console.WriteLine(players[i].showCards());
                    Console.WriteLine("Points: " + players[i].getPointsTotal());
                    if (players[i].wentOver()) {
                        Console.WriteLine("Player {0} busted!", i + 1);
                        continue;
                    }
                    if (players[i].getPointsTotal() > dealer.getPointsTotal() || dealer.wentOver())
                    {
                        Console.WriteLine("Player {0} beat the dealer!", i + 1);
                        continue;
                    }
                    else if (players[i].getPointsTotal() < dealer.getPointsTotal() && !dealer.wentOver()) {
                        Console.WriteLine("Player {0} lost to the dealer", i + 1);
                        continue;
                    }
                }
                

            }

            
   
            Console.ReadKey();
        }

    }
}
