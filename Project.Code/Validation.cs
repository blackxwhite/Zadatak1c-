using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        public bool success = false;

        public void checkOperation(string operation)
        {
            if (operation.ToLower() != Operations.OperationsDisplay || operation.ToLower() != Operations.OperationsEnlist)
            {
                Console.WriteLine("Operation doesn't exists!");
            }
        }

        public void checkEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You need to insert value.");
                success = false;
            }
            else
                success = true;
        }

        public void checkNumber(string gpa)
        {
            float nr;
            bool checkNumber = float.TryParse(gpa, out nr);

            if (!checkNumber)
            {
                Console.WriteLine("You need to insert numerical value.");
                success = false;
            }

            else if (nr < 1 || nr > 5)
            {
                Console.WriteLine("Please insert number between 1 and 5.");
                success = false;
            }
            else
                success = true;
        }
    }
}
