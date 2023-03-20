using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerLibrary;


namespace Poker1b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var deck = new Deck();
            deck.Shuffle();

            List<Card> hand1 = deck.Sort(deck.TakeCards(2));
            List<Card> hand2 = deck.TakeCards(2);
            List<Card> hand3 = deck.TakeCards(2);
            List<Card> hand4 = deck.TakeCards(2);
            List<Card> river = deck.TakeCards(5);

            Console.WriteLine("Player 1 Cards:");
            Player player1 = new Player("Alex Blizzard", hand1);
            player1.playersCards.ForEach(Console.WriteLine);
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Player 2 Cards:");
            Player player2 = new Player("Zach Walton", hand2);
            player2.playersCards.ForEach(Console.WriteLine);
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Player 3 Cards:");
            Player player3 = new Player("Abdul Hamirani", hand3);
            player3.playersCards.ForEach(Console.WriteLine);
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Player 4 Cards:");
            Player player4 = new Player("Alaadin Addas", hand4);
            player4.playersCards.ForEach(Console.WriteLine);

            Console.WriteLine("_____________________________________");
            Console.WriteLine("River Cards:");
            Player riverman = new Player("Old Man River", river);
            riverman.playersCards.ForEach(Console.WriteLine);

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Player 1 Hand + River Cards:");

            Logic.determineWinner(player1, player2, player3, player4, riverman);

            Console.ReadKey();
        }
    }
}
