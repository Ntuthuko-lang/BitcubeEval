
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitcube.Models
{
    public class CourseAsssignment
    {
        public int LectureId { get; set; }

        public int CourseId { get; set; }

        public Lecture Lecture { get; set; }

        public Course Course { get; set; }
    }
}
