using System;
// using keyword in C# => import keyword in Java
/* 
IMPORTANT NOTE:
***************
There are two ways to declare a namespace:
1. Traditional (block-scoped) namespace (older before C# version 10) => namespace LinuxCommandsApp { all class code ... }
2. File-scoped namespace (newer and simpler since C# version 10) => namespace LinuxCommandsApp;

Block-scoped => namespace App { ... }
File-scoped => namespace App;
 */
namespace LinuxCommandsApp;
/*
"LinuxCommand" => Blueprint class for a Linux command.
Demonstrates Object-Oriented Programming (OOP) concepts:
    - Encapsulation: properties are exposed with getters/setters
    - Constructor: initialize object state
    - Methods: define object behavior
*/

public class LinuxCommand
{
    // We need to fields: Command Name & Command Description:
    // instead of crating private fields then public getters/setters:
    /*
    private string command;
    private string desc;
    */

    // we can just create the public getters and setters immediately:
    // Properties (Encapsulation)
    // --------------------------
    // Command => Name of the Linux command, example: "ls".
    // Public getter and setter allows controlled access.
    // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

    public string Command { get; set; } = "";

    // Description of the Linux command, example: "List directory contents".
    // Public getter and setter allows controlled access.
    public string Description { get; set; } = "";

    /* 
    General C# NOTE:
    ****************
    When nullable reference types are enabled in the .csproj xml file, C# gives a compiler warning about Non-nullable string.
    We can use three valid options to clear this warning:
    
    Option 1: Initialize with an empty string => If the property should never be null:
        > as we did in our code above
    
    Option 2: Mark it as nullable => If the property can sometimes be null:
        We explicitly tell the compiler it can be null, so no warning:
        > public string? Command { get; set; }

    Option 3: Initialize in the constructor => initializing the properties inside the class Constructor
        The compiler will see that "Command" and "Description" will always be initialized before the object is used
        as we did in our custom constructor below

    Notice that This warning only happens when nullable reference types are enabled in the .csproj file:
    <Nullable>enable</Nullable>
     */

    // for example (no need, just a demo):
    public int CommandId { get; set; }

    /* 
    You will need to add at least one more field in your task
    */

    // Constructor:
    // ------------
    // Initializes a new instance of the LinuxCommand class.
    // Constructor ensures that Command and Description are set when creating an object.
    // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
    /// <param name="command">Command name</param>
    /// <param name="description">Command description</param>
    public LinuxCommand(string command, string description)
    {
        // initializing the class properties:
        Command = command; // Assign "command" argument/parameters to the Command property
        Description = description; // Assign the "description" argument/parameters to "Description property
    }

    /* 
    NOTE:
    *****
    Notice that the compiler gives us this warning: "Use primary constructor"
    Starting with C# 12, we can define a primary constructor directly in a class declaration
    instead of writing a traditional constructor!
    However we can ignore this feature/warning

    Code Example:
    *************
    
    public class LinuxCommand(string command, string description)
    {
        public string Command { get; set; } = command;
        public string Description { get; set; } = description;
    }

    Link: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0290
    Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors
    */

    // Methods:
    // --------
    // Displays the command information in a readable format.
    // Demonstrates object behavior and method usage.
    // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
    public void ShowCommandInfo()
    {
        // String interpolation for readable output
        // Docs: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        // Passing the class properties: Command and Description
        Console.WriteLine($"{Command}: {Description}");
    }
} // class