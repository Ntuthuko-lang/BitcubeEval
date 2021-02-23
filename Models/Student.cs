 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bitcube.Models
{
    public class Student
    {
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
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
         
        public ICollection<Enrollment> Enrollments { get; set; }

        [NotMapped]
        public object Enrollment { get; internal set; }

        public string FullName
        {
            get
            {
                return Forenames + " , " + Surname; 
            }
        }
    }
}
 