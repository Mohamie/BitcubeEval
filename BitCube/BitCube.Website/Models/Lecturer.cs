using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Website.Models
{
    public class Lecturer : Person
    {
        public List<Degree> LecturingDegrees { get; set; }
    }
}