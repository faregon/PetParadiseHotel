using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetParadiseHotel.Models;
using PetParadiseHotel.Infrastructure;

namespace PetParadiseHotel.ViewModels
{
    public class Reservations
    {
        //referencing all the classes we might need in one place
        private List<Invoice> reservationList = new List<Invoice>();
        private Repository repository = new Repository();
        public Invoice Invoice { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<Invoice> ReservationList { get { return reservationList; } }

        //creating constructor
        public Reservations()
        {
            Invoice = new Invoice();
            OrderItem = new OrderItem();
        }
        //method for populating the pricelist dictionary
        public void PopulatePriceList()
        {
            OrderItem.PriceList = repository.Prices;
        }
        //method for populating the reservations object
        public void PopulateReservations()
        {
            reservationList = repository.Invoices;
        }

    }
}