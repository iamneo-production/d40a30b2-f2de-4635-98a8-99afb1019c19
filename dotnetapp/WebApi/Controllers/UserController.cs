using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("user/ViewAdmission")]
        public IActionResult GetAdmission()
        {
            BusinessLayer business = new BusinessLayer();
            List<AdmissionModel> admissions = business.GetAdmission();

            return Ok(new { Status = "Success", Result = admissions });
        }
        [HttpGet]
        [Route("user/viewStatus")]
        public IActionResult GetStatus()
        {
            BusinessLayer business1 = new BusinessLayer();
            List<AdmissionModel> admissions = business1.GetStatus();

            return Ok(new { Status = "Success", Result = admissions });
        }
    }
}