using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCef.Models
{
    public class Student
    {
        private int iD;
        private string lastName;
        private string firstMidName;
        private DateTime enrollmentDate;
        //private string secret;

        //public string Secret
        //{
        //    get { return secret; }
        //    set { secret = value; }
        //}
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name ="Last Name")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name ="First Name")]
        public string FirstMidName
        {
            get { return firstMidName; }
            set { firstMidName = value; }
        }
        [Required]
        [Display(Name ="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get { return $"{FirstMidName} {LastName}"; }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
