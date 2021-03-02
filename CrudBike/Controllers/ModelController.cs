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
using CrudBike.Controllers.Resources;
using AutoMapper;

namespace CrudBike.Controllers
{
    [Authorize(Roles = "Admin, Executive")] // Authorizes Admin & Executive for Roles handling
    public class ModelController : Controller
    {
        // dependency injection to access our Db Class
        private readonly BikeDbContext _db;
        private readonly IMapper _mapper;

        [BindProperty]
        public ModelViewModel ModelVM { get; set; }

        public ModelController(BikeDbContext db, IMapper mapper) // mapper is passed using dependency injection
        {
            _db = db;
            _mapper = mapper;

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

        // web api to get Models
        [AllowAnonymous]
        [HttpGet("api/models/{MakeID}")]
        public IEnumerable<Model> Models(int MakeID)
        {
            return _db.Models.ToList()
            .Where(m => m.MakeID == MakeID);
        }

        /*     [AllowAnonymous]
             [HttpGet("api/models/{MakeID}")]
             public IEnumerable<ModelResources> Models(int MakeID)
             {
                 var models = _db.Models.ToList();
                 var modelResources = models
                     .Select(m => new ModelResources
                     {
                         Id = m.Id,
                         Name = m.Name,
                         MakeID = m.MakeID
                     }).ToList()
                     .Where(m => m.MakeID == MakeID);
                 return modelResources;
             } */


        [AllowAnonymous]
        [HttpGet("api/models")]
        public IEnumerable<ModelResources> Models()
        {
            var models = _db.Models.ToList(); // get all model list
           
               return _mapper.Map<List<Model>, List<ModelResources>>(models);
              }
    }

}

