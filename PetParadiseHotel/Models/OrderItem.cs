using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class OrderItem
    {
        private Dictionary<string, double> priceList = new Dictionary<string, double>();
        private int days;
        private double pricePerDay;

        public int OrderItemId { get; set; }
        public string PetName { get; set; }
        public string Specie { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public Invoice Invoice { get; set; }

        public int Days {
            set { days = value; }
            get
            {
                TimeSpan span = Departure - Arrival;
                days = (int)span.TotalDays;
                return days;

            }
                
                
                 }
        public double PricePerday
        {
            set { pricePerDay = value; }
            get
            {
                foreach(var item in priceList)
                {
                    if (item.Key.Equals(Specie))
                    {
                        pricePerDay = item.Value;
                    }

                }
                return pricePerDay;
            }
        }
        public Dictionary<string, double> PriceList
        {
            set { priceList = value; }
            get { return priceList; }
        }

        public OrderItem() { }

        public OrderItem(int orderItemId, string petName, string specie, DateTime arrival, DateTime departure) {

            OrderItemId = orderItemId;
            PetName = petName;
            Specie = specie;
            Arrival = arrival;
            Departure = departure;
        }

    }
}