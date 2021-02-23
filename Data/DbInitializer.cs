using Bitcube.Models;
using System;
using System.Linq;

namespace Bitcube.Data
{
    public static class DbInitializer
    {
     

        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{Forenames="Ntuthuko", Surname="Nene",  
                    Email="ntu2konene@gmail.com", DOB=DateTime.Parse("1998-03-22")} ,
                new Student{Forenames="John", Surname="Wick", 
                    Email="johnwich@gmail.com", DOB=DateTime.Parse("2001-05-18")} ,
                new Student{Forenames="Mike", Surname="Roberts",  
                    Email="mikeroberts1@gmail.com", DOB=DateTime.Parse("1999-11-12")} ,
                new Student{Forenames="Lango", Surname="Lubede", 
                    Email="langolubed@gmail.com", DOB=DateTime.Parse("1997-05-12")} ,
                new Student{Forenames="Rico", Surname="Mnikathi", 
                    Email="Rico12@gmail.com", DOB=DateTime.Parse("2000-03-18")} ,
                new Student{Forenames="Mzamo", Surname="Khanyile", 
                    Email="Mzamokhanyile@gmail.com", DOB=DateTime.Parse("1999-08-29")} ,
                new Student{Forenames="Mfundo", Surname="Sithole", 
                    Email="Mfundo@gmail.com", DOB=DateTime.Parse("1996-07-24")} ,
                new Student{Forenames="Buhle", Surname="Mbambo",
                    Email="buhlembambo@gmail.com", DOB=DateTime.Parse("1998-04-27")} ,
                new Student{Forenames="Pretty", Surname="Mkhize",
                    Email="pretty@gmail.com", DOB=DateTime.Parse("1999-01-02")} ,
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            
            var lectures = new Lecture[]
            {
                new Lecture{Forenames="Ashveer", Surname= "Govender", 
                    Email="Ashveer101@gamial.com", DOB=DateTime.Parse("1990-07-22"), 
                    HireDate=DateTime.Parse("2014-01-05") },
                new Lecture{Forenames="Lindokuhle", Surname= "Nene", 
                    Email="lindokuhle@gamial.com", DOB=DateTime.Parse("1994-07-09"),
                    HireDate=DateTime.Parse("2006-01-05")},
                new Lecture{Forenames="Asiphe", Surname= "Khumalo", 
                    Email="Asiphe@gamial.com", DOB=DateTime.Parse("1989-09-22"), 
                    HireDate=DateTime.Parse("2011-01-05") },
                new Lecture{Forenames="Nelly", Surname= "Bhengu",
                    Email="nellynene@gamial.com", DOB=DateTime.Parse("1984-08-22"), 
                    HireDate=DateTime.Parse("2012-01-05") },
                new Lecture{Forenames="Andile", Surname= "Dazela",
                    Email="andile@gamial.com", DOB=DateTime.Parse("1970-02-03"), 
                    HireDate=DateTime.Parse("2002-01-05") },
            };
            foreach(Lecture lecture in lectures)
            {
                context.Lectures.Add(lecture);
            }
            context.SaveChanges();

