namespace OCP
{
    
    
        public abstract class Course
        {
            public int CourseId { get; set; }
            public string Title { get; set; }

            public abstract void Subscribe(Student std);
        }

        public class OnlineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                
                Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso en línea {Title}.");
            }
        }

        public class OfflineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                
                Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso presencial {Title}.");
            }
        }

        public class HybridCourse : Course
        {
            public override void Subscribe(Student std)
            {
                
                Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso híbrido {Title}.");
            }
        }

        
        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
        }
    }




