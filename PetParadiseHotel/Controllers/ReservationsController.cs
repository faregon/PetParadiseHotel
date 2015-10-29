using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetParadiseHotel.ViewModels;
using PetParadiseHotel.Infrastructure;

namespace PetParadiseHotel.Controllers
{
    public class ReservationsController : Controller
    {
        private Repository repository = new Repository();
        // GET: Reservations
        public ActionResult Index()
        {
            Reservations reservation = new Reservations();
            reservation.PopulatePriceList();
            return View(reservation);
        }
        [HttpPost]
        public ActionResult Index(Reservations reserv)
        {

            reserv.PopulatePriceList();
            reserv.Invoice.OrderItems.Add(reserv.OrderItem);
            return View(reserv);
        }
    }
}