using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetParadiseHotel.Infrastructure;
// in this controller we will store
// all the child actions 
namespace PetParadiseHotel.Controllers
{
    public class CActionsController : Controller
    {
        [ChildActionOnly]
        public ActionResult _PriceList()
        {
            Dictionary<string, decimal> prices = new Dictionary<string, decimal>();

            
            prices.Add("Bird spider", 90.00M);
            prices.Add("Buggie", 70.00M);
            prices.Add("Canary", 60.00M);
            prices.Add("Chinchilla", 70.00M);
            prices.Add("Cat", 140.00M);
            prices.Add("Dog", 200.00M);
            prices.Add("Guinea Pig", 80.00M);
            prices.Add("Hamster", 80.00M);
            prices.Add("Iguana", 160.00M);
            prices.Add("Rabit", 90.00M);
            prices.Add("Snake", 80.00M);

            ViewBag.Prices = prices;
            //Create a partiel view, notice this is located in the Shared folder
            //so therefore the convention is to use _ in front of the view name
            return PartialView("_PriceList", prices);
        }

        [ChildActionOnly]
        public ActionResult _ResidentPets()
        {
            //declaring variable repository of type repository
            Repository repository = new Repository();
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

            //Create a partiel view, notice this is located in the Shared folder
            //so therefore the convention is to use _ in front of the view name
            return PartialView("_ResidentPets",repository);
        }
    }
}