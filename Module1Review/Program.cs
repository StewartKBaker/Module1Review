namespace Module1Review;

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
        
    }
}