            var degree = new Degree[]
            {
                new Degree{DegreeName="Computer Science", Duration="4 years", 
                LectureId = lectures.Single(i=> i.Surname=="Govender").Id, Lecture="Ashveer Govender" },
                new Degree{DegreeName="Information Technology", Duration="3 years",
                LectureId = lectures.Single(i=> i.Surname=="Nene").Id, Lecture="Lindokuhle Nene" },
                new Degree{DegreeName="Plant Manager", Duration="3 years",
                LectureId = lectures.Single(i=> i.Surname=="Khumalo").Id,Lecture="Asiphe Khumalo"  },
                new Degree{DegreeName="Civil Engineer", Duration="6 years",
                LectureId = lectures.Single(i=> i.Surname=="Bhengu").Id, Lecture="Nelly Bhengu"  },
                new Degree{DegreeName="IT Management", Duration="5 years",
                LectureId = lectures.Single(i=> i.Surname=="Dazela").Id, Lecture="Andile Dazela" },
            };
            foreach(Degree Degree in degree)
            {
                context.Degree.Add(Degree);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course { CourseId = 101, Title = "Web Page Design", Credits = 10, 
                    DegreeId=degree.Single(s=> s.DegreeName =="Information Technology") .DegreeId},
                new Course { CourseId = 102, Title = "Development Software", Credits=10, 
                    DegreeId=degree.Single(s=> s.DegreeName =="Computer Science") .DegreeId },
                new Course { CourseId =103, Title= "Projects", Credits=5, 
                    DegreeId=degree.Single(s=> s.DegreeName =="Plant Manager") .DegreeId},
                new Course { CourseId = 104, Title = "Hydrology", Credits=10, 
                    DegreeId=degree.Single(s=> s.DegreeName =="Civil Engineer") .DegreeId },
                new Course { CourseId = 105, Title = "Security Manaager", Credits=10,
                    DegreeId=degree.Single(s=> s.DegreeName =="IT Management") .DegreeId },
            };
            foreach(Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            var officeAssignments = new OfficeAssignment[] 
            {
                new OfficeAssignment{ 
                    LectureId=lectures.Single(i=>i.Surname== "Govender").Id, 
                    Location = "Durban" },
                new OfficeAssignment{ 
                    LectureId=lectures.Single(i=>i.Surname== "Nene").Id, 
                    Location = "Cape Town" },
                new OfficeAssignment{ 
                    LectureId=lectures.Single(i=>i.Surname== "Khumalo").Id,
                    Location = "Pretora" },
            };
            foreach(OfficeAssignment oa in officeAssignments)
            {
                context.OfficeAssignments.Add(oa);
            }
            context.SaveChanges();

            var courseLectures = new CourseAsssignment[]
            {
                new CourseAsssignment
                {
                    CourseId = courses.Single(c=> c.Title=="Web Page Design").CourseId,
                    LectureId = lectures.Single(i=> i.Surname=="Govender").Id
                },
                new CourseAsssignment
                {
                    CourseId = courses.Single(c=> c.Title=="Development Software").CourseId,
                    LectureId = lectures.Single(i=> i.Surname=="Nene").Id
                },
                new CourseAsssignment
                {
                    CourseId = courses.Single(c=> c.Title=="Projects").CourseId,
                    LectureId = lectures.Single(i=> i.Surname=="Khumalo").Id
                },
                new CourseAsssignment
                {
                    CourseId = courses.Single(c=> c.Title=="Hydrology").CourseId,
                    LectureId = lectures.Single(i=> i.Surname=="Dazela").Id
                },
                new CourseAsssignment
                {
                    CourseId = courses.Single(c=> c.Title=="Security Manaager").CourseId,
                    LectureId = lectures.Single(i=> i.Surname=="Bhengu").Id
                },
            };
            foreach (CourseAsssignment ci in courseLectures)
            {
                context.CourseAsssignments.Add(ci);
            }
            context.SaveChanges();


            var enrollments = new Enrollment[]
            {

                new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Nene").Id,
                    CourseId=courses.Single(c=> c.Title=="Web Page Design"). CourseId,
                    Grade=Grade.A
                },

                     new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Wick").Id,
                    CourseId=courses.Single(c=> c.Title=="Projects"). CourseId,
                    Grade=Grade.B
                },
                new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Roberts").Id,
                    CourseId=courses.Single(c=> c.Title=="Hydrology"). CourseId,
                    Grade=Grade.A
                },
                new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Lubede").Id,
                    CourseId=courses.Single(c=> c.Title=="Security Manaager"). CourseId,
                    Grade=Grade.C
                },
                new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Mnikathi").Id,
                    CourseId=courses.Single(c=> c.Title=="Projects"). CourseId,
                    Grade=Grade.A
                },
                new Enrollment
                {
                    StudentId=students.Single(s=> s.Surname=="Khanyile").Id,
                    CourseId=courses.Single(c=> c.Title=="Development Software"). CourseId,
                    Grade=Grade.B
                },

            };
            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDatabase = context.Enrollments.Where(
                    s =>
                    s.StudentId == e.StudentId &&
                    s.Course.CourseId == e.CourseId).SingleOrDefault();

                if (enrollmentInDatabase == null)
                {
                    context.Enrollments.Add(e);
                }
                    
                context.Enrollments.Add(e);
            }
            context.SaveChanges();

        }
    }
}
