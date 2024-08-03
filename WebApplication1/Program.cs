using System;
using OCP;


class Program
{
    static void Main(string[] args)
    {
       
        Student student = new Student { StudentId = 1, Name = "Juan P�rez" };

        
        Course onlineCourse = new OnlineCourse { CourseId = 101, Title = "Curso en L�nea" };
        onlineCourse.Subscribe(student);

        
        Course offlineCourse = new OfflineCourse { CourseId = 102, Title = "Curso Presencial" };
        offlineCourse.Subscribe(student);

        
        Course hybridCourse = new HybridCourse { CourseId = 103, Title = "Curso H�brido" };
        hybridCourse.Subscribe(student);
    }
}
