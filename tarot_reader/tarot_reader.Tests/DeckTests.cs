using Microsoft.VisualStudio.TestTools.UnitTesting;
using tarot_reader;
using tarot_reader.Classes;

namespace tarot_reader.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckCount()
        {
            Deck newDeck = new Deck();
            int result = newDeck.GetDeckCount();
            Assert.AreEqual(78, result);
        }
    }
}
