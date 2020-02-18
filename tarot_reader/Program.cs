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
            GetSpreadSelection();
            
            //prompts user to shuffle -- TK create an assortment of words to say instead of just "excellent" and figure out how to randomize it
            Console.Clear();
            Console.WriteLine("Excellent. Press S to shuffle the deck and start your reading.");

            Deck newDeck = new Deck(); //create a deck
            foreach (string item in newDeck)
            {
                Console.WriteLine(item);
            };
            Console.ReadKey();
            
            //call a shuffle function

            //start if statement to call a 1, 3, or 5 card method

            //have user flip them over one at a time

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
        
    }
}
