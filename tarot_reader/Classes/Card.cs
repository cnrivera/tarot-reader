using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tarot_reader.Classes

{
    public class Card
    {

        public string Name { get; private set; }
        public string Description { get; private set; }


        public Card(string name, string description)
        {
            Name = name;
            Description = description;

        }
    

    }
}
