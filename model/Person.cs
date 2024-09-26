using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct.model
{
    internal class Person
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display person information
        public virtual void DisplayPersonInfo()  // Using virtual to allow overriding
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class from Person
    internal class Employee : Person
    {
        public string Designation { get; set; }

        // Constructor that calls base constructor
        public Employee(string name, int age, string designation) : base(name, age)
        {
            Designation = designation;
        }

        // Override method to display employee information
        public override void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}" +
                $" Age: {Age}" +
                $" Designation: {Designation}");
        }
    }
}
