using System;
public delegate void cal(int x, int y);
class Program {
    static void Main() {
        cal cAdd= delegate(int a, int b){
            Console.WriteLine(a+b);
        };
        cAdd(20,30);
    }
}
