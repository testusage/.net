using System;

// Define a delegate type for area calculation
delegate double CalcArea();

class Program
{
    static void Main()
    {
        // Delegate instances for triangle and rectangle area calculation
        CalcArea triangleArea = CalculateTriangleArea;
        CalcArea rectangleArea = CalculateRectangleArea;

        // Calculate and display the area of a triangle
        double area = triangleArea();
        Console.WriteLine($"Area of the triangle: {area}");

        // Calculate and display the area of a rectangle
        area = rectangleArea();
        Console.WriteLine($"Area of the rectangle: {area}");
    }

    static double CalculateTriangleArea()
    {
        double baseLength, height;
        Console.Write("Enter the base length of the triangle: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseLength * height;
        return area;
    }

    static double CalculateRectangleArea()
    {
        double length, width;
        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        return area;
    }
}


/*using System;

// Define a delegate type for area calculation
delegate double CalcArea();

class Program
{
    static void Main(string[] args)
    {
        //Delegate instances
        CalcArea r = () => CalcRectArea(5,4);
        CalcArea t = () => CalcTriArea(2, 3);

        double rArea = r();
        Console.WriteLine(rArea);

        double tArea = t();
        Console.WriteLine(tArea);
    }

    static double CalcRectArea(int l , int b) 
    {
        return l * b;
    }
    static double CalcTriArea(int l , int b )
    {
        return 0.5 * l * b;
    }
}*/
