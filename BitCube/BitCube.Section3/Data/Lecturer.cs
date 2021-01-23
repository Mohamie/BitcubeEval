using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Section3.Data
{
    public class Lecturer : Person
    {
        public List<Degree> LecturingDegrees { get; set; }
    }
}