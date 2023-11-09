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
