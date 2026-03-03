# GUID Generator Application

A .NET console application that generates GUIDs based on user input, with a separate class library for the generation logic and comprehensive unit tests.

## Project Structure

```
├── src/
│   ├── GuidGenerator/              # Class library for GUID generation
│   │   └── Class1.cs               # GuidGeneratorService implementation
│   └── GuidGeneratorApp/           # Console application
│       └── Program.cs              # Main application entry point
├── tests/
│   └── GuidGenerator.Tests/        # Unit tests
│       └── UnitTest1.cs            # Tests for GuidGeneratorService
└── GuidGenerator.sln               # Solution file
```

## Components

### 1. GuidGenerator Library
- **GuidGeneratorService**: A service class that generates a specified number of GUIDs
- **GenerateGuids(int count)**: Method that returns a list of unique GUIDs
- Includes validation to ensure count is greater than zero

### 2. GuidGeneratorApp Console Application
- Interactive console application that prompts users for the number of GUIDs to generate
- Displays all generated GUIDs in a formatted list
- Includes error handling for invalid inputs
- Supports continuous operation until user exits

### 3. Unit Tests
- 11 comprehensive unit tests covering:
  - Valid GUID generation
  - Correct count validation
  - Uniqueness of generated GUIDs
  - Edge cases (zero, negative numbers)
  - Various input sizes (1, 5, 10, 100, 1000)

## Building the Solution

```bash
dotnet build
```

## Running the Console Application

```bash
dotnet run --project src/GuidGeneratorApp/GuidGeneratorApp.csproj
```

Or navigate to the project directory:
```bash
cd src/GuidGeneratorApp
dotnet run
```

## Running Tests

```bash
dotnet test
```

## Usage Example

```
GUID Generator Application
==========================

Enter the number of GUIDs to generate (or 'exit' to quit): 3

Generated 3 GUID(s):
--------------------------------------------------
1. 12345678-1234-1234-1234-123456789abc
2. 87654321-4321-4321-4321-cba987654321
3. abcdef01-2345-6789-abcd-ef0123456789

Enter the number of GUIDs to generate (or 'exit' to quit): exit
Goodbye!
```

## Technologies Used

- .NET 9.0
- xUnit for unit testing
- C# 12