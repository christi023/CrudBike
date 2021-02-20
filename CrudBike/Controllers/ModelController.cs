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
    }
}
