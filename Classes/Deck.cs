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
            if (Cards.Count == 0)
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                    {
                        Cards.Add(new Card(suit, value));

                    }

                }
            }

            Random rand = new Random();

            for (int i = 0; i < Cards.Count; i++)
            {
                
            

            }
        }


        public Card dealCard()
        {
            if(Cards.Count == 0)
            {
                Console.WriteLine("Deck is empty");
                return null;
            }

            Card ToDealCard = Cards[0];
            Cards.Remove(ToDealCard);

            return ToDealCard;
        }


    }
}
