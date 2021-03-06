﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitCube.Section3.Data
{
    public abstract class  Person
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fore Names")]
        public string ForeNames { get; set; }

        [Required] 
        public string Surname { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string FirstName { get { return ForeNames; } }

        public string FullName { get { return FirstName + " " + Surname; } }
    }
}