using System;
namespace Program
{
    class Student{
        string name;
        int age;
        string faculty;
        
         static void Main (string[] args)   {

        Student Yubraj = new Student();
        Yubraj.name = "Yubraj.Yadav";
        Yubraj.age = 23;
        Yubraj.faculty = "BCA";
        
        Console.WriteLine(Yubraj.name + Yubraj.age);
       // Console.WriteLine(Yubraj.age);
        //Console.WriteLine(Yubraj.faculty);
        }
        }
    }
