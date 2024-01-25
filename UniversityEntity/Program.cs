using Univer.Domain.Entity;
using Univer.Service.Service;

StudentsService studentsService =new StudentsService();
CourseService courseService =new CourseService();

Students students = new Students()
{
    Id = 2,
    LastName="Ali",
    FirstName="G'ani",
    Course="C#",
    PhoneNumber="+998904417805",
    Payment=1600000
};

studentsService.Insert(students);
//studentsService.Delete(1);
//studentsService.Update(2, students);