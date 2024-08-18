using System;
delegate void cal(int x, int y);


class Program{
    public static void Add(int a, int b){
        Console.WriteLine(a+b);
    }
    public static void Mul(int a, int b){
          Console.WriteLine(a*b);
    }
      
      class HelloWorld{
        static void Main(){
            cal c = new cal(Add);
            c+=Mul;
            c(20,30);
        }
      }
    }

