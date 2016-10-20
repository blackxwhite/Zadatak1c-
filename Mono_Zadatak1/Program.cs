using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Mono_Zadatak1
{
    class Program
    {
        public static StudentContainer sc = new StudentContainer();
        public static Validation valid = new Validation();

        static void Main(string[] args)
        {
            string operation;
            bool active = true;

            while(active)
            {
                Console.WriteLine("Operation:");
                operation = Console.ReadLine();
                if (operation.ToLower() == Operations.OperationsDisplay)
                {
                    Display();
                    active = false;
                }
                else if (operation.ToLower() == Operations.OperationsEnlist)
                    Enlist();
                else
                {
                    valid.checkOperation(operation);
                }
                Console.WriteLine("-----------------------------------");
            }
        }

        public static void Enlist()
        {
            StudentIdGenerator sg = new StudentIdGenerator();

            string FirstName;
            string LastName;
            string GPA;

            Console.WriteLine("Student");
            do
            {
                Console.Write("First name: ");
                FirstName = Console.ReadLine();
                valid.checkEmpty(FirstName);
            }
            while (!valid.success);
            do
            {
                Console.Write("Last name: ");
                LastName = Console.ReadLine();
                valid.checkEmpty(LastName);
            }
            while (!valid.success);
            do
            {
                Console.Write("GPA: ");
                GPA = Console.ReadLine();
                valid.checkNumber(GPA);
            }
            while (!valid.success);
            Student student = new Student();
            student.PersonId = sg.generateID();
            student.PersonFirstName = FirstName;
            student.PersonLastName = LastName;
            student.StudentGPA = float.Parse(GPA);
            sc.AddStudent(student);
        }

        public static void Display()
        {
            int nb = 0;
            List<Student> list = sc.FetchList();
            Console.WriteLine("Students in a system:");
            foreach (Student student in sc.FetchList())
            {
                nb++;
                Console.WriteLine(nb + ". " + student.PersonLastName + ", " + student.PersonFirstName + " - " + student.StudentGPA);
            }
        }
    }
}
