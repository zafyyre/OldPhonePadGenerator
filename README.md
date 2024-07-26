
# OldPhonePadGenerator

## Introduction

The `OldPhonePadGenerator` is a C# Program designed to convert input from an old phone keypad to a string. This can be useful for applications that need to process text input similar to how old mobile phones used to handle SMS text entry. The program interprets keypresses and translates them into corresponding characters based on the traditional phone keypad layout.

## Table of Contents

- [Introduction](#introduction)
- [Installation](#installation)
- [Usage](#usage)
- [Documentation](#documentation)
- [Examples](#examples)
- [Contributor](#contributor)

## Installation

To use the `OldPhonePadGenerator` in your project, follow these steps:

1. **Clone the Repository**:
    ```sh
    git clone https://github.com/zafyyre/OldPhonePadGenerator.git
    ```

2. **Navigate to the Project Directory**:
    ```sh
    cd OldPhonePadGenerator
    ```

3. **Open the Project in Your IDE**:
    Open the project in your preferred C# development environment, such as Visual Studio or Visual Studio Code.

4. **Build the Project**:
    Build the project to ensure all dependencies are resolved and the code compiles successfully.

5. **Run the Program**:
    You can run the main program file `Program.cs` to see the `OldPhonePadGenerator` in action or execute the tests in `OldPhonePadGeneratorTests.cs`.

## Usage

### Converting Keypad Input to Text

You can use the `OldPhonePad` method to convert a string of keypresses into the corresponding text. Here's an example of how to use it:

\`\`\`csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "444777666 660777766633389277733077788555337777#";
        string output = OldPhonePadGenerator.OldPhonePad(input);
        Console.WriteLine(output); // Output: IRON SOFTWARE RULES
    }
}
\`\`\`

### Running Unit Tests

Unit tests are included to verify the functionality of the `OldPhonePad` method. You can run the tests using the `OldPhonePadGeneratorTests` class in the `OldPhonePadGeneratorTests.cs`:

\`\`\`csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        OldPhonePadGeneratorTests.RunTests();
    }
}
\`\`\`

## Documentation

### Methods

#### `OldPhonePad(string input)`

- **Description**: Converts a sequence of keypresses into the corresponding text.
- **Parameters**: 
  - `input` (string): A string representing the keypresses.
- **Returns**: A string representing the converted text.
- **Exceptions**: 
  - `ArgumentException`: Thrown when the input is null or empty.

#### `ProcessCycle(string cycle)`

- **Description**: Processes a cycle of key presses and returns the corresponding character.
- **Parameters**: 
  - `cycle` (string): A string representing a cycle of key presses.
- **Returns**: A char representing the converted character.
- **Exceptions**: 
  - `ArgumentException`: Thrown when the cycle is null or empty.

## Examples

### Example 1: Simple Conversion

\`\`\`csharp
string input = "33#";
string output = OldPhonePadGenerator.OldPhonePad(input);
Console.WriteLine(output); // Output: E
\`\`\`

### Example 2: Handling Deletions

\`\`\`csharp
string input = "227*#";
string output = OldPhonePadGenerator.OldPhonePad(input);
Console.WriteLine(output); // Output: B
\`\`\`

### Example 3: Complex Conversion

\`\`\`csharp
string input = "4433555 555666#";
string output = OldPhonePadGenerator.OldPhonePad(input);
Console.WriteLine(output); // Output: HELLO
\`\`\`

## Contributor

- [Zaafir Ali](https://github.com/zafyyre) - Initial development and tests.
