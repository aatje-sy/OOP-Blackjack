using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopBlackjack.Classes
{
    class Deck
    {
        List<Card> Cards = new List<Card>();
        


        public Deck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    Cards.Add(new Card(suit, value));
                    
                }

            }
            foreach (Card card in Cards)
            {
                Debug.WriteLine(card);
            }
        }

       


        public void shuffleCards()
        {
            
        }


        public void dealCard()
        {
            if(Cards.Count == 0)
            {
                Console.WriteLine("Deck is empty");
            }

            Card ToDealCard = Cards[0];
            Cards.Remove(ToDealCard);
        }


    }
}
