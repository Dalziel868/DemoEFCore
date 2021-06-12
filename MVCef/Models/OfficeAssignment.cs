using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCef.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [Display(Name ="Office Location")]
        [StringLength(50)]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
