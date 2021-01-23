using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Section3.Data
{
    public class Course
    {
        public string Name { get; set; }
        
        public int Duration { get; set; }

        public Degree LinkedDegree { get; set; }

    }
}