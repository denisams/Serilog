## Brief Description

This repository contains a simple example of using Serilog, a diagnostic logging library for .NET applications. The application demonstrates how to configure Serilog to log messages to the console and a rolling file.

---

# Serilog Logging Example

This is a basic example of how to use Serilog for logging in a .NET application. Serilog is a diagnostic logging library that provides rich, structured event data. This example demonstrates how to set up Serilog to log messages to both the console and a rolling file.

## How It Works

The application initializes Serilog with a configuration that specifies:
- **Minimum Log Level**: Debug
- **Console Logging**: Logs are written to the console.
- **File Logging**: Logs are written to a file with daily rolling intervals.

### Features

1. **Logging Initialization**: Configures Serilog with console and file sinks.
2. **Logging a Message**: Logs an informational message.
3. **Exception Handling**: Logs an error message with an exception stack trace.
4. **Structured Logging**: Demonstrates structured logging by logging variables within the log message.

## How to Use

To run the application, you need to have .NET installed on your computer. Follow the steps below:

1. **Clone the Repository:**
   ```sh
   git clone https://github.com/your-username/serilog-example.git
   cd serilog-example
   ```

2. **Restore Dependencies:**
   Ensure you restore the NuGet packages required for Serilog.
   ```sh
   dotnet restore
   ```
   ﻿Install-Package Serilog.Sinks.Console
   Install-Package Serilog.Sinks.File 


3. **Build the Solution:**
   Build the project to resolve dependencies and compile the code.
   ```sh
   dotnet build
   ```

4. **Run the Application:**
   Execute the application to see Serilog in action.
   ```sh
   dotnet run
   ```

5. **View Logs:**
   - **Console Output**: Logs will be printed to the console.
   - **File Output**: Logs will be saved in the `logs` directory with daily rolling files.

 You need install
