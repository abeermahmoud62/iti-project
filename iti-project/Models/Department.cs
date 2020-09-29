using System.ComponentModel.DataAnnotations;

namespace iti_project.Models
{
    public class Department
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}