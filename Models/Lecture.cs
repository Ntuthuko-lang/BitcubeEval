using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bitcube.Models
{
    public class Lecture
    {
        public static IEnumerable<object> Courses { get; internal set; }
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string Forenames { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Surname { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

     

        public string FullName
        {
            get
            {
                return Surname + " , " + Forenames;
            }
        }
        public ICollection<CourseAsssignment> CourseAsssignments { get; set; }

        public OfficeAssignment OfficeAssignmet { get; set; }
    }
}


