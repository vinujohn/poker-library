using System;

namespace Poker.Library
{
    public class Card
    {
        public Suit Suit { get; set; }
        
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return String.Format("{0} of {1}", Rank, Suit);
        }
    }
}
