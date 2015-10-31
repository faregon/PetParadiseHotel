using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetParadiseHotel.Infrastructure;

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

            return PartialView("_PriceList", prices);
        }

        [ChildActionOnly]
        public ActionResult _ResidentPets()
        {
            Repository repository = new Repository();
            if (Session["repository"] == null)
            {
                repository = new Repository();
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
          
      
            return View("_ResidentPets",repository);
        }
    }
}