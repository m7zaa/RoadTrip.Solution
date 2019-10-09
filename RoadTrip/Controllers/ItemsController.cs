using Microsoft.AspNetCore.Mvc;
using RoadTrip.Models;
using System.Collections.Generic;
using System;

namespace RoadTrip.Controllers
{
    public class ItemsController : Controller
    {
        // This http method is get because its not related to a form.
        [HttpGet("/items/new")]
        // The method New() is what takes the user to the form.
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Index(string gasTank, string roadSideAsst, string music, string snacks, string map)
        {
            Item myItem = new Item(gasTank, roadSideAsst, music, snacks, map);
            return View(myItem);
        }

        // // Form routes need to be HttpPost NOT HttpGet.
        
    }
}