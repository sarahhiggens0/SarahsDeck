using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahsCards
{
    public class Deck
    {
        private List<Card> _cards;
        public Deck()
        {
            _cards = new List<Card>();
        }

        public void Add(Card card)
        {
            _cards.Add(card);
        }

        public void populateDeck()
        {

            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Type type in Enum.GetValues(typeof(Card.Type)))
                {
                    Card card = new Card(type, suit);
                    _cards.Add(card);
                }
            }

            Card joker = new Card();
            Card joker2 = new Card();
            _cards.Add(joker);
            _cards.Add(joker2);
        }

        public void printDeck()
        {
            foreach (Card card in _cards)
            {
                if (card.IsJoker)
                {
                    Console.WriteLine("Joker\n");
                }
                else
                {
                    Console.WriteLine(card.ToString() + "\n");
                }
            }

            Console.WriteLine("Total:" + _cards.Count());
        }

        public void shuffle()
        {
            int total = _cards.Count();
            var random = new Random();

            for (int i = 0; i < total; i++)
            {
                int swappedIndex = random.Next(i, total);
                Card temp = _cards[i];
                _cards[i] = _cards[swappedIndex];
                _cards[swappedIndex] = temp;
            }
        }
    }
}
