using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionApp.Core
{
    public class Participant
    {



    }

    public class Person
    {
        public static string FirstName;
        public static string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Group
    {
        public static Person Spokesman;
        public static string GroupType;
    }
}
