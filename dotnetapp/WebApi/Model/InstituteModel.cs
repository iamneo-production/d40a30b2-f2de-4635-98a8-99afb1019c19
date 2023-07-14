using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class InstituteModel
    {
        public int instituteId { get; set; }
        public string instituteName { get; set; }
        public string instituteDescription { get; set; }
        public string instituteAddress { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
}