// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Animal{
    public void eat(){
        System.Console.WriteLine("waam waam");
    }
}

class Dog : Animal{
    public void eat(){
        System.Console.WriteLine("peadegree");
    }
    
    public void eat(int a){
        System.Console.WriteLine("dog walked"+" "+a);
    }
    
}

class Cat : Animal{
    public void eat(int num){
        for(int i=0;i<num;i++){
            System.Console.WriteLine("fish");
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.eat();
        
        Dog myDog = new Dog();
        myDog.eat();
        myDog.eat(3);
        
        Cat myCat= new Cat();
        myCat.eat(3);
        
    }
}