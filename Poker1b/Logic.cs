using PokerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker1b
{
    internal class Logic
    {


        public int RoyalFlush = 10;
        public int StrightFlush = 9;
        public int FourofaKind = 8;
        public int FullHouse = 7;
        public int Flush = 6;
        public int Straight = 5;
        public int ThreeofaKind = 4;
        public int TwoPair = 3;
        public int OnePair = 2;
        public int HighCard = 1;

        public Logic() { }


        public static void determineWinner(Player player1, Player player2, Player player3, Player player4, Player riverman)
        {

            List<Card> player1hand = player1.GetCards();
            List<Card> player2hand = player2.GetCards();
            List<Card> player3hand = player3.GetCards();
            List<Card> player4hand = player4.GetCards();

            player1hand.AddRange(riverman.GetCards());
            player2hand.AddRange(riverman.GetCards());
            player3hand.AddRange(riverman.GetCards());
            player4hand.AddRange(riverman.GetCards());

            Console.WriteLine("Logic Time...");


        }


    }
}
