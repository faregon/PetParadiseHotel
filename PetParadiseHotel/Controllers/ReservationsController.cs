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
            //creating a variable called reservation to reference the viewmodel
            //reservation
            Reservations reservation = new Reservations();
            reservation.PopulatePriceList();
            return View(reservation);
        }
        [HttpPost]
        public ActionResult Index(Reservations reserv)
        {
            //adding the infromation from the reservation form
            //to the orderitem class
            reserv.Invoice.OrderItems.Add(reserv.OrderItem);
            reserv.Invoice.OrderDate = DateTime.Now;
            if (Session["repository"] == null)
            {
                repository = new Repository();
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
            reserv.PopulatePriceList();
          //adding the information to the invoice class
            repository.Invoices.Add(reserv.Invoice);
            return View(reserv);
        }
    }
}