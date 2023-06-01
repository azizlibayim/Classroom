namespace Classroom
{

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    internal class Student : Person
    {
        public Student(string name, string surname, int age) : base(name, surname, age)
        { }

        public string Learn()
        {
            return "learning...";
        }


    }

    public class Teacher : Person
    {


        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public string Explain()
        {
            return "explaining...";
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Lala", "Aliyeva", 50);



            Console.WriteLine($"{student.Name} {student.Surname} ({student.Age}) is {student.Learn()}");

            Teacher teacher = new Teacher("Leyla", "Azizova", 27);
            Console.WriteLine($"{teacher.Name} {teacher.Surname} ({teacher.Age}) is {teacher.Explain()}");


        }
    }
}