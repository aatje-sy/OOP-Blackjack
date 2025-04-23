using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopBlackjack.Classes
{
    class Dealer
    {

        private Deck deck;
        public List<Card> VisibleCards { get; private set; }
        private Card hiddenCard;

        public Dealer()
        {
            deck = new Deck();
            VisibleCards = new List<Card>();
        }

        public void ShuffleDeck()
        {
            deck.shuffleCards();
        }

        public void DealToPlayer(Player player)
        {
            player.receiveCard(deck.dealCard());
            player.receiveCard(deck.dealCard());
        }

        public void DealToSelf()
        {
            hiddenCard = deck.dealCard();
            VisibleCards.Add(deck.dealCard());
        }

        public void RevealHiddenCard()
        {
            if (hiddenCard != null)
            {
                VisibleCards.Add(hiddenCard);
                hiddenCard = null;
            }
        }

        public Deck GetDeck()
        {
            return deck;
        }


    }
}
