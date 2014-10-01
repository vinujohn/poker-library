using System.Collections.Generic;

namespace Poker.Library
{
    public static class Extensions
    {
        public static bool IsFaceCard(this Card card)
        {
            return card.Rank > Rank.Ten;
        }
    }
}
