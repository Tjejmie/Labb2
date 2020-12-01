using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Godiskalkylator
{
    public class CandyCalculator
    {
        public List<Person> PeopleList { get; set; }
        
        public CandyCalculator()
        {
            PeopleList = new List<Person>();
        }

        public void SortingCandy(int candies, bool byLastName, bool byFirstName, bool byAge)
        {
            int candy = candies / PeopleList.Count;
            int leftoverCandy = candies % PeopleList.Count;

            if (byFirstName)
            {
                SortingCandyFirstName();
            }
            else if (byLastName)
            {
                SortingCandyLastName();
            }
            else if (byAge)
            {
                SortingCandyAge();
            }
            foreach (var person in PeopleList)
            {
                person.Candies += candy;
                if (leftoverCandy > 0)
                {
                    person.Candies++;
                    leftoverCandy--;
                }
            }
        }
        public List<Person> SortingCandyFirstName()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.FirstName).ToList();
            }
            return PeopleList;
        }
        public List<Person> SortingCandyLastName()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.LastName).ToList();
            }
            return PeopleList;
        }
        public List<Person> SortingCandyAge()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.Age).ToList();
            }
            return PeopleList;
        } 
    }
}
