using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopBlackjack.Classes
{
    class Player
    {
        private string Name;
        private float Balance;
        List<Card> Hand = new List<Card>();


        public Player()
        {
            this.Name = "Player";
            this.Balance = 1000;
        }

        public void receiveCard(Card card)
        {
            Hand.Add(card);
        }

        public void PrintHand()
        {
            foreach (Card card in Hand)
            {
                Console.WriteLine(card.ToString());
            }
        }

    }   
}
