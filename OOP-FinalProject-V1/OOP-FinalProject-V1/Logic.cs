using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cards;

/*TODO:
 * Add Tie Logic
 * GUI
 * Betting
 */

namespace OOP_FinalProject_V1
{
    public class Logic
    {

        public static double bettingRound(Player player1, Player player2, Player player3, Player player4, Player riverman)
        {
            double p1bet = 0;
            double p2bet = 0;
            double p3bet = 0;
            double p4bet = 0;
            
            Console.WriteLine("_____________________________________");
            Console.WriteLine(player1.name + ", what is your bet?");
            p1bet = double.Parse(Console.ReadLine());
            player1.funds = player1.funds - p1bet;
            Console.WriteLine(player1.name + ", you have " + player1.funds + " dollars left");
            riverman.funds = riverman.funds + p1bet;
            Console.WriteLine("_____________________________________");
            Console.WriteLine(player2.name + ", what is your bet?");
            p2bet = double.Parse(Console.ReadLine());
            player2.funds = player2.funds - p2bet;
            Console.WriteLine(player2.name + ", you have " + player2.funds + " dollars left");
            riverman.funds = riverman.funds + p2bet;
            Console.WriteLine("_____________________________________");
            Console.WriteLine(player3.name + ", what is your bet?");
            p3bet = double.Parse(Console.ReadLine());
            player3.funds = player3.funds - p3bet;
            Console.WriteLine(player3.name + ", you have " + player3.funds + " dollars left");
            riverman.funds = riverman.funds + p3bet;
            Console.WriteLine("_____________________________________");
            Console.WriteLine(player4.name + ", what is your bet?");
            p4bet = double.Parse(Console.ReadLine());
            player4.funds = player4.funds - p4bet;
            Console.WriteLine(player4.name + ", you have " + player4.funds + " dollars left");
            riverman.funds = riverman.funds + p4bet;


            Console.WriteLine("_____________________________________");
            Console.WriteLine("Total Money in the Pot: $" + riverman.funds);
            return riverman.funds;
        }

