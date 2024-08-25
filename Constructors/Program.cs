using System;

class Person
{
    public Person()
    {
        Console.WriteLine("Person Constructor");
    }
}

class Employee : Person
{
    public Employee()
    {
        Console.WriteLine("Employee Constructor");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        
    }
}
