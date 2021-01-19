﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Website.Models
{
    public class Course
    {
        public string Name { get; set; }
        
        public int Duration { get; set; }

        public Degree LinkedDegree { get; set; }

    }
}