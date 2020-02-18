using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tarot_reader.Classes
{
    public class Deck
    {
        List<Card> tarotDeck = new List<Card>();

        public Deck()
        {
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
                    tarotDeck.Add(createCard);
                }
            }

        }

        public override string ToString()
        {
           tarotDeck.ForEach(i => Console.WriteLine("{0}", i));
            return tarotDeck.ToString();
        }

        public int GetDeckCount()
        {
            return tarotDeck.Count;
        }

       
    }
}
