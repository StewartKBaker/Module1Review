﻿namespace Module1Review;

class Program
{
    //Create method to get the area of a circle
    public static double AreaOfCircle(double radius)
    {
        //uses .PI and .Pow for formula of a circle and then returns area
        return Math.PI * Math.Pow(radius, 2);
    }
    
    //Create method to get the area of a triangle
    public static double AreaOfTriangle(double baseLength, double height)
    {
        return baseLength * height / 2;
    }
    
    //Create method to get the area of a rectangle
    public static double AreaOfRectangle(double length, double width)
    {
        return length * width;
    }
    
    //Create method to get the area pf a square
    public static double AreaOfSquare(double side)
    {
        //side^2
        return Math.Pow(side, 2);
    }
    
    //Used to call methods and use them
    static void Main(string[] args)
    {
        //Used to figure out which shape the user wants the area of and stores it in variable
        Console.WriteLine("What would you like the area of, Square, Rectangle, Triangle or Circle?");
        var shape = Console.ReadLine();

        //Puts user input in lowercase and then executes code depending on what matches, if none default output
        switch (shape.ToLower())
        {
            case "circle":

                break;
            case "triangle":

                break;
            case "rectangle":

                break;
            case "square":

                break;
            //default output if user input does not match any shapes
            default:
                Console.WriteLine("Invalid Shape, Please pick a valid shape.");
                break;
        }
        //Code for Triangle
        Console.WriteLine("What is the Length of your Triangle?");
        double baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the Height of your Triangle?");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine($"The are of a triangle with the baseLength of {baseLength} and height of {height} is {AreaOfTriangle(baseLength, height)}");
    }
}