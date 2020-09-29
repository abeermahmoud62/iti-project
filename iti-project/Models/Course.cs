﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iti_project.Models
{
    public class Course
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string Name { get; set; }

        [Required]
        public string Discription { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public IList<ApplicationUser> Users { get; set; }
    }
}