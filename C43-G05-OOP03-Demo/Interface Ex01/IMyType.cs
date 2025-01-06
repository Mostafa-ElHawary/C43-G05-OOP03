using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Interface_Ex01
{
    internal interface IMyType
    {
        // Interface Concept in C# OOP

        // Interfaces in C
        // #define a contract that classes can implement. They specify a set of methods, properties, events, and indexers that a class must provide if it claims to implement that interface. Interfaces themselves don't contain implementation details; they just declare the members. Think of an interface as a blueprint or a template.

        // Key characteristics of interfaces:

        // No implementation: Interfaces only declare members; they don't provide implementation code.

        // Multiple inheritance: A class can implement multiple interfaces, achieving a form of multiple inheritance(since C# doesn't support multiple class inheritance).

        // Polymorphism: Interfaces enable polymorphism.You can treat objects of different classes that implement the same interface uniformly.

        // Abstraction: Interfaces provide abstraction by hiding implementation details and exposing only the necessary members.

        // Loose coupling: Interfaces promote loose coupling between classes, making code more flexible and maintainable.

        // What can write inside the interface ? 
        // 1. signature of method (Name , Return Type , Parameteers)
        // 2. Signature of property
        // 3. Default Implemented Method (Fully Implemented Method)

        //ex

        // 1. signature of method (Name , Return Type , Parameteers)

        void MyFun(); // signature of method 

        // 2. Signature of property

        double Salary { get; set; } //  Signature of property

        // 3. Default Implemented Method (Fully Implemented Method) 

        void Print() //  Default Implemented Method (Fully Implemented Method)
        {
            Console.WriteLine(" Default Implemented Method (Fully Implemented Method)");
        }


    }
}
