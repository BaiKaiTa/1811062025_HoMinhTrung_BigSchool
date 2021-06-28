using _1811062025_HoMinhTrung_BigSchool.Models;
using _1811062025_HoMinhTrung_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811062025_HoMinhTrung_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}