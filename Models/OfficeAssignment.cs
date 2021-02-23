using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bitcube.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int LectureId { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Lecture Lecture { get; set; }
    }
}
