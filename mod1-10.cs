/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("XYZ Company Employee Details");
        Console.WriteLine("Enter Employee Number (EmpNo):");
        int empNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee Name (EmpName):");
        string empName = Console.ReadLine();

        Console.WriteLine("Enter Designation:");
        string designation = Console.ReadLine();

        Console.WriteLine("Enter Total Salary:");
        double totalSalary = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Employee Number (EmpNo): " + empNo);
        Console.WriteLine("Employee Name (EmpName): " + empName);
        Console.WriteLine("Designation: " + designation);
        Console.WriteLine("Total Salary: $" + totalSalary);
    }
}*/



/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Interest Calculator");
        Console.WriteLine("Enter the Principal amount (P):");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest (R) in percentage:");
        double rateOfInterest = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Time (T) in years:");
        double time = Convert.ToDouble(Console.ReadLine());

        // Convert the rate of interest from percentage to decimal
        rateOfInterest = rateOfInterest / 100;

        // Calculate Simple Interest
        double simpleInterest = (principal * rateOfInterest * time);

        Console.WriteLine($"Principal Amount (P): {principal:C}");
        Console.WriteLine($"Rate of Interest (R): {rateOfInterest:P}");
        Console.WriteLine($"Time (T): {time} years");
        Console.WriteLine($"Simple Interest (SI): {simpleInterest:C}");
    }
}*/



/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your birth year:");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = 2023;
        int age = currentYear - birthYear;

        if (age >= 18)
        {
            Console.WriteLine("You are eligible for voting.");
        }
        else
        {
            Console.WriteLine("You are not eligible for voting.");
        }
    }
}*/



/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the marks for three subjects:");
        Console.Write("Subject 1: ");
        int subject1Marks = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 2: ");
        int subject2Marks = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 3: ");
        int subject3Marks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = subject1Marks + subject2Marks + subject3Marks;
        double averageMarks = totalMarks / 3.0;

        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks:F2}");

        string grade;

        if (averageMarks >= 90)
        {
            grade = "Excellent";
        }
        else if (averageMarks >= 70)
        {
            grade = "Good";
        }
        else
        {
            grade = "Average";
        }

        Console.WriteLine($"Grade: {grade}");
    }
}*/


/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer to display its multiplication table:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}*/



/*using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's a palindrome:");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number = number / 10;
        }

        if (originalNumber == reversedNumber)
        {
            Console.WriteLine($"{originalNumber} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a palindrome.");
        }
    }
}*/




/*class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 4, 8, 4, 10, 12, 14, 10 };

        Console.WriteLine("Enter the number to search:");
        int targetNumber = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == targetNumber)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"Number {targetNumber} found {count} times in the array.");
        }
        else
        {
            Console.WriteLine($"Number {targetNumber} not found in the array.");
        }
    }
}*/



/*class Program
{
    static void Main()
    {
        int[,] twoDimArray = new int[2, 5]; // 2 rows and 5 columns

        // Populate the two-dimensional array with even numbers
        int evenNumber = 2;
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                twoDimArray[row, col] = evenNumber;
                evenNumber += 2;
            }
        }

        // Display the even numbers from the two-dimensional array
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(twoDimArray[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}*/
