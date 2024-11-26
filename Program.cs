using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                      //problem 1
            // declare an integer x and assign value 10
            int x = 10;

            // declare an integer غ and assign value 20
            int y = 20;

            /* Calculate the sum of x and y
            and store the result in a variable called sum */
            int sum = x + y;

            // diplay the result
            Console.WriteLine(sum);

            // Shortcut:Comment: Ctrl + K, Ctrl + C
            //Uncomment Ctrl + K, Ctrl + U
        }
    }
}


//-----------------------------------------------------------------------------------------//
// problem 2
int x = 10; // Fixed the type mismatch
int y = 20;  // Declared and initialized y
Console.WriteLine(x + y); // Fixed the casing of Console and ensured x and y are defined

// question
/*
 
 Runtime Error:
 Errors that occur while the program is running. These typically cause the program to crash or behave unexpectedly
           
Example:
int x = 10;
int y = 0;
Console.WriteLine(x / y); // Error is Division by zero

Logical Error:
Errors in the program's logic that cause incorrect results but do not stop the program from running

Example
int length = 5;
int width = 10;

int area = length - width; //using subtraction instead of multiplication 
 
 */
//Summary 
//Error Type	Runtime Error	   >>             Logical Error
//Occurs When	During program execution	>>   Program runs but gives incorrect results



//-------------------------------------------------------------------------------------------------

//                                                                                 problem 3

string FullName = "mohmadykhaled";
int Age = 20;
decimal MonthlySalary = 2000 ;
bool IsStudent = true;

/*
 Why Is It Important to Follow Naming Conventions Like PascalCase?

    a. Improves Code Readability
   b . Enhances Maintainability
  c  . Promotes Consistency in Team Projects
   d . Avoids Naming Collisions
   e . Aligns with Framework Guidelines
 */

//--------------------------------------------------------------------------------------------------------
// question 4

public class Person
{
    public string Name { get; set; }
}

public static void Main()
{
    // Create an instance of Person
    Person person1 = new Person();
    person1.Name = "mohmady";

    // Create another reference to the same object
    Person person2 = person1;

    // Display the original values
    Console.WriteLine($"person1 Name: {person1.Name}"); // mohmady
    Console.WriteLine($"person2 Name: {person2.Name}"); // mohmady

    // Change the Name property through person2
    person2.Name = "mohmady";

    // Display the values again
    Console.WriteLine($"person1 Name: {person1.Name}"); // mohmady
    Console.WriteLine($"person2 Name: {person2.Name}"); // mohmady

}

/*
 
 //Difference Between Value Types and Reference Types

1. Value Types
    Definition: Store the actual data directly in memory.
    Memory Allocation:
    Allocated on the stack.
    Each variable has its own copy of the data.
    Behavior:
    Changing the value of one variable does not affect another.
    Examples: int, float, bool, struct.

 // Example
    int a = 10;
    int b = a; // Copy of value
    b = 20;
    Console.WriteLine(a); // Output: 10 (a is unaffected)

2. Reference Types
    Definition: Store a reference (address) to the actual data in memory.
    Memory Allocation:
    Reference is stored on the stack.
    The actual data is stored on the heap.
    Behavior:
    Changing the object via one reference affects all references pointing to it.
    Examples: class, array, string.

Example

// Create an instance of Person
Person p1 = new Person { Name = "mohmady" };

// Assign p1 to p2 - p2 now refers to the same object as p1
Person p2 = p1;

// Change the Name property via p1
p1.Name = "khaled";

// Since p1 and p2 refer to the same object, the change is reflected in p2 as well
Console.WriteLine(p2.Name);  // Output: khaled
 
 */

//---------------------------------------------------------------------------------------------------
//question 5
        using System;

        class Program
{
    static void Main()
    {
        int x = 15;
        int y = 4;

        // Calculations
        int sum = x + y;
        int difference = x - y;
        int product = x * y;
        double division = (double)x / y; // Cast to double for accurate division
        int remainder = x % y;

        // Output results
        Console.WriteLine("Sum: " + sum);           //  19
        Console.WriteLine("Difference: " + difference); //  11
        Console.WriteLine("Product: " + product);       //  60
        Console.WriteLine("Division Result: " + division); //  3.75
        Console.WriteLine("Remainder: " + remainder);      //  3
    }
}

/*

 int a = 2, b = 7;
 Console.WriteLine(a % b); 2

Why?
    Operation Explanation:
    The % operator calculates the remainder when the first number (a) is divided by the second number (b).
    Here, 2 % 7 means dividing 2 by 7. Since 7 is larger than 2, the division result is 0 with a remainder of 2.
    Key Point: If the first number is smaller than the second, the remainder is always equal to the first number.

     */
//--------------------------------------------------------------------------------------------------
//                                                                                          problem  6
    
using System;

class Program
{
    static void Main()
    {
        // Prompt user for a double input
        Console.Write("Enter a double value: ");
        double userInput = double.Parse(Console.ReadLine());

        // Implicit casting (not possible here)
        // Uncommenting the next line will cause a compile-time error:
        // int implicitResult = userInput;

        // Explicit casting
        int explicitResult = (int)userInput;

        // Print the results
        Console.WriteLine("Original double value: " + userInput);
        Console.WriteLine("After explicit casting to int: " + explicitResult);
    }
}

/*
 Why is Explicit Casting Required?

    When converting a double (which has a fractional component) to an int (which only stores whole numbers), 
    there is a risk of data loss. The fractional part of the double is discarded, which may not be the intended behavior.
    To prevent accidental truncation, the compiler requires explicit confirmation that the developer understands the potential consequences.
 
 */
//-----------------------------------------------------------------------------------------
// problem 8
    

        using System;

        class Program
{
    static void Main()
    {
        int x = 5;

        // Demonstrating prefix increment
        Console.WriteLine("Initial value of x: " + x);
        Console.WriteLine("Using prefix increment (++x): " + (++x)); // x is incremented first, then used
        Console.WriteLine("Value of x after prefix increment: " + x);

        // Resetting x
        x = 5;

        // Demonstrating postfix increment
        Console.WriteLine("\nReset value of x: " + x);
        Console.WriteLine("Using postfix increment (x++): " + (x++)); // x is used first, then incremented
        Console.WriteLine("Value of x after postfix increment: " + x);
    }
}

/*
 Key Difference Between Prefix and Postfix
    1.Prefix Increment (++x):
        Increments the value of x before using it in an expression.

Example
    int x = 5;
    int result = ++x; // x becomes 6, then result is set to 6


2.Postfix Increment (x++):
    Uses the current value of x in an expression before incrementing it.

Example
    int x = 5;
    int result = x++; // result is set to 5, then x becomes 6

//___________________________________________--