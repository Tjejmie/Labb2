using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public class Slytherin : House
    {
        public Slytherin ()
        {
            Name = "Slytherin";
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Members = null;
            Password = "trollkarlsmakt";
        }


        public override bool PasswordCounter(string password)
        {
            int count = 0;
            foreach (char letter in password)
            {
                count++;
                if (count >=8)
                {
                    return true;
                }
            } return false;
        }

        public override bool PasswordFormat(string input)
        {
            char consonantChar = Password[Password.Length - 1];
            char[] password = input.ToLower().ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (IsConsonant(input[0]) && PasswordCounter(input) && IsConsonant(consonantChar))
                {
                    return true;
                }
            }
            return false;
        }
    }



    




}
