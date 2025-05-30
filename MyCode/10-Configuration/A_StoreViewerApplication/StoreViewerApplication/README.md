# StoreViewerApplication

This is a sample ASP.NET Core application demonstrating configuration and options binding.

## Requirements
- .NET 8.0 SDK

## How to Run

1. Restore dependencies:
   ```sh
   dotnet restore
   ```
2. Build the project:
   ```sh
   dotnet build
   ```
3. Run the application:
   ```sh
   dotnet run
   ```

The app will start and serve endpoints for store and configuration data.

## Endpoints
- `/stores` - Returns the list of stores from configuration.
- `/map-settings` - Returns map settings from configuration.
- `/display-settings` - Returns display settings from configuration.

## Configuration
Configuration is loaded from `appsettings.json` and `appsettings.Development.json`.

## Project Structure
- `Program.cs` - Main application logic and endpoint definitions.
- `appsettings.json` - Main configuration file.
- `wwwroot/` - Static files.

## Notes
- This project uses options pattern for configuration binding.
- Update your `appsettings.json` with your own settings as needed.
