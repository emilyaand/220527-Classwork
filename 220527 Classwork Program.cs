using System;

namespace _220527_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.No = "P323";
            string answer;         
            do
            {
                Student student = new Student();
                Console.WriteLine("Input Fullname");
                student.FullName = Console.ReadLine();
                Console.WriteLine("input point");
                bool TryPoint = int.TryParse(Console.ReadLine(), out int point);
                student.Point = point;
                group.AddStudent(student);
                Console.WriteLine("Would u like to continue? yes/no");
                answer = Console.ReadLine();
            } while (answer=="yes");
            Console.WriteLine("gorev tamam");
            foreach (var item in group.students)
            {
                Console.WriteLine($"{item.FullName} {item.Point}");
            }
        }
    }
}
