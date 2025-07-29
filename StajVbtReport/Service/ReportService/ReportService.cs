using Core.Models;

namespace Service.ReportService
{
    public class ReportService :IReportService
    {
        public List<ReportResponseModel> GetStajReport(ReportRequestModel requestModel)
        {
            var result = new List<ReportResponseModel>();

            var dataList = new List<ReportResponseModel>();
            var model1 = new ReportResponseModel();
            
            model1.name = "Zeynep";
            model1.lastName = "Uğuz";
            
            dataList.Add(model1);
            
            result = dataList;

            var model2 = new ReportResponseModel();

            model2.name = "Zehra";
            model2.lastName = "Güneş";

            dataList.Add(model2);

            result = dataList;

            var model3 = new ReportResponseModel();

            model3.name = "Eda";
            model3.lastName = "Çakıroğlu";

            dataList.Add(model3);

            result = dataList;

            return result;
        }

        public List<StudentReportModel> GetStudentReport(StudentReportSearchModel searchModel)
        {
            var response = new List<StudentReportModel>();

            List<Student> studentList = new List<Student>();


            Student student1 = new Student();
            student1.Id = 1;
            student1.firstName = "Caner";
            student1.lastName = "Yıldız";
            studentList.Add(student1);

            Student student2 = new Student();
            student2.Id = 2;
            student2.firstName = "Kübra";
            student2.lastName = "Aksu";
            studentList.Add(student2);

            Student student3 = new Student();
            student3.Id = 3;
            student3.firstName = "Emine";
            student3.lastName = "Güneş";
            studentList.Add(student3);

            List<Course> courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "Matematik" },
                new Course { Id = 2, CourseName = "Fizik" },
                new Course { Id = 3, CourseName = "Kimya" },
                new Course { Id = 4, CourseName = "Biyoloji" }
            };

            //List<Grade> gradeList = new List<Grade>
            //{
            //    new Grade { Id = 1, StudentId = 1, CourseId = 1, Score = 100 },
            //    new Grade { Id = 2, StudentId = 1, CourseId = 2, Score = 50 },
            //    new Grade { Id = 3, StudentId = 1, CourseId = 3, Score = 80 },
            //    new Grade { Id = 4, StudentId = 1, CourseId = 4, Score = 70},
            //    new Grade { Id = 5, StudentId = 2, CourseId = 1, Score = 50 },
            //    new Grade { Id = 6, StudentId = 2, CourseId = 2, Score = 70 },
            //    new Grade { Id = 7, StudentId = 2, CourseId = 3, Score = 80 },
            //    new Grade { Id = 8, StudentId = 2, CourseId = 4, Score = 60 },
            //    new Grade { Id = 9, StudentId = 3, CourseId = 1, Score = 80 },
            //    new Grade { Id = 10, StudentId = 3, CourseId = 2, Score = 90 },
            //    new Grade { Id = 11, StudentId = 3, CourseId = 3, Score = 85 },
            //    new Grade { Id = 12, StudentId = 3, CourseId = 4, Score = 100 }
            //};





            //var responseList = (from students in studentList

            //                    where (string.IsNullOrEmpty(searchModel.SrcStudentName) || students.firstName == searchModel.SrcStudentName) 

            //                    select new StudentReportModel
            //                    {
            //                        StudentFirstName = students.firstName ??"",
            //                        StudentLastName = students.lastName ??""
            //                    }).ToList();



            //var responseList = (from students in studentList
            //           join c in courses on students.Id equals c.StudentId into courseTemp
            //           from c in courseTemp.DefaultIfEmpty()
            //                    select new StudentReportModel
            //                    {
            //                        StudentFirstName = students.firstName ?? "",
            //                        StudentLastName = students.lastName ?? "",
            //                        CourseName = c?.CourseName ?? ""
            //                    }).ToList();


            //var responseList = (from students in studentList
            //                    join c in courses on students.Id equals c.StudentId into courseTemp
            //                    from c in courseTemp.DefaultIfEmpty()
            //                    join grades in gradeList on new { a = c.Id, b = students.Id } equals new {a = grades.CourseId, b = grades.StudentId}

