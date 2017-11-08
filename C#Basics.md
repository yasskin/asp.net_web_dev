# C# Basics

# Introduction 3:57
## with Jeremy McLain

## In this video we'll learn what C# is used for and discuss some tips for getting the most out of this course. We'll also get our first look at the project we'll be working on.

# Program Structure5:26
## with Jeremy McLain

## We'll go over the basic structure of a program and learn about classes and methods.

### Method: System.Console.ReadLine();
### Method: Namespace.Class.Method()

# Namespace allows us to make multiple classes with the same name.

namespace: Treehouse.FitnessFrog

* Console / Terminal on Windows is PowerShell ; Command Prompt , Mac Terminal, Windows PowerShell
* If a file contains only one class, typically you'll want to name the file the same as the class
* C# has .cs
* Classes often have multiple methods.
* All code is contained in a class.
* Each class usually has its own file
* Inside the class is a Method
* Methods have four Parts
1. Name - the name of the method
2. Body - contains the instructions
3. Parameters - what is passed into the method
4. The Return Type - the type of information the Method will return

* C# looks for a method named Main(). The first method that is called in the program.
* Keywords - special names reserved for the program https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/index

Preparation and Planning 3:46
with Jeremy McLain
We'll discuss The Four P's of Problem Solving.

Four P's of Problem Solving

1. Prepare - This is where we understand and diagnose the problem.
2. Plan - This is where we organize everything before acting.
3. Perform - We simply put the plan into action.
4. Perfect - This is when we check to see if what we made has solved the problem and consider how to make it better. We can use the Four P's again to make improvements.

# Start Coding 5:59
## with Jeremy McLain

## In this video we'll learn about strings and the .NET framework. We'll use this knowledge to print some text to the screen. We'll also compile and run our program for the first time.

## Code:

Clear, compile, and run:

clear && mcs Program.cs && mono Program.exe

Start REPL: csharp

Quit REPL: quit

Code:

```
using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;

            // Prompt user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            string entry = Console.ReadLine();        

            // Add minutes exercised to total

            // Display total minutes exercised to the screen
            Console.WriteLine("You've entered " + entry + " minutes.");

            // Repeat until user quits
        }
    }
}
```

# REPL 2:42
## with Jeremy McLain

### We'll learn another tool called the Mono C# REPL.

* Terminal > $ csharp

* Read Evaluate Print Loop

* To compile: mcs Program.cs

* To run: mono Program.exe
