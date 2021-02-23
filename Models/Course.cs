using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bitcube.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         
        [Display(Name="Number")]
        public int CourseId { get; set; }

        [StringLength(50, MinimumLength =1)]
        [Display(Name ="Course Name")]
        public string Title { get; set; }

        [Range(0,10)]
        public int Credits { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM}", ApplyFormatInEditMode = true)]
        [Display(Name = "Duration in Months")]
        public DateTime Duration { get; set; }

        
        public int DegreeId { get; set; }

        public Degree Degree { get; set; }

              public ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<CourseAsssignment> CourseAsssignments { get; set; }
     
    }
}