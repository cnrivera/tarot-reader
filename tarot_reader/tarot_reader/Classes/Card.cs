using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace tarot_reader.Classes

{
    public class Card
    {

        public string Name { get; private set; }
        public string Description { get; private set; }

        public bool IsFaceUp { get; private set; }

        public Card(string name, string description)
        {
            Name = name;
            Description = description;
            IsFaceUp = false;

        }

        public void Flip()
        {
            IsFaceUp = !IsFaceUp;
        }

        public void Status()
        {
            if (IsFaceUp)
            {
                FaceUp();
            }
            else if(!IsFaceUp)
            {
                FaceDown();
            }
        }
        public void FaceDown()
        {
            Console.WriteLine("FaceDown");
        }

        public void FaceUp()
        {
            Console.WriteLine("FaceUp");
            Console.WriteLine(this.Name + " " + this.Description);
      
        }
    }
}