            //                    select new StudentReportModel
            //                    {
            //                        StudentFirstName = students.firstName ?? "",
            //                        StudentLastName = students.lastName ?? "",
            //                        CourseName = c?.CourseName ?? "",
            //                        StudentGrade = grades?.Score ?? 0
            //                    }).ToList();




            //var responseList = (from item in (from students in studentList
            //                                  join g in gradeList on students.Id equals g.StudentId into gradeTemp
            //                                  from grades in gradeTemp.DefaultIfEmpty()
            //                                  join c in courses on grades != null ? grades.CourseId : 0 equals c.Id into courseTemp
            //                                  from c in courseTemp.DefaultIfEmpty()

            //                                  select new
            //                                  {
            //                                      StudentFirstName = students.firstName ?? "",
            //                                      StudentLastName = students.lastName ?? "",
            //                                      CourseName = c?.CourseName ?? "",
            //                                      StudentGrade = grades?.Score ?? 0
            //                                  })

            //                    group item by new { item.StudentFirstName, item.StudentLastName } into groupData

            //                    select new StudentReportModel
            //                    {
            //                        StudentFirstName = groupData.Key.StudentFirstName,
            //                        StudentLastName = groupData.Key.StudentLastName,
            //                        CourseName = string.Join(", ", groupData
            //                            .Where(x => !string.IsNullOrEmpty(x.CourseName))
            //                            .Select(x => x.CourseName)
            //                            .Distinct()),
            //                        StudentGrade = groupData.Sum(x => x.StudentGrade),
            //                        StudentGradeAverage = groupData.Any(x => x.StudentGrade > 0)
            //                                              ? Math.Round(groupData.Average(x => x.StudentGrade), 2)
            //                                              : 0
            //                    }).ToList();


            List<Grade> gradeList = new List<Grade>
            {
                new Grade { Id = 1, StudentId = 1, CourseId = 1, MidtermExam = 100 },
                new Grade { Id = 2, StudentId = 1, CourseId = 1, FinalExam = 70 },
                new Grade { Id = 3, StudentId = 1, CourseId = 2, MidtermExam = 50 },
                new Grade { Id = 4, StudentId = 1, CourseId = 2, FinalExam = 50 },
                new Grade { Id = 5, StudentId = 1, CourseId = 3, MidtermExam = 80 },
                new Grade { Id = 6, StudentId = 1, CourseId = 3, FinalExam = 80 },
                new Grade { Id = 7, StudentId = 1, CourseId = 4, MidtermExam = 70},
                new Grade { Id = 8, StudentId = 1, CourseId = 4, FinalExam = 70},

                new Grade { Id = 9, StudentId = 2, CourseId = 1, MidtermExam = 80 },
                new Grade { Id = 10, StudentId = 2, CourseId = 1, FinalExam = 55 },
                new Grade { Id = 11, StudentId = 2, CourseId = 2, MidtermExam = 40 },
                new Grade { Id = 12, StudentId = 2, CourseId = 2, FinalExam = 30 },
                new Grade { Id = 13, StudentId = 2, CourseId = 3, MidtermExam = 72 },
                new Grade { Id = 14, StudentId = 2, CourseId = 3, FinalExam = 60 },
                new Grade { Id = 15, StudentId = 2, CourseId = 4, MidtermExam = 55},
                new Grade { Id = 16, StudentId = 2, CourseId = 4, FinalExam = 90},

                new Grade { Id = 17, StudentId = 3, CourseId = 1, MidtermExam = 50 },
                new Grade { Id = 18, StudentId = 3, CourseId = 1, FinalExam = 70 },
                new Grade { Id = 19, StudentId = 3, CourseId = 2, MidtermExam = 80 },
                new Grade { Id = 20, StudentId = 3, CourseId = 2, FinalExam = 60 },
                new Grade { Id = 21, StudentId = 3, CourseId = 3, MidtermExam = 80 },
                new Grade { Id = 22, StudentId = 3, CourseId = 3, FinalExam = 90 },
                new Grade { Id = 23, StudentId = 3, CourseId = 4, MidtermExam = 85 },
                new Grade { Id = 24, StudentId = 3, CourseId = 4, FinalExam = 100 }
            };

