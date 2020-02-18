using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tarot_reader;
using System.IO;
using System.Collections.Generic;

namespace DeckTests
{
    [TestClass]
    public class tarotReaderTests
    {
        [TestMethod]
        public void DeckCreationTest()
        {
            Deck newDeck = new Deck();
            int result = newDeck.CreateDeck().Count;
            Assert.AreEqual(78, result);

        }
    }
}
