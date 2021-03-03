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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using cloudscribe.Pagination.Models;


namespace CrudBike.Controllers
{
    [Authorize(Roles = "Admin, Executive")] // Authorizes Admin & Executive for Roles handling
    public class MotorBikeController : Controller
    {
        // dependency injection to access our Db Class
        private readonly BikeDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
        public MotorBikeViewModel MotorBikeVM { get; set; }

        public MotorBikeController(BikeDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;

            MotorBikeVM = new MotorBikeViewModel()
            {
                Makes = _db.Makes.ToList(),
                Models = _db.Models.ToList(),
                MotorBike = new Models.MotorBike()
            };
        }
      
        // Pagination to create pages
        public IActionResult Index(string searchString, string sortOrder, int pageNumber = 1, int pageSize = 3)
        {
            ViewBag.CurrentSortOrder = sortOrder; // sorting
            ViewBag.CurrentFilter = searchString;  // filtering
            ViewBag.PriceSortParam = String.IsNullOrEmpty(sortOrder) ? "price_dec" : " ";
            int ExcludeRecords = (pageSize * pageNumber) - pageSize;

            var MotorBikes = from b in _db.MotorBikes.Include(m => m.Make).Include(m => m.Model)
                             select b;
            var MotorBikeCount = MotorBikes.Count();

            // Filter by Brand /Makes
            if (!String.IsNullOrEmpty(searchString))
            {
                MotorBikes = MotorBikes.Where(b => b.Make.Name.Contains(searchString));
                 MotorBikeCount = MotorBikes.Count();
            }

            //Sorting Logic
            switch (sortOrder)
            {
                case "price_desc":
                    MotorBikes = MotorBikes.OrderByDescending(b => b.Price);
                    break;
                default:
                    MotorBikes = MotorBikes.OrderBy(b => b.Price);
                    break;
            }
            MotorBikes = MotorBikes
                 .Skip(ExcludeRecords)
                 .Take(pageSize);

            // page results and count
            var result = new PagedResult<MotorBike>
            {
                Data = MotorBikes.AsNoTracking().ToList(),// improve performance of application
                TotalItems = MotorBikeCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        //Get Method
        public IActionResult Create()
        {
            return View(MotorBikeVM);
        }

        //  Post Method
        [HttpPost, ActionName("Create")]

        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {// validating
                MotorBikeVM.Makes = _db.Makes.ToList(); // refresh here to get this case if form is submitted without value, we will not get error- Makes + Models
                MotorBikeVM.Models = _db.Models.ToList();
                return View(MotorBikeVM);
            }
            _db.MotorBikes.Add(MotorBikeVM.MotorBike);
            _db.SaveChanges();

            // Save MotorBike Logic =======> Image Upload

            // Get MotorBike id we have saved in Database
            var MotorBikeID = MotorBikeVM.MotorBike.Id;

            // Get wwwrootPath to save file on server
            string wwrootPath = _webHostEnvironment.WebRootPath;

            // Get the uploaded files 
            var files = HttpContext.Request.Form.Files;

            // Get reference of DBSet for the MotorBike we have to save in Database
            var SavedMotorBike = _db.MotorBikes.Find(MotorBikeID);

            if (files.Count != 0)
            {
                var ImagePath = @"images\MotorBike\";
                //Extract the extension of submitted file
                var Extension = Path.GetExtension(files[0].FileName);

                //Create the relative image path to be saved in database table 
                var RelativeImagePath = ImagePath + MotorBikeID + Extension;

                //Create absolute image path to upload the physical file on server
                var AbsImagePath = Path.Combine(wwrootPath, RelativeImagePath);

                // Upload the file on server
                using (var fileStream = new FileStream(AbsImagePath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                // Set the Image path on database
                SavedMotorBike.ImagePath = RelativeImagePath;
                _db.SaveChanges();

            }

            return RedirectToAction(nameof(Index)); // send user to index page 
        }


        // Edit action
        /*    public IActionResult Edit(int id)
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
        */

        // Delete method
        [HttpPost]
        public IActionResult Delete(int id)
        {

            MotorBike MotorBike = _db.MotorBikes.Find(id);
            if (MotorBike == null)
            {
                return NotFound();
            }

            _db.MotorBikes.Remove(MotorBike);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }  
}
