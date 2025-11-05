public class Circle
{
    // Declare a constant variable
    public const double PI = 3.14;

    public double Radius { get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return PI * Radius * Radius;
    }

    // Method to calculate perimeter
    public double CalculatePerimeter()
    {
        return 2 * PI * Radius;
    }
}


class Program
{
    static void Main()
    {
        // Try modifying the value of PI
        // Circle.PI = 3.1416; // This line will cause a compilation error

        /*
         * ERROR:
         * The left-hand side of an assignment must be a variable, property or indexer.
         * 'Circle.PI' is a constant — constants are read-only and cannot be changed after declaration.
         */

        Circle circle = new Circle(5);
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
    }
}