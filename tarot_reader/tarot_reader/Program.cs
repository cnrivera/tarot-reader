using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using tarot_reader.Classes;

namespace tarot_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // TO DO
            // start a method here to call again at the end to restart if the user presses y 
            // have option to do new reading for yourself or for someone else. Response returns to a differnet location (GetUserName or GetSpreadSelection).
           
         

            Console.WriteLine("-------------------- Tarot Reader --------------------"); // by Noel Rivera
            Console.WriteLine("======================================================");
            Console.WriteLine(); 
            Thread.Sleep(1000);
            Console.WriteLine("Hello!");
            Console.WriteLine();
            Thread.Sleep(1000);

            string readingFor = GetUserName();
            Console.Clear();
            Console.WriteLine($"Welcome, {readingFor}.");
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Excellent. Press S to shuffle the deck and start your reading."); // prompts user to shuffle

            Deck newDeck = new Deck(); //create a deck

            string shuffleConfirm = Console.ReadLine(); //shuffle confirmation
            if (shuffleConfirm.ToUpper().Equals("S"))
            {
                newDeck.shuffle();
            }
            else
            {
                Console.WriteLine("Invalid response. Please press S");
            }

            List<Card> deckList = newDeck.TarotDeck; //new tarot deck
  
            int cardReturn = GetSpread(); // get number of cards in spread

            //print cards here face down
            PrintCards(cardReturn, deckList); // print spread face down
            
            //have user flip them over one at a time
            Console.WriteLine("Press any key to flip a card.");
            
            for (int i = 0; i < cardReturn; i++)
            {
                Console.ReadKey();
                deckList[i].Flip();
                deckList[i].Status();
            }
            
            


      
           


            //ask the user if they'd like to print the reading to a file



        }
        public static string GetUserName() //gets user name
        {
            Console.Write("Who is receiving this reading?  ");
            string readingFor = Console.ReadLine();
            return readingFor;
        }

        public static int GetSpreadSelection() // selects a one-card, three-card, or five-card reading
        {
            Console.WriteLine($"Which would you like to do? \n1. Explore your theme for the day (1 card) \n2. Receive advice about a problem (3 cards) \n3. Explore a relationship (5 cards)");
            string strReadingSelection = Console.ReadLine();
            int readingSelection = int.Parse(strReadingSelection);
            return readingSelection;
        }
        public static int GetSpread()
        {
            int spreadSelection = GetSpreadSelection();
            int cardReturn = 0;
            if (spreadSelection == 1)
            {
                cardReturn = 1;
            }
            else if (spreadSelection == 2)
            {
                cardReturn = 3;
            }
            else if (spreadSelection == 3)
            {
                cardReturn = 5;
            }
            else
            {
                Console.WriteLine("Selection invalid. Please choose 1, 2 or 3.");
                return GetSpread();
            }

            return cardReturn;
        }

        public static void PrintCards(int cardReturn, List<Card>deckList)
        {
            if(cardReturn == 1)
            {
                deckList[0].Status();
                //Console.WriteLine(deckList[0].Name + " " + deckList[1].Description);
            }

            else if(cardReturn == 3)
            {
                deckList[0].Status();
                deckList[1].Status();
                deckList[2].Status();
                //Console.WriteLine(deckList[0].Name + " " + deckList[1].Description);
                //Console.WriteLine(deckList[2].Name + " " + deckList[3].Description);
                //Console.WriteLine(deckList[4].Name + " " + deckList[5].Description);
            }

            else if(cardReturn == 5)
            {
                deckList[0].Status();
                deckList[1].Status();
                deckList[2].Status();
                deckList[3].Status();
                deckList[4].Status();
                //Console.WriteLine(deckList[0].Name + " " + deckList[1].Description);
                //Console.WriteLine(deckList[2].Name + " " + deckList[3].Description);
                //Console.WriteLine(deckList[4].Name + " " + deckList[5].Description);
                //Console.WriteLine(deckList[6].Name + " " + deckList[7].Description);
                //Console.WriteLine(deckList[8].Name + " " + deckList[9].Description);
            }
        }
        
    }
}
