using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class AdmissionModel
    {
        public int admissionId { get; set; }
        public string courseName { get; set; }
        public string date { get; set; }
        public string status{get; set;}
    }
}