using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahsCards
{
    public class Card
    {
        private Suit _suit;
        private Type _type;
        bool _isNotStandard;

        public enum Suit
        {
            Clubs,
            Diamonds,
            Spades,
            Hearts
        }

        public enum Type
        {
            Ace,
            King,
            Queen,
            Jack,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
        }

        public Card(Type type, Suit suit)
        {
            _type = type;
            _suit = suit;
            _isNotStandard = false;
        }

        public Card()
        {
            _isNotStandard = true;
        }

        public bool IsJoker  // property
        {
            get { return _isNotStandard; }   // get method
        }

        public override string ToString()
        {
            return "Card: " + _type + ", " + _suit;
        }
    }
}
