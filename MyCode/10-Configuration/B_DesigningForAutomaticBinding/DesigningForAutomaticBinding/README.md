# DesigningForAutomaticBinding

This project demonstrates advanced configuration binding scenarios in ASP.NET Core, including automatic binding to complex types, collections, dictionaries, and more.

## Features
- Binds configuration to various property types: strings, integers, objects, read-only properties, dictionaries, lists, and more.
- Shows how to handle non-string dictionary keys and read-only collections.
- Demonstrates nullable and non-nullable property handling.

## Project Structure
- `Program.cs`: Main application logic and configuration binding examples.
- `appsettings.json`: Main configuration file with a variety of property types for binding.
- `DesigningForAutomaticBinding.csproj`: Project file targeting .NET 8.0.

## Getting Started
1. **Restore dependencies:**
   ```sh
   dotnet restore
   ```
2. **Build the project:**
   ```sh
   dotnet build
   ```
3. **Run the application:**
   ```sh
   dotnet run
   ```

## Requirements
- .NET 8.0 SDK or later

## Notes
- The project includes nullable reference type warnings by design, to illustrate binding edge cases.
- Modify `appsettings.json` to experiment with different configuration structures.

---

For more information, see the source code and comments in `Program.cs`.
