using Microsoft.AspNet.Identity;
using NguyenQuangHuy_1811063275.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenQuangHuy_1811063275.Controllers.Api
{
    public class CoursesController : ApiController
    {
        ApplicationDbContext _dbContext { get; set; }

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);

            if (course.IsCaneled)
            {
                return NotFound();
            }
            course.IsCaneled = true;
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
