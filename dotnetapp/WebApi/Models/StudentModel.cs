using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class StudentModel
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentDOB { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public int age { get; set; }
    }
}