using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        List<Student> list = new List<Student>();

        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public List<Student> FetchList()
        {
            List<Student> newlist = list.OrderBy(student => student.PersonLastName).ToList();
            return newlist;
        }
    }
}
