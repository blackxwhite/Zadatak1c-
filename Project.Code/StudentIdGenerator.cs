using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
