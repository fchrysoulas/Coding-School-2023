using Session_04;
using System.ComponentModel;

internal class Program {

    private static void Main(string[] args) {
    
        Console.WriteLine("Hello, World!");

        // local (object) 
        //Square mySq = new Square();

        //string functionDescription = "the surface is : " + mySq.Surface();

        //Console.WriteLine(functionDescription);

        ////int i = Convert.ToInt32("1");

        //decimal j = (5 + 6) / 2;

        


        // 1. Write a C# program to print Hello and your name in the same line. 
        string hello = "Hello";
        string name = "Fotis";

        Console.WriteLine(hello + " " + name);

        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());

        Console.ReadLine();

    }
}