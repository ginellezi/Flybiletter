﻿using Flybiletter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flybiletter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*TODO VALIDERING
            if (ModelState.IsValid)
            {
                return RedirectToAction("");
            }*/
            var db = new DB();
            List<Airport> allAirports = db.getAllAirports();

            return View(allAirports);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {


            TempData["IndexForm"] = form;
            return RedirectToAction("FlightDetails");
        }

      
        public ActionResult FlightDetails()
        {
            ViewBag.data = TempData["IndexForm"];
            return View();
        }
      

        public ActionResult Passenger()
        {
            /*TODO VALIDERING
            if (ModelState.IsValid)
            {
                return RedirectToAction("");
            }*/
            return View();

        }

        [HttpPost]
        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult OrderTest2()
        {
            return View();
        }

    }
}