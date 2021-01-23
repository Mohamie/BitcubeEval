using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Section3.Data
{
    public class Degree
    {
        //For Dropdown Purpose
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}