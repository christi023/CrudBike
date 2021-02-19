using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBike.Models;
using CrudBike.AppDBContext;

namespace CrudBike.Controllers
{
    public class MakeController : Controller
    { // CRUD Operations for Brands = Makes
      
        // return a list of makes/brands that will be rendered in the table
        private readonly BikeDbContext _db;
        public MakeController(BikeDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Makes.ToList());
        }

        // create view
        // HTTP Get Method
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if(ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            // if not valid
            return View(make);
        }

        //HTTP Get Method - retrieve the Brand / Make
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var make = _db.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }

            return View(make);
        }

        // save changes after updating
        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
        }


        // Delete Make or Brand of Motocycle
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
            if(make==null)
            {
                return NotFound();
            }
            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
