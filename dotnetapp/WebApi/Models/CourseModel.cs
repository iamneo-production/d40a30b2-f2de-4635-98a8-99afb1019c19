using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class CourseModel
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public string courseDuration { get; set; }
    }
}