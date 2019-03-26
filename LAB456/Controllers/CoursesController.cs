using LAB456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB456.ViewModels;
namespace LAB456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
        
        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            var course = new Course
            {
                LecturerID = ;
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
    }
}