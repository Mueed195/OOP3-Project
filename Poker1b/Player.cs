using PokerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker1b
{
    class Player
    {

        public string name { get; set; }
        public List<Card> playersCards = new List<Card>();



        public Player(string name, List<Card> playersCards)
        {

            this.name = name;
            this.playersCards = playersCards;
        }

        public List<Card> GetCards()
        {
            return this.playersCards;
        }

    }
}
