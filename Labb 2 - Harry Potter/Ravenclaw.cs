using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public class Ravenclaw : House
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public Ravenclaw()
        {
            HouseGhost = "Grå Damen";
            Mascot = "Örn";
            Members = new List<Wizard>();
            Password = "en ensam trollkarl";
        }

    }
}
