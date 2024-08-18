using System;

struct Employee {
    public int id;
    public string name;
    public string salary;
}

class Program {
    static void Main(string[] args) {
       
        Employee employee1 = new Employee();
        employee1.id = 1;
        employee1.name = "Hari";
        employee1.salary = "10,000";

       
        Employee employee2 = new Employee();
        employee2.id = 2;
        employee2.name = "Ram";
        employee2.salary = "12,000";

       
        Console.WriteLine($"Employee 1: ID = {employee1.id}, Name = {employee1.name}, Salary = {employee1.salary}");
        Console.WriteLine($"Employee 2: ID = {employee2.id}, Name = {employee2.name}, Salary = {employee2.salary}");
    }
}
