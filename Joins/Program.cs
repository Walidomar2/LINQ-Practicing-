using System.Linq;

namespace Joins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JoinFunc();
            // JoinQueryFunc();
          GroupJoinFunc();
        }

        public static void JoinFunc()
        {
            var students = SCRepository.GetAllStudents();
            var courses = SCRepository.GetAllCourses();

            var joinResult = students.Join(courses,
                                            student => student.CourseId,
                                            course => course.CourseId,
                                            (student, course) => new
                                            {
                                                StudentName = student.StudentName,
                                                CourseName = course.CourseName
                                            });

            foreach (var studentCourse in joinResult)
            {
                Console.WriteLine($"Student: {studentCourse.StudentName}," +
                    $" Course: {studentCourse.CourseName}");
            }

        }


        public static void JoinQueryFunc()
        {
            var students = SCRepository.GetAllStudents();
            var courses = SCRepository.GetAllCourses();

            var joinResult = from student in students
                             join course in courses on student.CourseId equals course.CourseId
                             select new
                             {
                                 StudentName = student.StudentName,
                                 CourseName = course.CourseName
                             } ;

            foreach (var studentCourse in joinResult)
            {
                Console.WriteLine($"Student: {studentCourse.StudentName}," +
                    $" Course: {studentCourse.CourseName}");
            }

        }

        public static void GroupJoinFunc()
        {
            var students = SCRepository.GetAllStudents();
            var courses = SCRepository.GetAllCourses();

            var joinResult = courses.GroupJoin(students,
                                                course => course.CourseId,
                                                student => student.CourseId,
                                                (course, students) => new
                                                {
                                                    CourseName = course.CourseName,
                                                    studentList = students.Select(s => s.StudentName).ToList()

                                                });

            // Use a HashSet to keep track of printed course names to avoid duplicates
            var printedCourses = new HashSet<string>();

            // Display the results
            foreach (var studentCourse in joinResult)
            {
                if (!printedCourses.Contains(studentCourse.CourseName))
                {
                    printedCourses.Add(studentCourse.CourseName);
                    Console.WriteLine($"-----------Students in Course {studentCourse.CourseName}-----------");
                    foreach (var student in studentCourse.studentList)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

        }

    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        //public int StudentId { get; set; } // Foreign Key
    }

    public static class SCRepository
    {
        public static List<Student> GetAllStudents()
        {
          return  new List<Student>
                {
                     new Student { StudentId = 1, StudentName = "John", CourseId = 101 },
                     new Student { StudentId = 2, StudentName = "Steve", CourseId = 102 },
                     new Student { StudentId = 3, StudentName = "Bill", CourseId = 103 },
                     new Student { StudentId = 4, StudentName = "Ram", CourseId = 104 },
                     new Student { StudentId = 5, StudentName = "Ron", CourseId = 105 },
                     new Student { StudentId = 6, StudentName = "Jack", CourseId = 101 }
                };
        }


        public static List<Course> GetAllCourses()
        {
            return new List<Course>
                {
                     new Course { CourseId = 101, CourseName = "Mathematics"},
                     new Course { CourseId = 101, CourseName = "Mathematics"},
                     new Course { CourseId = 102, CourseName = "Science"},
                     new Course { CourseId = 103, CourseName = "History"},
                     new Course { CourseId = 104, CourseName = "Geography"},
                     new Course { CourseId = 105, CourseName = "Economics"}
                };
        }
    }
}