        public static void determineWinner(Player player1, Player player2, Player player3, Player player4, Player riverman)
        {
            int RoyalFlush = 10;
            int StraightFlush = 9;
            int FourofaKind = 8;
            int FullHouse = 7;
            int Flush = 6;
            int Straight = 5;
            int ThreeofaKind = 4;
            int TwoPair = 3;
            int OnePair = 2;
            int HighCard = 1;

            var deck = new Deck();

            List<Card> player1hand = player1.GetCards();
            List<Card> player2hand = player2.GetCards();
            List<Card> player3hand = player3.GetCards();
            List<Card> player4hand = player4.GetCards();

            player1hand.AddRange(riverman.GetCards());
            player2hand.AddRange(riverman.GetCards());
            player3hand.AddRange(riverman.GetCards());
            player4hand.AddRange(riverman.GetCards());

            player1hand = deck.Sort(player1hand);
            player2hand = deck.Sort(player2hand);
            player3hand = deck.Sort(player3hand);
            player4hand = deck.Sort(player4hand);

            int player1score = 1;
            int player2score = 1;
            int player3score = 1;
            int player4score = 1;


            // HasOnePair

            if (HasOnePair(player1hand))
            {
                player1score = OnePair;

            }
            if (HasOnePair(player2hand))
            {
                player2score = OnePair;
            }
            if (HasOnePair(player3hand))
            {
                player3score = OnePair;
            }
            if (HasOnePair(player4hand))
            {
                player4score = OnePair;
            }

            //For HasTwoPair
            if (HasTwoPair(player1hand))
            {
                player1score = TwoPair;

            }
            if (HasTwoPair(player2hand))
            {
                player2score = TwoPair;
            }
            if (HasTwoPair(player3hand))
            {
                player3score = TwoPair;
            }
            if (HasTwoPair(player4hand))
            {
                player4score = TwoPair;
            }


            //For HasThreeOfAKind

            if (HasThreeOfAKind(player1hand))
            {
                player1score = ThreeofaKind;

            }
            if (HasThreeOfAKind(player2hand))
            {
                player2score = ThreeofaKind;
            }
            if (HasThreeOfAKind(player3hand))
            {
                player3score = ThreeofaKind;
            }
            if (HasThreeOfAKind(player4hand))
            {
                player4score = ThreeofaKind;
            }

            //For Flush

            if (IsFlush(player1hand))
            {
                player1score = Flush;

            }
            if (IsFlush(player2hand))
            {
                player2score = Flush;
            }
            if (IsFlush(player3hand))
            {
                player3score = Flush;
            }
            if (IsFlush(player4hand))
            {
                player4score = Flush;
            }

            //For Straight

            if (IsStraight(player1hand))
            {
                player1score = Straight;

            }
            if (IsStraight(player2hand))
            {
                player2score = Straight;
            }
            if (IsStraight(player3hand))
            {
                player3score = Straight;
            }
            if (IsStraight(player4hand))
            {
                player4score = Straight;
            }

            //For FullHouse

            if (HasFullHouse(player1hand))
            {
                player1score = FullHouse;

            }
            if (HasFullHouse(player2hand))
            {
                player2score = FullHouse;
            }
            if (HasFullHouse(player3hand))
            {
                player3score = FullHouse;
            }
            if (HasFullHouse(player4hand))
            {
                player4score = FullHouse;
            }

            //For FourOfAKind

            if (HasFourOfAKind(player1hand))
            {
                player1score = FourofaKind;

            }
            if (HasFourOfAKind(player2hand))
            {
                player2score = FourofaKind;
            }
            if (HasFourOfAKind(player3hand))
            {
                player3score = FourofaKind;
            }
            if (HasFourOfAKind(player4hand))
            {
                player4score = FourofaKind;
            }


            //For Straight Flush

            if (IsStraightFlush(player1hand))
            {
                player1score = StraightFlush;

            }
            if (IsStraightFlush(player2hand))
            {
                player2score = StraightFlush;
            }
            if (IsStraightFlush(player3hand))
            {
                player3score = StraightFlush;
            }
            if (IsStraightFlush(player4hand))
            {
                player4score = StraightFlush;
            }


            //For Royal Flush

            if (HasRoyalFlush(player1hand))
            {
                player1score = RoyalFlush;

            }
            if (HasRoyalFlush(player2hand))
            {
                player2score = RoyalFlush;
            }
            if (HasRoyalFlush(player3hand))
            {
                player3score = RoyalFlush;
            }
            if (HasRoyalFlush(player4hand))
            {
                player4score = RoyalFlush;
            }
            

            if (player1score == player2score && player3score == player4score && player1score == player4score)
            {
                player1score = HighCard;
                player2score = HighCard;
                player3score = HighCard;
                player4score = HighCard;

                int[] ranks1 = player1hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
                int[] ranks2 = player2hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
                int[] ranks3 = player3hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
                int[] ranks4 = player4hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
                for (int i = 0; i < player1hand.Count; i++)
                {
                    Console.WriteLine(ranks1[i]);
                    player1score = ranks1[i];
                }
                Console.WriteLine("\n______________\n"); 
                for (int i = 0; i < player2hand.Count; i++)
                {
                    Console.WriteLine(ranks2[i]);
                    player2score = ranks2[i];
                }
                Console.WriteLine("\n______________\n");
                for (int i = 0; i < player3hand.Count; i++)
                {
                    Console.WriteLine(ranks3[i]);
                    player3score = ranks3[i];
                }
                Console.WriteLine("\n______________\n");
                for (int i = 0; i < player4hand.Count; i++)
                {
                    Console.WriteLine(ranks4[i]);
                    player4score = ranks4[i];
                }
                Console.WriteLine("\n______________\n");

            }



            //Console.WriteLine(player1score);

            //Console.WriteLine(player2score);

            //Console.WriteLine(player3score);

            //Console.WriteLine(player4score);

            int winner = HighestScore(player1score, player2score, player3score, player4score);

            Console.WriteLine("The winner is Player {0}", winner);

            string wincondition = "TEST";
            if (winner == 1)
            {
                wincondition = WinType(player1score);
                player1.funds = player1.funds + riverman.funds;
                Console.WriteLine("The pool of " + riverman.funds + " has been added to " + player1.name + "'s money. Total money is now: " + player1.funds);
            } 
            else if (winner == 2)
            {
                wincondition = WinType(player2score);
                player2.funds = player2.funds + riverman.funds;
                Console.WriteLine("The pool of " + riverman.funds + " has been added to " + player2.name + "'s money. Total money is now: " + player2.funds);
            }
            else if (winner == 3)
            {
                wincondition = WinType(player3score);
                player3.funds = player3.funds + riverman.funds;
                Console.WriteLine("The pool of " + riverman.funds + " has been added to " + player3.name + "'s money. Total money is now: " + player3.funds);
            }
            else if (winner == 4)
            {
                wincondition = WinType(player4score);
                player4.funds = player4.funds + riverman.funds;
                Console.WriteLine("The pool of " + riverman.funds + " has been added to " + player4.name + "'s money. Total money is now: " + player4.funds);
            }

            Console.WriteLine("They had a {0}", wincondition);


        }

