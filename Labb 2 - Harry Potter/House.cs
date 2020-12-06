using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public abstract class House
    {
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public List<Wizard> Members { get; set; }


        public virtual bool PasswordCounter(string password)
        {
            int count = 0;
            {
                foreach (char letter in password)
                {
                    count++;
                    
                    if (count >= 5)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public virtual bool IsConsonant(char password)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            foreach (char a in consonant )
            {
                if (a == password)
                {
                    return true;
                }
            } return false;
        }
        public virtual bool IsVowel(char password)
        {
            string Vowel = "aouiyeåäöAOUIYEÅÄÖ";
            foreach (char a in Vowel)
            {
                if (a == password)
                {
                    return true;
                }
            } return false;
        }
        public virtual bool PasswordFormat(string input)
        {
            char consonantChar = Password[Password.Length - 1];
            char[] password = input.ToLower().ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (IsVowel(password[0]) && PasswordCounter(input) && IsConsonant(consonantChar))
                {
                    return true;
                }
            } return false;
        }

        public virtual bool ChangePassword(string newPassword, string oldPassword)
        {

            if (oldPassword == Password && PasswordFormat(newPassword) == true)
            {
                Password = newPassword;
                return true;

            }
            return false;
        }


    }
   
} 

