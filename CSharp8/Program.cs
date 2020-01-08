using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Student stud = new Student
            {
                Name = "Anish",
                Age = 31,
                Grade = "a",
                Teachers = new Teacher
                {
                    Name = "Jiya",
                    Salary = 100
                }
            };
            Console.WriteLine(CheckIfStudentHasTeacherWithSalary(stud));
        }

        /// <summary>
        /// Property patterns
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        static bool CheckIfStudentHasTeacherWithSalaryPropertyPatterns(Student student) =>
            student is { Name: "Anish", Teachers:{ Salary:100, Name:"Jiya"  } };


        static string GetFormattedString(Student student)
        => student switch
        {
            //switch with property patterns
            TalkativeSudent { Name: "anish" , talkative:true} r1 => $"Anish is talkative",

            //nested switch with property patterns
            TalkativeSudent { talkative:true} r=> r switch{
                TalkativeSudent { Name: "anish" } r1 => $"Anish is very talkative",
                TalkativeSudent  r2 => $"{r2.Name} is talkative",
            },

            TalkativeSudent { talkative:false} x=> $"{x.Name} is getting better", 

            Student s =>$"{s.Name} is a good student",

            //default with discard patterns
            _=> $"Unknown student {student.Name}"
        };


        /// <summary>
        /// Postional Patterns
        /// </summary>
        /// <param name="stud"></param>
        /// <returns></returns>
        static bool CheckIfStudentHasTeacherWithSalary(Student stud)
        {
            // checks if a student with name anish has a teacher with name Jiya and salary 100
            //Positional parameters can only be used if deconstruct method is defined in the class
            // the _ means discard, that is we dont care about the value for those elemens
            return stud is { Name: "Anish", Age: _, Grade: _, Teachers: { Name: "Jiya", Salary: 100 } };
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Teacher Teachers { get; set; }

        public void Deconstruct(out int age, out string grade, out string name, out Teacher teacher)
        {
            age = Age;
            grade = Grade;
            name = Name;
            teacher = Teachers;
        }

    }

    class TalkativeSudent: Student
    {
        public bool talkative { get; set; }
    }

    class Teacher
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public void Deconstruct(out string name, out int salary)
        {
            name = Name;
            salary = Salary;
        }
    }
}
