using Assignment2._2._3.Models;

//Assignment 2.2.3
// For the shape parent class the method can just be something like "The shape has an area of: " 
Console.WriteLine("Welcome! Please choose your shape.");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Square");
string shapeSelection = Console.ReadLine();
Console.WriteLine();

// Shape selection
switch (shapeSelection)
{
    case "1":
        Console.WriteLine("You have chosen circle.");
        Console.WriteLine("To calculate the area, please enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle();
        circle.CircleRadius = radius;
        Console.WriteLine($"The area is {circle.CalculateArea()}");

        break;

    case "2":
        Console.WriteLine("You have chosen square. ");
        Console.WriteLine("To calculate the area, please enter the side length: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        Square square = new Square();
        square.SideLength = sideLength;
        Console.WriteLine($"The area is: {square.CalculateArea()}.");
        break;
}