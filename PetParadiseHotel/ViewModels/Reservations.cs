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
        private List<Invoice> reservationList = new List<Invoice>();
        private Repository repository = new Repository();
        public Invoice Invoice { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<Invoice> ReservationList { get { return reservationList; } }


        public Reservations()
        {
            Invoice = new Invoice();
            OrderItem = new OrderItem();
        }

        public void PopulatePriceList()
        {
            OrderItem.PriceList = repository.Prices;
        }
        public void PopulateReservations()
        {
            reservationList = repository.Invoices;
        }

    }
}