using Microsoft.AspNetCore.Mvc;
using SpookyPark.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SpookyPark.Controllers
{
    public class AttractionsController : Controller
    {
        private readonly SpookyParkContext _db;

        public ActionResult Index ()
        {
            List<Attraction> model = _db.Attractions.Include(a =>a.EntertainmentType).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.ETid = new SelectList(_db.EntertainmentTypes, "ETid", "Name");
            return View();
        }




        [HttpPost]
        public ActionResult Create(Attraction attraction)
        {
            _db.Attractions.Add(attraction);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }  
    }
}