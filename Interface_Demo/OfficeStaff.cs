using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    internal class OfficeStaff : IPerson    
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoining { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Office Staff Name: {Name}");
            Console.WriteLine($"Office Staff Age: {Age}");
            Console.WriteLine($"Date of Joining: {DateOfJoining.ToShortDateString()}");
        }
    }
}
