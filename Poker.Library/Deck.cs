using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Poker.Library
{
    public static class Deck
    {
        public static List<Card> GetShuffled52CardDeck()
        {
            var deck = new List<Card>();

            BuildDeck(deck);
            ShuffleDeck(deck);

            return deck;
        }

        private static void BuildDeck(List<Card> deck)
        {
            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    deck.Add(new Card(){Rank = (Rank) rank, Suit = (Suit) suit});
                }
            }
        }

        public static void ShuffleDeck(List<Card> deck)
        {
            for(int i = 0; i < 1000000; i++)
            {
                var rand = new Random(DateTime.Now.Millisecond);
                var removeAt = rand.Next(0, deck.Count);
                var insertAt = rand.Next(0, deck.Count);
                var card = deck.ElementAt(removeAt);
                deck.Remove(card);
                deck.Insert(insertAt, card);
            }
        }
    }
}
