using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    internal class Student:IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime DateOfJoining { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Date of Joining: {DateOfJoining.ToShortDateString()}");
        }

    }
}
