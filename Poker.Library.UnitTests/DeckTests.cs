using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Library.UnitTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void ShuffledDeckHas52Cards()
        {
            var cards = Deck.GetShuffled52CardDeck();
            Assert.AreEqual(52, cards.Count);
        }
    }
}
