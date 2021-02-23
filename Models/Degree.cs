using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bitcube.Models
{
    public class Degree
    {
        
        public int DegreeId { get; set; }

        [StringLength(50, MinimumLength =1)]
        [Display(Name ="Degree Name")]
        public string DegreeName { get; set; }

        public string Duration { get; set; }
        
        public int LectureId { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Lecture responsible")]
        public string Lecture { get; set; }

        public ICollection<Course> Course { get; set; }

    }
}