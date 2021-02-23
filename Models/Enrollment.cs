using System.ComponentModel.DataAnnotations;

namespace Bitcube.Models
{
    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int DegreeId { get; set; }
        public Course Course { get; set; }
        public Student Student  { get; set; }

        [DisplayFormat(NullDisplayText ="No grade")]
        public Grade? Grade { get; set; }
    }
}