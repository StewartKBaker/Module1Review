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
        //bool used for the exitLoop, so the user can find the area of another shape without having to press play again
        bool exitLoop = false;
        //bool used to loop through code if an invalid shape is given so user doesn't have to press play again
        bool finishArea = false;
        while (!finishArea)
        {
            //Used to figure out which shape the user wants the area of and stores it in variable
            Console.WriteLine("What would you like the area of, Square, Rectangle, Triangle or Circle?");
            var shape = Console.ReadLine();


            //Puts user input in lowercase and then executes code depending on what matches, if none default output
            switch (shape.ToLower())
            {
                //creates case for circle input
                case "circle":
                    //uses a bool to loop through code when input is invalid
                    bool finishCircle = false;
                    
                    while (!finishCircle)
                    {
                        //Asks for radius and stores it
                        Console.WriteLine("\nWhat is the Radius of your Circle?");
                        string radiusInput = Console.ReadLine();
                        
                        //checks to make sure its inputs can be turned into double
                        if (double.TryParse(radiusInput, out double radius))
                        {
                            //output when input is valid
                            Console.WriteLine($"\nThe area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
                            //used to exit loop
                            finishCircle = true;
                        }
                        else
                        {
                            //output when input isn't valid
                            Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
                        }
                    }

                    exitLoop = true;
                    break;

                    //Creates case for triangle input
                    case "triangle":
                    //uses bool to loop through code when an invalid integer is given.
                    bool finishTriangle = false;

                    while (!finishTriangle)
                    {
                        //Asks user for length and stores it
                        Console.WriteLine("\nWhat is the Length of your Triangle?");
                        string baseLengthInput = Console.ReadLine();

                        //Asks user for height and stores it
                        Console.WriteLine("\nWhat is the Height of your Triangle?");
                        string heightInput = Console.ReadLine();

                        //TryParse to make sure both inputs are an integer, if not, prints else statement and loops back for new input
                        if (double.TryParse(baseLengthInput, out double baseLength) &&
                            double.TryParse(heightInput, out double height))
                        {
                            //output given when integers are valid which calls the method
                            Console.WriteLine($"\nThe Area of a Triangle with the base of {baseLength} and height of {height} is {AreaOfTriangle(baseLength, height)}");
                            //sets bool to true, exiting loop.
                            finishTriangle = true;
                        }
                        else
                        {
                            //output when input isnt valid
                            Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
                        }
                    }

                    exitLoop = true;
                    break;

                case "rectangle":
                    bool finishRectangle = false;

                    while (!finishRectangle)
                    {
                        Console.WriteLine("\nWhat is the length of your rectangle?");
                        string lengthInput = Console.ReadLine();
                        
                        Console.WriteLine("\nWhat is the width of your Rectangle?");
                        string widthInput = Console.ReadLine();

                        if (double.TryParse(lengthInput, out double length) &&
                            double.TryParse(widthInput, out double width))
                        {
                            Console.WriteLine($"\nThe Area of a Rectangle with the length of {length} and width of {width} is {AreaOfRectangle(length, width)}");
                            finishRectangle = true;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
                        }
                    }

                    exitLoop = true;
                    break;
                
                case "square":

                    break;
                
                //default output if user input does not match any shapes
                default:
                    Console.WriteLine("Invalid Shape, Please pick a valid shape.");
                    break;
            }

            if (exitLoop == true)
            {
                Console.WriteLine("\nWould you like to find the area of another shape?\n(Y)es\n(N)o");

                while (exitLoop)
                {

                    string continueProgram = Console.ReadLine();
                    if (continueProgram == "y" || continueProgram == "Y")
                    {
                        Console.Clear();
                        exitLoop = false;
                    }
                    else if (continueProgram == "n" || continueProgram == "N")
                    {
                        finishArea = true;
                        exitLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Input Invalid, please use Y or N");
                    }
                }
            }
        }
        
    }
}