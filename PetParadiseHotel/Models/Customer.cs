using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Customer : Person
    {
        public int CustomerId { get; set;}
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }

        //creating empty constructor
        public Customer() { }
        //creating constructor
        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city,
            string email, string phone) : base(firstName, lastName, phone)
        {
            CustomerId = customerId;
            Address = address;
            City = city;
            Zip = zip;
            Email = email;

        }

     }
}