using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Person
    {
        private string phone;

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get { return phone; } set
            {
                if (phone.Length <= 8)
                {
                    phone = value;
                }
                else
                    throw new Exception("Phone number is invalid");
                    }
        }

        public Person() { }

        public Person(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            this.phone = phone;
        }
    }
}