            var merged = gradeList
                .GroupBy(x => new { x.StudentId, x.CourseId })
                .Select(g => new
                {
                    StudentId = g.Key.StudentId,
                    CourseId = g.Key.CourseId,
                    Midterm = g.Where(x => x.MidtermExam.HasValue).Select(x => x.MidtermExam.Value).FirstOrDefault(),
                    Final = g.Where(x => x.FinalExam.HasValue).Select(x => x.FinalExam.Value).FirstOrDefault()
                }).ToList();

            bool isAllCourses = string.IsNullOrEmpty(searchModel.CourseName) ||
                                searchModel.CourseName.Trim().ToLower() == "tüm dersler";

            var detailedReport = (from m in merged
                                  join s in studentList on m.StudentId equals s.Id
                                  join c in courses on m.CourseId equals c.Id
                                  where isAllCourses || c.CourseName == searchModel.CourseName
                                  select new StudentReportModel
                                  {
                                      StudentFirstName = s.firstName,
                                      StudentLastName = s.lastName,
                                      CourseName = c.CourseName,
                                      MidtermExam = m.Midterm,
                                      FinalExam = m.Final,
                                      StudentGrade = (searchModel.OnlyMidterm == true) ? m.Midterm :
                                                     (searchModel.OnlyFinal == true) ? m.Final :
                                                      (int)Math.Round(m.Midterm * 0.4 + m.Final * 0.6, 2),
                                      StudentGradeAverage = Math.Round(m.Midterm * 0.4 + m.Final * 0.6, 2)
                                  }).ToList();

            var groupedReport = detailedReport
                .GroupBy(x => new { x.StudentFirstName, x.StudentLastName })
                .Select(g => new StudentReportModel
                {
                    StudentFirstName = g.Key.StudentFirstName,
                    StudentLastName = g.Key.StudentLastName,
                    CourseName = string.Join(", ", g.Select(x => x.CourseName)),
                    MidtermExam = g.Any(x => x.MidtermExam.HasValue)
                        ? (int?)Math.Round(g.Where(x => x.MidtermExam.HasValue).Average(x => x.MidtermExam.Value))
                        : null,
                    FinalExam = g.Any(x => x.FinalExam.HasValue)
                        ? (int?)Math.Round(g.Where(x => x.FinalExam.HasValue).Average(x => x.FinalExam.Value))
                        : null,
                    StudentGrade = g.Sum(x => x.StudentGrade),
                    StudentGradeAverage = Math.Round(
                        g.Average(x => x.MidtermExam.Value * 0.4 + x.FinalExam.Value * 0.6), 2),
                }).ToList();





            switch (searchModel.QueryType?.Trim()?.ToLowerInvariant())
            {
                case "basari siralamasi":
                    return groupedReport
                          .OrderByDescending(x => x.StudentGradeAverage)
                          .ToList();

                case "gecen ogrenciler":
                    return groupedReport
                          .Where(x => x.StudentGradeAverage >= 50)
                          .ToList();

                case "kalan ogrenciler":
                    return groupedReport
                      .Where(x => x.StudentGradeAverage < 50)
                      .ToList();

                case "tum dersler":
                    return detailedReport;

                case "but hesabi":
                    return detailedReport
                            .Where(x => x.StudentGradeAverage < 50)
                            .Select(x => new StudentReportModel
                            {
                                StudentFirstName = x.StudentFirstName,
                                StudentLastName = x.StudentLastName,
                                CourseName = x.CourseName,
                                MidtermExam = x.MidtermExam,
                                FinalExam = x.FinalExam,
                                StudentGrade = x.StudentGrade,
                                StudentGradeAverage = x.StudentGradeAverage,
                                Message = x.MidtermExam.HasValue
                                    ? $"Geçmek için en az {(int)Math.Ceiling((50 - x.MidtermExam.Value * 0.4) / 0.6)} almalı."
                                    : "Vize notu eksik, hesaplama yapılamaz. Dersten kaldı."
                            })
                            .ToList();

                default:
                    return groupedReport;
            }



        }
    }
}
