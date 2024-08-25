//write a c# program that demonstrates multilevel inheritance. create a base class person a derived class employee & another derived class manager each class should have a method that prints a message indicated its level in the hierarchy//

using System;

class Person
{
    public void ShowLevel() => Console.WriteLine("This is the Person level.");
}

class Employee : Person
{
    public void ShowLevel() => Console.WriteLine("This is the Employee level.");
}

class Manager : Employee
{
    public void ShowLevel() => Console.WriteLine("This is the Manager level.");
}

class Program
{
    static void Main()
    {
        new Person().ShowLevel();    
        new Employee().ShowLevel();  
        new Manager().ShowLevel();   
    }
}
