# Welcome 1:30
## with Jeremy McLain
## In this course, we'll build a tower defense game while we learn about how to do object oriented programming in C#.

C# Basics Course on Treehouse
https://teamtreehouse.com/library/c-basics

Courses on Game Development in C# at Treehouse
https://teamtreehouse.com/library/topic:game-development

# Object-Oriented Programming
## What does object-oriented programming really mean?

* Objects have attributes and behaviors

# Types 3:14
## with Jeremy McLain

## Every class defines a new type. Objects are just instances of a type.

* Every object is of a certain type
  * 5 10 23 are objects of type int
  * 3.14 is an object of type double
  * "Hello" "Bob" are objects of type string

* Class is a template for making individual objects of a particular type
* Type and classes can be used interchangeably
* An object is an instance of a type

Click on the Downloads tab to download all the code written in each video of this course.

C# Namespaces from C# Basics Course

Common C# Naming Conventions

# Fields 6:18
## with Jeremy McLain
## Fields define the attributes an object can have.

## Console Foundations Course

## Additional information about how to use the Mono C# Compiler can be found by typing mcs --help in the command prompt.

* Remove a file: rm <filename>

* List files in the current directory: ls

* Compile Treehouse Defense: mcs -out:TreehouseDefense.exe \*.cs

* Run Treehouse Defense: mono TreehouseDefense.exe

* Compile and run Treehouse Defense: mcs -out:TreehouseDefense.exe \*.cs && mono TreehouseDefense.exe

# Object Initialization5:14
## with Jeremy McLain

## We can set the values of an object's fields to an initial value when it's created.

## Common C# Naming Conventions
https://en.wikibooks.org/wiki/C_Sharp_Programming/Naming


# Methods 7:03
## with Jeremy McLain

## Methods define an object's behaviors.

## In this video we used three different conditional operators. && is called the conditional-and operator, || is the conditional-or operator, and ! is the logical negation operator. These are also known as boolean logic operators. When learning boolean logic it is often helpful to see the truth tables of the operations. Truth tables list all the possible values of the operands that the operators can take. The far right column of the table shows the result of doing the operation.

## && Operator Documentation
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-and-operator

X	Y	X && Y
true	true	true
true	false	false
false	true	false
false	false	false

|| Operator Documentation

X	Y	X || Y
true	true	true
true	false	true
false	true	true
false	false	false

! Operator Documentation

X	!X
true	false
false	true
Short-Circuiting

## When evaluating an expression involving && or || operators, C# uses a practice called short-circuiting. This means that C# will try to do as little work as possible when evaluating a boolean expression. The code "short-circuits" differently depending on the operator being used.

* For example, consider this expression:

```
x || y || z
```

If x is true, then C# won't even consider the values of y or z, because when using || only one of the values must be true in order for the entire expression to evaluate to true. Look at the truth table for || to see this fact.

Likewise, when using &&:

x && y && z

If x is false, then C# won't look at the values of y or z, because when using && only one of the values must be false in order for the entire expression to evaluate to false. Look at the truth table for && to see this fact.

This is especially important to understand when the conditional expression contains more complex code. Consider this example:

x || SomeMethodThatReturnsABoolean()

If x is true, then the method will not be run. If x is false, then C# will continue evaluating the expression looking for the first operand that evaluates to true, and the method will be run as part of that evaluation.

In general it's best practice to keep conditional expressions as simple as possible. There are a few examples of times when short-circuiting can be very helpful. Consider the following example where I only want to do something if the names array contains at least one item.

if(names != null && names.Length > 0)
{
    // Do something with names
}

Without short-circuiting, accessing the Length property of the names array would throw an exception if names was null. But with short-circuiting, names.Length will never get run if names is null so it's safe to put both these expressions together. Just remember that order is important. Boolean expressions are evaluated from left to right, with respect to parenthesis of course.

## C# Objects with Jeremy McLain

* Object behaviors are defined using methods.

*  Methods define an object's behaviors.

## Some methods return the result of their work as a return value.
