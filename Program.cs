﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarahsCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.populateDeck();
            deck.printDeck();
            deck.shuffle();
            deck.printDeck();
            Console.Read();
        }
    }
}
