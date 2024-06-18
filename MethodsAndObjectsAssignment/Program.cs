using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing class employee and giving it names 
            Employee Sam = new Employee() { FirstName = "Sample ", LastName = "Student" };
            //superclass method of sayname() on the employee object 
            Sam.SayName();
            Console.ReadLine();
        }
    }
}
