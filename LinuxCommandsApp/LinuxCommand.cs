using System;
// using keyword in C# => import keyword in Java

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

    // Methods
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