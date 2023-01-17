// See https://aka.ms/new-console-template for more information
using Session_07.NewWorld;

Console.WriteLine("Hello, World!");

Shape shape;


shape = new Circle();
Console.WriteLine("The surface of a " + shape.Name + " is " + shape.Surface(10));


shape = new Square();
Console.WriteLine("The surface of a " + shape.Name + " is " + shape.Surface(10));



