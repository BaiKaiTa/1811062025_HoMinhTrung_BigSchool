using _1811062025_HoMinhTrung_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811062025_HoMinhTrung_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}