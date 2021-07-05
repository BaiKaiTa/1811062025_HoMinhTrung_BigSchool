using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1811062025_HoMinhTrung_BigSchool.Models;

namespace _1811062025_HoMinhTrung_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}