using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
      

        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                IPerson student = new Student
                {
                    Name = "Alice",
                    Age = 20,
                    Address = "123 Main St",
                    DateOfJoining = new DateTime(2022, 8, 15)
                };
                IPerson teacher = new Teacher
                {
                    Name = "Mr. Smith",
                    Age = 35,
                    DateOfJoining = new DateTime(2010, 3, 10)
                };
                IPerson officeStaff = new OfficeStaff
                {
                    Name = "John",
                    Age = 30,
                    DateOfJoining = new DateTime(2015, 5, 20)
                };

                DisplayPersonInfo(student);
                DisplayPersonInfo(teacher);
                DisplayPersonInfo(officeStaff);
            }

            static void DisplayPersonInfo(IPerson person)
            {
                person.DisplayInfo();
                Console.WriteLine();
            Console.ReadLine();
            }
        }
    }
   
