using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public class Gryffindor : House
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public Gryffindor()
        {
            HouseGhost = "Nästan Huvudlöse Nick";
            Mascot = "Lejon";
            
            Password = "en ensam trollkarl";
        }
        

    }
}
