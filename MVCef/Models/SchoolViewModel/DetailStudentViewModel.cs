using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCef.Models.SchoolViewModel
{
    public class DetailStudentViewModel
    {
        public string FullName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Grade? Grade { get; set; }
        public int CourseID { get; set; }
        public string Title { get; set; }
    }
}
