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
    {
       /*
        // makes/bikes
        [Route("Make")]
        [Route("Make/Bikes")]
        public IActionResult Bikes()
        {

     Make make = new Make { Id = 1, Name = "Harley Davidson" };
            return View(make);
        }

       [Route("make/bikes/{year:int}/{month:int}")] 

        // Adding the new action method from Startup.cs
        public IActionResult ByYearMonth(int year, int month)
        {
            return Content(year + ";" + month);
        } 
       */

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
    }
}
