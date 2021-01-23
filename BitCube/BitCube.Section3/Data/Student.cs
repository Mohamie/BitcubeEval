using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Section3.Data
{
    public class Student : Person
    {
        public Degree EnrolledDegree { get; set; }
    }
}