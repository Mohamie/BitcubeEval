using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Website.Models
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