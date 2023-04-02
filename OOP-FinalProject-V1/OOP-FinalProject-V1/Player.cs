using System;
using System.Collections.Generic;
using System.Text;
using Cards;

namespace OOP_FinalProject_V1
{
    public class Player
    {
        public string name { get; set; }
        public List<Card> playersCards = new List<Card>();
        public double funds { get; set; }



        public Player(string name, List<Card> playersCards, double funds)
        {

            this.name = name;
            this.playersCards = playersCards;
            this.funds = funds;
        }


        public List<Card> GetCards()
        {
            return this.playersCards;
        }

        public double GetFunds()
        {
            return this.funds;
        }
    }
}
