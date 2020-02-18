using Microsoft.VisualStudio.TestTools.UnitTesting;
using tarot_reader.Classes;

namespace tarot_reader_test
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void GetDeckCount()
        {
            Deck newDeck = new Deck();
            int result = newDeck.GetDeckCount();
            Assert.AreEqual(78, result);
        }
    }

}
