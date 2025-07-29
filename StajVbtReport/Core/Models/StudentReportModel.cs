using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class StudentReportModel
    {
        public string StudentFirstName { get; set; }

        public string StudentLastName { get; set; }
        public string? CourseName { get; set; }

        //public int Score { get; set; }
        public int? MidtermExam { get; set; }
        public int? FinalExam { get; set; }
        public int StudentGrade { get; set; }

        public double StudentGradeAverage { get; set; }

        public string? Message { get; set; }
    }
    public class StudentReportSearchModel
    {
       // public string SrcStudentName { get; set; }
        public int SrcStudentId { get; set; }
        public string? CourseName { get; set; }
        public string? QueryType { get; set; }
        public bool OnlyMidterm { get; set; }
        public bool OnlyFinal { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
    }

    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? MidtermExam { get; set; }
        public int? FinalExam { get; set; }
    }

}
