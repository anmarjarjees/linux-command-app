// See https://aka.ms/new-console-template for more information
/* 
NOTE: By Default, using top-level statements.
Starting with .NET 6,
the project template for new C# console apps generates the following code in the Program.cs file:
See https://aka.ms/new-console-template for more information
But we will use the full template
 */

// Greyed out => useless => for older versions!
using System;
using System.Text.Json;
// Using directive is unnecessary.

// namespace "MyApp" => from the C# docs
// changed to our current application name: LinuxCommandsApp
namespace LinuxCommandsApp
{
    // using "internal" or "public" has no difference in this project:
    /* 
        Program class: contains the "Main" entry point:
        - Static method (Main)
        - Collections (List<T>)
        - JSON File reading
        - Exception handling => try/catch
        - OOP example (calling LinuxCommand methods)
        */
    internal class Program
    {
        /* 
        Main method: application entry point.
        - public => Publicly accessed = Global Access
        - static => belongs the class itself => no instance is needed of Program is required to run it
        - void => nothing to return
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args
         */
        /* 
        By default it's "public"
        By convention in C# public method => PascalCase
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* 
            Encapsulate our code with try/catch blocks
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements
            */
            try
            {
                // write our main code...
                // Just for testing: hardcode the arguments:
                // LinuxCommand command1 = new LinuxCommand("ls", "list files");
                // Can be simplified to:
                LinuxCommand command1 = new("ls", "list files");
                command1.ShowCommandInfo();
                // Remember: the two lines above are just for testing our Class "LinuxCommand"

                // Read all the commands from our JSON file => Array of x numbers of commands (objects)!

                // Step01: Read JSON file:
                // -----------------------
                // File.ReadAllText reads the entire contents of a text file into a string
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-8.0

                // Below is the basic use (generates error in running the application) code line:
                // string jsonString = File.ReadAllText("commands.json");
                /* 
                IMPORTANT NOTE (Why This Error?):
                *********************************
                When we run our application in GitHub Codespaces, 
                the executable (.dll) runs inside this folder: /workspaces/linux-project01/LinuxCommandApp/bin/Debug/net8.0/
                
                But our JSON file "commands.json" is located in our project root folder, 
                not in the bin/Debug/net8.0 folder where the compiled app looks for it.
                 */

                // Recommended Solution:
                // Using "AppContext.BaseDirectory" to get the absolute path of the executable directory
                // Combine it safely with the JSON file name (this works across OS and environments)
                /*
                AppContext.BaseDirectory:
                Always points to the folder where your compiled .dll runs 
                (so it works in Codespaces, VS Code, or Visual Studio) :-)

                Link: https://learn.microsoft.com/en-us/dotnet/api/system.appcontext.basedirectory?view=net-9.0
                Link: https://learn.microsoft.com/en-us/dotnet/api/system.io.path.combine?view=net-9.0
                Link: https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-9.0
                */
                // string jsonString = File.ReadAllText("linux-commands.json");
                string filePath = Path.Combine(AppContext.BaseDirectory, "linux-commands.json");
                /* 
                Optional: 
                If we move our json file "commands.json" file into a folder "Data" inside our project, 
                we need to update two things:
                First: check the main "csproj" file:adding Update="Data\commands.json"
                Second: Using Path.Combine(AppContext.BaseDirectory, "Data", "commands.json")

                string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "commands.json");
                */

                // Optional (Strongly Recommended) Step: Check if the file exists before trying to read it:       
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File not found at {filePath}");
                    // Error: File not found at /workspaces/linux-command-app/LinuxCommandsApp/bin/Debug/net8.0/linux-comm.json
                    // if the file is not found => stop/terminate our Main() method => the Entry point of our application
                    return; // Terminate the application
                }

                string jsonString = File.ReadAllText(filePath);

                // for testing:
                Console.WriteLine(jsonString); // give us the full content as text file

                //  Step04: Deserialize JSON into objects:
                // ---------------------------------------
                // JsonSerializer.Deserialize converts JSON string to C# objects
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-9.0
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.deserialize?view=net-8.0
                // LinuxCommand => is our Class:
                List<LinuxCommand> allCommands = JsonSerializer.Deserialize<List<LinuxCommand>>(jsonString);

                /* 
                NOTE: We need to use (import in Java) the Json library
                Error: The name 'JsonSerializer' does not exist in the current context
                With "Quick Fix" => using System.Text.Json;
                */

                // Optional (recommended) Step: Check if the commands string is null or empty:
                // ---------------------------------------------
                if (allCommands == null || allCommands.Count == 0)
                {
                    Console.WriteLine("No commands found in the JSON file.");
                }
                else
                {
                    // Step05: Iterate and display commands:
                    // -------------------------------------
                    // Using collections, foreach loop, and object method usage
                    // Display all commands
                    foreach (LinuxCommand cmd in allCommands)
                    {
                        cmd.ShowCommandInfo(); // Call our public method "ShowInfo()" from "LinuxCommand" class
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found
                Console.WriteLine($"Error: {ex.Message}");
                // In JAVA :-) ex.getMessage();
                /* 
                Error: Could not find file '/workspaces/linux-command-app/LinuxCommandsApp/bin/Debug/net8.0/linux-commands.json'.
                 */
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception?view=net-9.0
            }
            catch (JsonException ex)
            {
                // Handle invalid JSON format
                Console.WriteLine($"Error in parsing the JSON File: {ex.Message}");
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonexception?view=net-9.0
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        } // Main()
    } // class
} // namespace
