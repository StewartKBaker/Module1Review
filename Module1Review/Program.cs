namespace Module1Review;

class Program
{
    //Create method to get the area of a circle
    public static void AreaOfCircle()
    {
        //uses a bool to loop through code when input is invalid
        bool finishCircle = false;
                    
        //loops while bool is false
        while (!finishCircle)
        {
            //Asks for radius and stores it
            Console.WriteLine("\nWhat is the Radius of your Circle?");
            string radiusInput = Console.ReadLine();
                        
            //checks to make sure its inputs can be turned into double
            if (double.TryParse(radiusInput, out double radius))
            {
                //creates a new variable to store math of area for output
                double area = Math.PI * Math.Pow(radius, 2);
                //output when input is valid
                Console.WriteLine($"\nThe area of a circle with a radius of {radius} is {area}");
                //used to exit loop
                finishCircle = true;
            }
            else
            {
                //output when input isn't valid
                Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
            }
        }
    }
    
    //Create method to get the area of a triangle
    public static void AreaOfTriangle()
    {
        //uses bool to loop through code when an invalid integer is given.
        bool finishTriangle = false;
                    
        //loops while bool is false
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
                //creates a new variable to store math of area for output
                double area = baseLength * height / 2;
                //output given when integers are valid which calls the method
                Console.WriteLine($"\nThe Area of a Triangle with the base of {baseLength} and height of {height} is {area}");
                //sets bool to true, exiting loop.
                finishTriangle = true;
            }
            else
            {
                //output when input isn't valid
                Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
            }
        }
    }
    
    //Create method to get the area of a rectangle
    public static void AreaOfRectangle()
    {
        //uses bool to loop through code if integer is invalid
        bool finishRectangle = false;
                    
        //loops while bool is false
        while (!finishRectangle)
        {
            //asks user for length and stores it in a string
            Console.WriteLine("\nWhat is the length of your rectangle?");
            string lengthInput = Console.ReadLine();
                        
            //asks user for width and stores it in a string
            Console.WriteLine("\nWhat is the width of your Rectangle?");
            string widthInput = Console.ReadLine();
                        
            //checks to make sure inputs can be changed to double and then outputs new double variables
            if (double.TryParse(lengthInput, out double length) &&
                double.TryParse(widthInput, out double width))
            {
                //creates a new variable to store math of area for output
                var area = length * width;
                //output given if inputs can be changed to double
                Console.WriteLine($"\nThe Area of a Rectangle with the length of {length} and width of {width} is {area}");
                //sets bool to true, exiting the loop
                finishRectangle = true;
            }
            else
            {
                //output given if inputs can not be changed
                Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
            }
        }
    }
    
    //Create method to get the area pf a square
    public static void AreaOfSquare()
    {
        //creates bool to loop
        bool finishSquare = false;

        //loops while bool is false
        while (!finishSquare)
        {
            //asks user for side input and stores as string
            Console.WriteLine("\nWhat is the side length of your square?");
            string sideInput = Console.ReadLine();

            //checks to make sure input can be changed to double and makes new double variable with input
            if (double.TryParse(sideInput, out double side))
            {
                //creates a new variable to store math of area for output
                var area = Math.Pow(side, 2);
                //output when input can be set to double
                Console.WriteLine($"\nThe Area of a Square with a side length of {side} is {area}");
                //sets bool to true; exiting code
                finishSquare = true;
            }
            else
            {
                //output when input cannot be set to double
                Console.WriteLine("\nInvalid Input. Please input a Valid Integer");
            }
        }
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
                    AreaOfCircle();
                    exitLoop = true; //sets exit loop to true, opening exit loop for use
                    break;
                
                //Creates case for triangle input
                case "triangle":
                    AreaOfTriangle();
                    exitLoop = true; //sets exit loop to true, opening exit loop for use
                    break;
                
                //creates case for rectangle input
                case "rectangle":
                    AreaOfRectangle();
                    exitLoop = true; //sets exit loop to true, opening exit loop for use
                    break;
                
                //creates case for user input square
                case "square":
                    AreaOfSquare();
                    exitLoop = true; //sets exit loop to true, opening exit loop for use
                    break;
                
                //default output if user input does not match any shapes
                default:
                    Console.WriteLine("Invalid Shape, Please pick a valid shape.");
                    break;
            }

            //once exit loop is set to true, exit loop will function
            if (exitLoop == true)
            {
                //asks user if they want to find the area of another shape
                Console.WriteLine("\nWould you like to find the area of another shape?\n(Y)es\n(N)o");

                //loops while exitLoop is true
                while (exitLoop)
                {

                    //sets input to string and checks if input is equal to y or Y
                    string continueProgram = Console.ReadLine();
                    if (continueProgram == "y" || continueProgram == "Y")
                    {
                        //clears console and sets exit loop back to false, restarting the code from the beginning
                        Console.Clear();
                        exitLoop = false;
                    }
                    //checks if input is equal to n or N
                    else if (continueProgram == "n" || continueProgram == "N")
                    {
                        //sets finish area to true, and exit loop to false, exiting both loops and closing the program.
                        finishArea = true;
                        exitLoop = false;
                    }
                    else
                    {
                        //output if input is not y / Y or n / N
                        Console.WriteLine("Input Invalid, please use Y or N");
                    }
                }
            }
        }
    }
}