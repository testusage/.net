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



/*using System;
using System.Collections;

internal class Program
{
    static void Main()
    {
        // Create a SortedList to store student details
        SortedList<int, string> studentList = new SortedList<int, string>();

        // Add student details
        studentList.Add(101, "Alice");
        studentList.Add(102, "Bob");
        studentList.Add(103, "Charlie");
        studentList.Add(104, "David");
        studentList.Add(105, "Eve");

        Console.WriteLine("Sorted List of Student Details:");
        foreach (var student in studentList)
        {
            Console.WriteLine($"Roll Number: {student.Key}, Name: {student.Value}");
        }
    }
}*/




/*using System;
using System.Collections;

internal class Program
{
    static void Main()
    {
        // Create an ArrayList to store the list of fruits
        ArrayList fruitList = new ArrayList();

        // Add 10 fruits to the ArrayList
        fruitList.Add("Apple");
        fruitList.Add("Banana");
        fruitList.Add("Cherry");
        fruitList.Add("Date");
        fruitList.Add("Elderberry");
        fruitList.Add("Fig");
        fruitList.Add("Grape");
        fruitList.Add("Kiwi");
        fruitList.Add("Lemon");
        fruitList.Add("Mango");

        Console.WriteLine("List of 10 Fruits:");
        DisplayFruits(fruitList);

        // Remove the last 3 fruits from the ArrayList
        int countToRemove = 3;
        int lastIndex = fruitList.Count - 1;

        for (int i = 0; i < countToRemove && lastIndex >= 0; i++)
        {
            fruitList.RemoveAt(lastIndex);
            lastIndex--;
        }

        Console.WriteLine("\nList after removing the last 3 fruits:");
        DisplayFruits(fruitList);
    }

    static void DisplayFruits(ArrayList fruits)
    {
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}*/




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




/*using System;

class Student
{
    private int rollNumber;
    private string name;
    private string specialization;

    public int RollNumber
    {
        get { return rollNumber; }
        set { rollNumber = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Specialization
    {
        get { return specialization; }
        set { specialization = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        // Set student details using properties
        student.RollNumber = 101;
        student.Name = "John Doe";
        student.Specialization = "Computer Science";

        // Get and display student details
        Console.WriteLine("Student Roll Number: " + student.RollNumber);
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Specialization: " + student.Specialization);
    }
}*/


/*class Program
{
    static void Main(string[] args)
    {
        double totalPercentage = 0;

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Enter the percentage for subject {i}:");
            double subjectPercentage = Convert.ToDouble(Console.ReadLine());
            totalPercentage += subjectPercentage;
        }

        double cgpa = totalPercentage / 9.5;

        try
        {
            if (cgpa < 4.5)
            {
                throw new Exception("Not eligible for promotion. CGPA is less than 4.5.");
            }
            else
            {
                Console.WriteLine($"Eligible for promotion. CGPA: {cgpa}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}*/



/*using System;

public class NotEligibleForVotingException : Exception
{
    public NotEligibleForVotingException() : base("Not eligible for voting")
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (age < 18)
            {
                throw new NotEligibleForVotingException();
            }
            else
            {
                Console.WriteLine("You are eligible for voting.");
            }
        }
        catch (NotEligibleForVotingException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}*/


/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter age");
        int age = Convert.ToInt32(Console.ReadLine());

        try
        {
            if(age < 18)
            {
                throw new Exception("Not eligible");
            }
            else
            {
                Console.WriteLine("Eligible");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/



/*using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Human (string name , int age)
    {
        Name = name;
        Age = age;
    }
}

class Employee : Human
{
    public int EmployeeID { get; set; }
    public int EmpSalary { get; set; }  

    public Employee(int id , int salary , string name , int age) : base(name , age)
    {
        EmployeeID = id;
        EmpSalary = salary;
    }

    public void display()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(EmployeeID);
        Console.WriteLine(EmpSalary);
    }
}

class Program
{
    static void Main()
    {
        Employee first = new Employee(111 , 2500 , "random" , 21);
        first.display();
    }
}*/


/*using System;

class Multiplication
{
    public int Multiply(int operand1 , int operand2)
    {
        return operand1 * operand2;
    }

    public int Multiply(int operand1 , int operand2 , int operand3)
    {
        return operand1 * operand2 * operand3;
    }
    public int Multiply(int operand1 , int operand2 , int operand3 , int operand4)
    {
        return (operand1 * operand2 * operand3 * operand4);
    }
}

class Program
{
    static void Main()
    {
        Multiplication first = new Multiplication();

        int res1 = first.Multiply(2, 2);
        Console.WriteLine(res1);
    }
}*/


/*using System;

class Employee
{
    public string EmpName { get; set; }
    public int EmpId { get; set; }
    public int EmpSalary { get; set; }
    public int EmpBal { get; set; }

    public Employee(string name, int id, int salary, int bal)
    {
        EmpName = name;
        EmpId = id;
        EmpSalary = salary;
        EmpBal = bal;
    }

    public void calcAndDisplay()
    {
        EmpSalary += 1000;

        Console.WriteLine(EmpName);
        Console.WriteLine(EmpId);
        Console.WriteLine(EmpSalary);
        Console.WriteLine(EmpBal);
    }
}

class Program
{
    static void Main()
    {
        Employee first = new Employee("John", 115, 2000, 7500);
        first.calcAndDisplay();
    }
}
*/


/*using System;

class consumerAccount
{
    public string Name {get; set;} 
    public string Number { get; set; }
    public int Bill { get; set; }   

    public consumerAccount(string name, string number, int bill)
    {
        Name = name;
        Number = number;
        Bill = bill;
    }

    public void calcAndDisplay()
    {
        double billamt = Bill * 2;

        Console.WriteLine(Name);
        Console.WriteLine(Number);
        Console.WriteLine(Bill);
        Console.WriteLine(billamt);
    }
}

class Program
{
    static void Main()
    {
        consumerAccount first = new consumerAccount("John","9019572098",55);
        first.calcAndDisplay();
    }
}*/
