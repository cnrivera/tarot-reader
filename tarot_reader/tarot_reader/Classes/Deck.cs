using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tarot_reader.Classes
{
    public class Deck
    {
        public List<Card> TarotDeck { get; set; }
        
        public Deck()
        {
            TarotDeck = new List<Card>();
            CreateDeck();
        }
        
        private void CreateDeck() // read in file of cards
        {
            string filePath = Directory.GetCurrentDirectory() + "\\tarot_card_elements.txt";
            using (StreamReader sr = new StreamReader(filePath)) // create new StreamReader
            {
                while (!sr.EndOfStream) // while there are lines in the file
                {
                    string line = sr.ReadLine(); // read line
                    string[] lineSections = line.Split("|"); // split file line on pipe and add to string array
                    string name = lineSections[0].Trim(); // add index 0 to name minus whitespace
                    string description = lineSections[1].Trim(); // add index 1 to description minus whitespace
                    Card createCard = new Card(name, description); // create new card
                    TarotDeck.Add(createCard);
                }
            }

        }

        public void shuffle()
        {
            int numberOfTimes = 10;
            for (int times = 0; times < numberOfTimes; times++)
            {
                //split the deck into two smaller lists
                //loop until both lists are empty
                //   take random 1-5 number cards from top half
                //   take random 1-5 number cards from bottom half

                List<Card> topHalf = TarotDeck.GetRange(0, 26);
                TarotDeck.RemoveRange(0, 26);

                List<Card> bottomHalf = TarotDeck.GetRange(0, 26);
                TarotDeck.RemoveRange(0, 26);

                Random random = new Random();

                while (topHalf.Count > 0 || bottomHalf.Count > 0)
                {
                    int takeFromTop = random.Next(1, 5);
                    for (int i = 0; i < takeFromTop && i < topHalf.Count; i++)
                    {
                        Card result = topHalf[0];
                        topHalf.Remove(result);
                        TarotDeck.Add(result);
                    }
                    int takeFromBottom = random.Next(1, 5);
                    for (int i = 0; i < takeFromBottom && i < bottomHalf.Count; i++)
                    {
                        Card result = bottomHalf[0];
                        bottomHalf.Remove(result);
                        TarotDeck.Add(result);
                    }
                }
            }
        }


        public int GetDeckCount()
        {
            return TarotDeck.Count;
        }

       
    }
}
