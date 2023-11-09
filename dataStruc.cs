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
