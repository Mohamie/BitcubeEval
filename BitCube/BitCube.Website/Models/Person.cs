using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCube.Website.Models
{
    public abstract class  Person
    {
        public string ForeNames { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get { return ForeNames; } }

        public string FullName { get { return FirstName + " " + Surname; } }
    }
}