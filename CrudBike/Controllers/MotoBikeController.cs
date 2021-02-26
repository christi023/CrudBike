using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBike.Models;
using CrudBike.AppDBContext;
using CrudBike.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace CrudBike.Controllers
{
    public class MotoBikeController : Controller
    {
        public IActionResult Index()
        {
            [Authorize(Roles = "Admin, Executive")] // Authorizes Admin & Executive for Roles handling
            public class MotorBikeController : Controller
        {
            // dependency injection to access our Db Class
            private readonly BikeDbContext _db;

            [BindProperty]
            public MotorBikeViewModel MotorBikeVM { get; set; }

            public MotorBikeController(BikeDbContext db)
            {
                _db = db;

                MotorBikeVM = new MotorBikeViewModel()
                {
                    Makes = _db.Makes.ToList(),
                    Models = _db.Models.ToList(),
                    MotorBike = new Models.MotorBike()
                };
            }

            public IActionResult Index()
            {
                var MotorBikes = _db.MotorBikes.Include(m => m.Make).Include(m => m.Model);


                return View(MotorBikes.ToList());
            }

            // Get Method 
            public IActionResult Create()
            {
                return View(MotorBikelVM);
            }

            //  Post Method
            [HttpPost, ActionName("Create")]

            public IActionResult CreatePost()
            {
                if (!ModelState.IsValid)
                {
                    return View(MotorBikeVM);
                }
                _db.Models.Add(MotorBikeVM.MotorBike);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index)); // send user to index page 
            }

            /*
            // Edit action
            public IActionResult Edit(int id)
            {
                // This Id we will reciecve from the input parameter of Index page
                ModelVM.Model = _db.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == id);
                if (ModelVM.Model == null)
                {
                    return NotFound();
                }
                return View(ModelVM);
            }

            // Edit with the post method
            [HttpPost, ActionName("Edit")]
            public IActionResult EditPost()
            {
                if (!ModelState.IsValid)
                {
                    return View(ModelVM);
                }

                _db.Update(ModelVM.Model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index)); // redirects user to index page
            }

            // Delete method
            [HttpPost]
            public IActionResult Delete(int id)
            {
                Model model = _db.Models.Find(id);
                if (model == null)
                {
                    return NotFound();
                }

                _db.Models.Remove(model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

        } */

    }
    }
}
