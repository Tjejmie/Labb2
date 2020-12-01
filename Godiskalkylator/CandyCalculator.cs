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

        public void DistributeCandy(int candies, bool byLastName, bool byFirstName, bool byAge)
        {
            int candy = candies / PeopleList.Count;
            int leftoverCandy = candies % PeopleList.Count;

            if (byFirstName)
            {
                DistributeCandyFirstName();
            }
            else if (byLastName)
            {
                DistributeCandyLastName();
            }
            else if (byAge)
            {
                DistributeCandyAge();
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
        public List<Person> DistributeCandyFirstName()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.FirstName).ToList();
            }
            return PeopleList;
        }
        public List<Person> DistributeCandyLastName()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.LastName).ToList();
            }
            return PeopleList;
        }
        public List<Person> DistributeCandyAge()
        {
            {
                PeopleList = PeopleList.OrderBy(person => person.Age).ToList();
            }
            return PeopleList;
        } 
    }
}
