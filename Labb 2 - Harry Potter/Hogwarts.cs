using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    class Hogwarts
    {
        public Hufflepuff Hufflepuff { get; set; }
        public Gryffindor Gryffindor { get; set; }
        public Ravenclaw Ravenclaw { get; set; }
        public Slytherin Slytherin { get; set; }

        public Hogwarts()
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Slytherin = new Slytherin();
            Ravenclaw = new Ravenclaw();
        }

        int count = 0;
        public House SortingHat(Wizard wizard)
        {
            
            if (count == 0)
            {
                Hufflepuff.Members.Add(wizard);
                count++;

                return Hufflepuff;
            }

            else if (count == 1)
            {
                Ravenclaw.Members.Add(wizard);
                count++;
                return Ravenclaw;
            }
            else if (count == 2)
            {
                Gryffindor.Members.Add(wizard);
                count++;
                return Gryffindor;
            } 
            else if (count == 3)
            {
                Slytherin.Members.Add(wizard);
                count = 0;
                return Slytherin;
            }
            return null;
            
            
        }
    }




}
