using AttendanceSystem.Model;
using AttendanceSystem.Model.DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Services
{
    public class AdminService
    {
        private readonly ProjectDbContext _projectDbContext;
        public AdminService(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public void CreateTeacher(string name, string username, string password)
        {
            var teacher = new User
            {
                Name = name,
                Username = username,
                Password = password,
                UserRole = "Teacher"
            };

            _projectDbContext.Users.Add(teacher);
            _projectDbContext.SaveChanges();
        }

        public void CreateStudent(string name, string username, string password)
        {
            var student = new User
            {
                Name = name,
                Username = username,
                Password = password,
                UserRole = "Student"
            };

            _projectDbContext.Users.Add(student);
            _projectDbContext.SaveChanges();
        }

        public void CreateCourse(string courseName, decimal fees)
        {
            var course = new Course
            {
                CourseName = courseName,
                Fees = fees
            };

            _projectDbContext.Courses.Add(course);
            _projectDbContext.SaveChanges();
        }
    }
}
