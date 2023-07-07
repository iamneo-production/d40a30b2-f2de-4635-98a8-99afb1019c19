using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("admin/viewCourse")]
        public IActionResult GetCourses()
        {
            BusinessLayer businessLayer = new BusinessLayer();
            List<CourseModel> courses = businessLayer.GetCourses();

            return Ok(new { Status = "Success", Result = courses });
        }
        [HttpGet]
        [Route("admin/viewInstitutes")]
        public IActionResult GetInstitute()
        {
            BusinessLayer businessLayer1 = new BusinessLayer();
            List<InstituteModel> institutes = businessLayer1.GetInstitute();

            return Ok(new { Status = "Success", Result = institutes });
        }
        [HttpGet]
        [Route("admin/ViewStudent")]
        public IActionResult GetStudent()
        {
            BusinessLayer businessLayer2 = new BusinessLayer();
            List<StudentModel> students = businessLayer2.GetStudent();

            return Ok(new { Status = "Success", Result = students });
        }
        
    }
}
