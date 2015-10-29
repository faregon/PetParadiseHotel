using PetParadiseHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Infrastructure
{
    public class Repository
    {
        //create Dictionary collection
        Dictionary<string, double> prices = new Dictionary<string, double>();
        public Dictionary<string, double> Prices { get { return prices; } }

        List<Invoice> invoices = new List<Invoice>();
        public List<Invoice> Invoices { get { return invoices; } }

        public Repository()
        {
            //add keys and values to the dictionary
            prices.Add("Select Specie", 0);
            prices.Add("Bird spider", 90);
            prices.Add("Buggie", 70);
            prices.Add("Canary", 60);
            prices.Add("Chinchilla", 70);
            prices.Add("Cat", 140.00);
            prices.Add("Dog", 200.00);
            prices.Add("Guinea Pig", 80);
            prices.Add("Hamster", 80);
            prices.Add("Iguana", 160);
            prices.Add("Rabit", 90);
            prices.Add("Snake", 80.00);

            //creating customers
            Customer c1 = new Customer(1, "Susan", "Peterson", "Silkeborgvej 659", "8210", "Aarhus",
                "supe@xmail.com", "12345678");
            Customer c2 = new Customer(2, "Brian", "Smith", "Mejlgade 8", "8000", "Aarhus",
                "brsm@xmail.com", "12121212");
            Customer c3 = new Customer(3, "Minko", "Todorov", "Silkeborgvej 500", "8000", "Aarhus",
                "mito@gmail.com", "51886815");

            //creating employees objects
            Employee e1 = new Employee(1, "John", "Smith", "Josm", "13314565");
            Employee e2 = new Employee(2, "Alexander", "Huston", "Alhu", "89432156");

            //creating invoices objects
            Invoice i1 = new Invoice(1, DateTime.Today, c1, e1);
            Invoice i2 = new Invoice(2, DateTime.Today, c2, e2);

            //create order items
            OrderItem oi1 = new OrderItem(1, "Hamlet", "Snake", new DateTime(2015, 9, 25),
                new DateTime(2015, 10, 02));
            OrderItem oi2 = new OrderItem(2, "Samson", "Dog", new DateTime(2015, 8, 24),
                new DateTime(2015, 9, 21));
            OrderItem oi3 = new OrderItem(3, "Darla", "Cat", new DateTime(2015, 9, 7),
                new DateTime(2015, 9, 15));

            //adding order items in the invoices
            i1.AddOrderItem(oi1);
            i1.AddOrderItem(oi2);
            i2.AddOrderItem(oi3);

            oi1.PricePerday = prices[oi1.Specie];
            oi2.PricePerday = prices[oi2.Specie];
            oi3.PricePerday = prices[oi3.Specie];
            //adding the invoices to the list
            invoices.Add(i1);
            invoices.Add(i2);
        }
    }
}