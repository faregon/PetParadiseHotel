﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetParadiseHotel.Infrastructure;
using PetParadiseHotel.ViewModels;
using PetParadiseHotel.Models;

namespace PetParadiseHotel.Areas.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        private Repository repository = new Repository();
        // GET: Admin/Invoice
        public ActionResult Index()
        {
            if (Session["repository"] == null)
            {
                repository = new Repository();
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
          
      
            return View(repository);
        }
    }
}