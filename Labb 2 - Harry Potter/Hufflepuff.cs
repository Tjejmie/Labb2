using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public class Hufflepuff : House
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public Hufflepuff()
        {
            HouseGhost = "Den Tjocke Munkbrodern";
            Mascot = "Grävling";
            Members = new List<Wizard>();
            Password = "en ensam trollkarl";
        }
        
    }
}
