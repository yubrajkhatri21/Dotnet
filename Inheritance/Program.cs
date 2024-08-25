//write a c# program that demonstrates how constructors work in inheritance create a base class with a constructor & a derived class with a constructor in short//
using System;

namespace InheritanceDemo
{
    
    class Animal
    {
        
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    class Dog : Animal
    {
     
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Animal myAnimal = new Animal();
            myAnimal.Speak(); 

            Dog myDog = new Dog();
            myDog.Speak(); 
          
            Animal myPet = new Dog();
            myPet.Speak(); 
        }
    }
}
