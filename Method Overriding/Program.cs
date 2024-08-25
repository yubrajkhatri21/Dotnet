//write a c# program that demonstrates method overloading create a base class shape with a method to draw() create two derived classes circle & rectangle both overriding the draw method.//
using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

class Program
{
    static void Main()
    {
        Shape myShape = new Shape();
        myShape.Draw(); 

        Shape myCircle = new Circle();
        myCircle.Draw(); 

        Shape myRectangle = new Rectangle();
        myRectangle.Draw(); 
    }
}
