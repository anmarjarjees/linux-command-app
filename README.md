# Linux Command Application:
Simple .NET Console Application With C# and JSON file: Learning about most commonly used "Linux" commands. Notice that we only picked 4 commands for a quick demo.
Please refer to my PDFs for all the other Linux commands and tools.

Link: https://developers.redhat.com/cheat-sheets/linux-commands-cheat-sheet

# Overview
Linux Command Helper Application is a simple educational C# console application that demonstrates Object-Oriented Programming (OOP) principles and JSON data integration in a clean, friendly way.

The project defines a blueprint class called "LinuxCommand" to represent Linux commands and their descriptions. It then loads command data from an external JSON file "linux-commands.json" file and displays it dynamically using object instances.

This project was designed as part of a programming and Linux lecture to help students strengthen their understanding of:

- Classes and Objects
- Encapsulation and Constructors
- Collections (List<T>)
- Reading JSON files using **"System.Text.Json"**
- Exception handling and clean coding practices

# Learning Outcomes
- Understand how C# classes encapsulate data and behavior
- Learn how to read and deserialize JSON files into C# objects
- Working with collections **"List"**
- Practice using foreach loops to iterate over object collections
- Get comfortable with namespaces and project structure in .NET

# Codespace Current Installed Language Versions:
- You can verify the current installed version of the required packages of each language:
```
    - node --version
    - java --version
    - python --version
    - dotnet --version
```

# Files Order and Sequence:
1. The JSON file `linux-commands.json`: Stores Linux command names and their descriptions 
    - It serves as the data source
2. The blueprint class `LinuxCommand.cs`:  Defines the `LinuxCommand` blueprint class
    - It defines the object structure that the JSON data will be deserialized into
3. the Main class (Program.cs): Contains the `Main()` method and program logic
    - Reading JSON, deserializing into objects, iterating with a loop, and calling the class methods

**Tip: You can use the command CTRL+SHIFT+V for README.md Preview :-)**

# App Example Output:
ls: List directory contents  
cd: Change directory  
mkdir: Create a new directory  

# Codespace Setup For C# Application:
1. Step01: Microsoft C# VS Code Extensions
- Install the C# Microsoft VS Code Extensions
- Verify the current installed version of .NET (Optional Step)

2. Step02: New Consol App Project
- CTRL in Windows (Command in Mac) + SHIFT + P => Select/type: ".NET New Project"
- From the Dropdown list, Select "Console App Common, Console" or simple "Console App"
- Type the project name which also be the folder name, example "ConsoleApp1"
- Notice by convention we use PascalCase with no spaces for the project names
- By default the project will be created inside a separate folder (sub-folder) inside your current GitHub repository

3. Step03: JSON FILE
- Create a folder "Data" and add the JSON file
- Verify the "Program.cs" file => using the full C# template with correct labels

NOTES: 
- It's optional to create the folder "Data", you can just create the JSON file immediately inside the project folder. 
- We use PascalCase in .NET Application by convention. 

4. Stp04: The "Blueprint" class 
- Click "Solution Explorer" in Visual Studio or "Explorer" window in VS Code 
- Click the project name then the "New File" icon
    - Notice that the Solution name contains the project name (both have the same name)
- Select "Class" from the menu then identify it name 

# Credits, References, and Resources:
- [My Repository "C# Essentials"](https://github.com/anmarjarjees/csharp-essentials)
- [C# for Beginners – Microsoft Learn](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-1/)
- [C# Documentation – Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [C# Classes and Objects](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)
- [JSON serialization](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview)
- [File.ReadAllText Method](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-9.0)