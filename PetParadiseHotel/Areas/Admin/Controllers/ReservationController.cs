using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetParadiseHotel.Infrastructure;
using PetParadiseHotel.ViewModels;
using PetParadiseHotel.Models;

namespace PetParadiseHotel.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        //declaring a variable of type repository
        private Repository repository = new Repository();
        // GET: Admin/Reservation
        public ActionResult Index()
        {
            // Create a Repository object and save it to a session variable
            // if it doesn’t already exists as a session variabel

            if (Session["repository"] == null)
            {
                repository = new Repository();
                Session["repository"] = repository;
            }
            // Read it from the session if already exists as a session variable
            else
            {
                repository = (Repository)Session["repository"];
            }


            // returning the locally created object of repository 
            return View(repository);
        }
    }
}