        public static string WinType(int winnerscore)
        {
            if (winnerscore == 1){
                return "High Card";
            }else if (winnerscore == 2)
            {
                return "Single Pair";
            }else if (winnerscore == 3)
            {
                return "Double Pair";
            }else if (winnerscore == 4)
            {
                return "Three of a Kind";
            }
            else if (winnerscore == 5)
            {
                return "Straight";
            }else if (winnerscore == 6)
            {
                return "Flush";
            }else if (winnerscore == 7)
            {
                return "Full House";
            }else if (winnerscore == 8)
            {
                return "Four of a Kind";
            }else if (winnerscore == 9)
            {
                return "Straight Flush";
            }else if (winnerscore == 2)
            {
                return "Royal Flush";
            }
            else
            {
                return "ERROR";
            }

        }

        public static bool HasRoyalFlush(List<Card> hand)
        {
            if (hand.Select(x => x.Suit).Distinct().Count() == 1)
            {

                int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
                Array.Sort(ranks);

                if (ranks[0] == 9)
                {

                    if (ranks[1] == 10)
                    {

                        if (ranks[2] == 11)
                        {

                            if (ranks[3] == 12)
                            {

                                if (ranks[4] == 13)
                                {
                                    return true;
                                }
                            }
                        }
                    }

                }
                else if (ranks[4] == 13)
                {
                    if (ranks[3] == 12)
                    {
                        if (ranks[2] == 11)
                        {

                            if (ranks[1] == 10)
                            {
                                if (ranks[0] == 9)
                                {
                                    return true;
                                }

                            }
                        }

                    }
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public static bool HasFullHouse(List<Card> hand)
        {
            var countRank = hand.GroupBy(c => c.CardNumber).Select(x => x.Count());

            return countRank.Contains(3) && countRank.Contains(2);
        }

        public static bool IsStraightFlush(List<Card> hand)
        {



            hand.Sort((card1, card2) => card1.CardNumber.CompareTo(card2.CardNumber));

            if (hand.Select(x => x.Suit).Distinct().Count() == 1)
            {

                int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();


                for (int i = 0; i < hand.Count - 1; i++)
                {
                    if ((ranks[hand.Count() - i]) > (ranks[hand.Count() - i + 1])) { continue; }
                    else
                    {
                        return false;
                    }
                }

            }
            else { return false; }
            return true;

        }


        public static bool IsStraight(List<Card> hand)
        {

            var sortedHand = hand.OrderBy(c => c.CardNumber).ToList();

            for (int i = 0; i < sortedHand.Count - 1; i++)
            {
                if (sortedHand[i].CardNumber + 1 != sortedHand[i + 1].CardNumber)
                {
                    return false;
                }
            }

            return true;

            //hand.Sort((card1, card2) => card1.CardNumber.CompareTo(card2.CardNumber));


            //int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();


            //for (int i = 0; i < hand.Count - 1; i++)
            //{
            //    if ((ranks[hand.Count() - i]) > (ranks[hand.Count() - i + 1])) { continue; }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //return true;

        }

        public static bool IsFlush(List<Card> hand)
        {
            var countSuit = hand.GroupBy(c => c.Suit).Select(x => x.Count());

            return countSuit.Any(count => count >= 5);
        }

        public static bool HasFourOfAKind(List<Card> hand)
        {


            int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
            Array.Sort(ranks);

            int[] distinctedRanks = ranks.Distinct().ToArray();


            if (distinctedRanks.Count() <= 4)
            {
                return true;
            }



            return false;
        }


        public static bool HasThreeOfAKind(List<Card> hand)
        {


            int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
            Array.Sort(ranks);

            int[] distinctedRanks = ranks.Distinct().ToArray();


            if (distinctedRanks.Count() <= 5)
            {
                return true;
            }



            return false;
        }

        public static bool HasTwoPair(List<Card> hand)
        {
            var countRank = hand.GroupBy(c => c.CardNumber).Select(x => x.Count());
            int pairCount = countRank.Count(count => count >= 2);
            return pairCount >= 2;
        }
       
        public static bool HasOnePair(List<Card> hand)
        {


            int[] ranks = hand.Select(x => x.CardNumber.GetHashCode()).ToArray();
            Array.Sort(ranks);

            int[] distinctedRanks = ranks.Distinct().ToArray();


            if (distinctedRanks.Count() <= 6)
            {
                return true;
            }



            return false;
        }

        public static int HighestScore(int p1, int p2, int p3, int p4)
        {
            int score = 0;
            int winner = 0;
            if (p1 > score)
            {
                score = p1;
                winner = 1;
            }
            if (p2 > score)
            {
                score = p2;
                winner = 2;
            }
            if (p3 > score)
            {
                score = p3;
                winner = 3;
            }
            if (p4 > score)
            {
                score = p4;
                winner = 4;
            }
            return winner;
        }

    }
}
