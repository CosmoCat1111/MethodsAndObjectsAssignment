using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person //class called person
    {
        //two properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            //display full name
            Console.WriteLine("Name :" + (FirstName ) +( LastName));
        }
    }
}
