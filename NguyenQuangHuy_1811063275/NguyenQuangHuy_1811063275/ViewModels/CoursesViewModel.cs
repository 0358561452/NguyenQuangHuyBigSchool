using NguyenQuangHuy_1811063275.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenQuangHuy_1811063275.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}