using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopBlackjack.Classes
{
    class Card
    {
        private CardSuit suit;
        
        private CardValue cardvalue;

        private Image CardImage;

        public Card(CardSuit suit, CardValue value)
        {
            this.suit = suit;
            this.cardvalue = value;

        }

        public CardSuit Suit
        {
            get { return suit; }
        }


        public CardValue Value
        {
            
            get { return cardvalue; }
        }


        public override string ToString()
        {
            return $"{cardvalue} of {suit}";
        }
    }
}
