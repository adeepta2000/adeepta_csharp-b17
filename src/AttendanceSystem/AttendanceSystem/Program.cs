using AttendanceSystem;
using AttendanceSystem.Model;
using AttendanceSystem.Services;


ProjectDbContext projectDbContext = new ProjectDbContext();

Login login = new Login();

string role = login.UserLogin(projectDbContext);

while(true)
{
    if (role == "Admin")
    {
        AdminService adminService = new AdminService(projectDbContext);
        AdminTask(adminService);
    }
    else if (role == "Teacher")
    {
        Console.WriteLine("This is teacher page.");
    }
    else if (role == "Student")
    {
        Console.WriteLine("This is student page.");
    }
    else
    {
        Console.WriteLine("Login Failed.");
        break;
    }

    role = login.UserLogin(projectDbContext);

}

static void AdminTask(AdminService adminService)
{
    while (true)
    {
        Console.WriteLine("Choose an option to continue: ");
        Console.WriteLine("1. Create Teacher");
        Console.WriteLine("2. Create Student");
        Console.WriteLine("3. Create Course");
        Console.WriteLine("4. Assign Teacher in Course");
        Console.WriteLine("5. Assign Student in Course");
        Console.WriteLine("6. Set Class Schedule");
        Console.WriteLine("7. Logout");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter Teacher Name: ");
                string teacherName = Console.ReadLine();
                Console.Write("Enter Teacher Username: ");
                string teacherUsername = Console.ReadLine();
                Console.Write("Enter Teacher Password: ");
                string teacherPassword = Console.ReadLine();
                adminService.CreateTeacher(teacherName, teacherUsername, teacherPassword);
                break;

            case "2":
                Console.Write("Enter Student Name: ");
                string studentName = Console.ReadLine();
                Console.Write("Enter Student Username: ");
                string studentUsername = Console.ReadLine();
                Console.Write("Enter Student Password: ");
                string studentPassword = Console.ReadLine();
                adminService.CreateStudent(studentName, studentUsername, studentPassword);
                break;

            case "3":
                Console.Write("Enter Course Name:");
                string courseName = Console.ReadLine();
                Console.Write("Enter Course Fees:");
                decimal courseFees = Convert.ToDecimal(Console.ReadLine());
                adminService.CreateCourse(courseName, courseFees);
                break;

            case "4":
                return;
        }
    }
}






