using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    internal class Teacher:IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoining { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}");
            Console.WriteLine($"Teacher Age: {Age}");
            Console.WriteLine($"Date of Joining: {DateOfJoining.ToShortDateString()}");
        }

    }
}
