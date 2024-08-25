//write a c# program to demonstrate the use of base keywords create a base class with a method to display and create a child class that overrides the display method but also the base class display method//
using System;

class Person
{
    public virtual void Display()
    {
        Console.WriteLine("Display method in Person class.");
    }
}

class Employee : Person
{
    public override void Display()
    {
        base.Display(); 
        Console.WriteLine("Display method in Employee class.");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Display();  
    }
}
