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
            ViewBag.Id = new SelectList(_db.EntertainmentTypes, "Id", "Name");
            return View();
        }

        // public ActionResult Create()
        // {
        //     ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
        //     return View();
        // }


        [HttpPost]
        public ActionResult Create(Attraction attraction)
        {
            _db.Attractions.Add(attraction);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }  
    }
}