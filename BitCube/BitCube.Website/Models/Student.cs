using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Website.Models
{
    public class Student : Person
    {
        public Degree EnrolledDegree { get; set; }
    }
}