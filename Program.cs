using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStruct.model;

namespace ClassStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct: Value Type - Creates a copy
            Point p1 = new Point(3, 4);
            Point p2 = p1;  // p2 is a copy of p1 (value type behavior)
            p2.X = 10;      // Changing p2 does not affect p1

            Console.WriteLine("Struct Example:");
            p1.DisplayPoint();  // Output: Point coordinates: (3, 4)
            p2.DisplayPoint();  // Output: Point coordinates: (10, 4)

            // Class: Reference Type - Both variables reference the same object
            Person person1 = new Person("Shubham", 21);
            Person person2 = person1;  // person2 refers to the same object as person1 (reference type behavior)
            person2.Name = "Pawar";      // Changing person2 affects person1

            Console.WriteLine("\nClass Example:");
            person1.DisplayPersonInfo();  // Output: Name: Pawar, Age: 21
            person2.DisplayPersonInfo();  // Output: Name: Pawar, Age: 21

            // Inheritance example
            Console.WriteLine("\nInheritance Example:");

            Employee employee1 = new Employee("Shivaraj", 22, "Software Engineer");
            employee1.DisplayPersonInfo();  // Output: Name: Shivaraj, Age: 22, Job Title: Software Engineer

            // Struct is passed by value, and class is passed by reference.
            ModifyStruct(p1);
            Console.WriteLine("\nAfter modifying struct:");
            p1.DisplayPoint();  // p1 remains unchanged, Output: Point coordinates: (3, 4)

            ModifyClass(person1);
            Console.WriteLine("\nAfter modifying class:");
            person1.DisplayPersonInfo();  // person1 is changed, Output: Name: Shivaraj, Age: 22
        }

        // Method to modify a struct (passed by value)
        static void ModifyStruct(Point point)
        {
            point.X = 50;  // This modification won't affect the original struct
        }

        // Method to modify a class (passed by reference)
        static void ModifyClass(Person person)
        {
            person.Name = "Shivaraj";  // This modification will affect the original class instance
        }
    }
    
}
