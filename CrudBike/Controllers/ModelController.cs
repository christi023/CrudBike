using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBike.Models;
using CrudBike.AppDBContext;
using CrudBike.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CrudBike.Controllers
{
    public class ModelController : Controller
    {
        // dependency injection to access our Db Class
        private readonly BikeDbContext _db;

        [BindProperty]
        public ModelViewModel ModelVM { get; set; }

        public ModelController(BikeDbContext db)
        {
            _db = db;

            ModelVM = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };
        }

        public IActionResult Index()
        {
            var model = _db.Models.Include(m => m.Make);


            return View(model);
        }

        // Create action method 
        public IActionResult Create()
        {
            return View(ModelVM);
        }

        //  create the post method
        [HttpPost, ActionName("Create")]
      
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _db.Models.Add(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index)); // send user to index page 
        }

    }
}
