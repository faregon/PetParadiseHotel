using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Person
    {
 

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }


        public Person() { }

        public Person(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
}