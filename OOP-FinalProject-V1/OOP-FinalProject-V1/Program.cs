using System;
using Cards;
using System.Collections.Generic;

namespace OOP_FinalProject_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            double pool = 0;

            
            while (playing)
            {
                var deck = new Deck();

                deck.Shuffle();
                List<Card> hand1 = deck.Sort(deck.TakeCards(2));
                List<Card> hand2 = deck.TakeCards(2);
                List<Card> hand3 = deck.TakeCards(2);
                List<Card> hand4 = deck.TakeCards(2);
                List<Card> river = deck.TakeCards(5);


                Console.WriteLine("Player 1 Cards:");
                Player player1 = new Player("Alex Blizzard", hand1, 1000);
                player1.playersCards.ForEach(Console.WriteLine);
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Player 2 Cards:");
                Player player2 = new Player("Zach Walton", hand2, 1000);
                player2.playersCards.ForEach(Console.WriteLine);
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Player 3 Cards:");
                Player player3 = new Player("Abdul Hamirani", hand3, 1000);
                player3.playersCards.ForEach(Console.WriteLine);
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Player 4 Cards:");
                Player player4 = new Player("Alaadin Addas", hand4, 1000);
                player4.playersCards.ForEach(Console.WriteLine);

                Console.WriteLine("_____________________________________");
                Console.WriteLine("River Cards:");
                Player riverman = new Player("Old Man River", river, 1000);
                Console.WriteLine(riverman.playersCards[0]);
                Console.WriteLine(riverman.playersCards[1]);

                Console.WriteLine("_____________________________________");
                Console.WriteLine("Betting Round 1:");

                Logic.bettingRound(pool, player1, player2, player3, player4);

                Console.WriteLine("The next card in the river is:");
                Console.WriteLine(riverman.playersCards[2]);

                Console.WriteLine("_____________________________________");
                Console.WriteLine("Betting Round 2:");

                Logic.bettingRound(pool, player1, player2, player3, player4);

                Console.WriteLine("The next card in the river is:");
                Console.WriteLine(riverman.playersCards[3]);

                Console.WriteLine("_____________________________________");
                Console.WriteLine("Betting Round 3:");

                Logic.bettingRound(pool, player1, player2, player3, player4);

                Console.WriteLine("The last card in the river is:");
                Console.WriteLine(riverman.playersCards[4]);

                Console.WriteLine("_____________________________________");
                Console.WriteLine("Final Betting Round");

                Logic.bettingRound(pool, player1, player2, player3, player4);

                Logic.determineWinner(player1, player2, player3, player4, riverman);

                Console.WriteLine("Would you like to play another round? (Y/N)");
                string response = Console.ReadLine();
                do
                {
                    if (response == "Y")
                    {
                        Console.WriteLine("Alright, let's start the next round!\n\n\n");

                    }else if (response == "N")
                    {
                        Console.WriteLine("Thank's for playing!");
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("Please answer Y for Yes or N for No");
                        response = Console.ReadLine();
                    }
                } while (response != "Y" && response != "N");
            }
        }
    }
}
