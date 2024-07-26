using System;

public class OldPhonePadGenerator
{
    /// <summary>
    /// Processes input from an old phone keypad and converts it to a string.
    /// </summary>
    /// <param name="input">A string representing the keypresses.</param>
    /// <returns>A string representing the converted text.</returns>
    /// <exception cref="ArgumentException">Thrown when the input is null or empty.</exception>
    public static string OldPhonePad(string input)
    {
        // Check if input is null or empty
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input cannot be null or empty.");
        }

        // Initialize the output string to accumulate the result
        string output = String.Empty;
        // Initialize the current cycle string to accumulate the current cycle of key presses
        string currentCycle = String.Empty;

        // For loop to check each character of the input
        for (int i = 0; i < input.Length; i++)
        {   
            // Current Character
            char character = input[i];
            // Next Character if it exists
            char? nextCharacter = (i + 1 < input.Length) ? input[i + 1] : (char?)null;

            // If the character is '#' AND the current cycle is empty or null, process the last cycle and break the loop
            if (character == '#' && !string.IsNullOrEmpty(currentCycle))
            {
                output += ProcessCycle(currentCycle);
                break;
            }

            // If the character is '*', remove the last character from the output
            if (character == '*')
            {
                output = output.Substring(0, output.Length - 1);
            }

            // If the character is a space AND the current cycle is empty or null, process the current cycle 
            if (character == ' ' && !string.IsNullOrEmpty(currentCycle))
            {
                // Convert the current cycle to the output
                output += ProcessCycle(currentCycle);
                // Clear the current cycle for the rest of the sequence
                currentCycle = String.Empty;
            }

            // If the character is a digit, process the current cycle
            if (Char.IsDigit(character))
            {
                // Add the character to the current cycle
                currentCycle += character;
                // Check if next character does not equal the current character
                if (nextCharacter != character)
                {
                    // Convert the current cycle to the output
                    output += ProcessCycle(currentCycle);
                    // Clear the current cycle for the rest of the sequence
                    currentCycle = String.Empty;
                }
            }
        }
        // Output the final result
        return output;
    }

    /// <summary>
    /// Processes a cycle of key presses and returns the corresponding character.
    /// </summary>
    /// <param name="cycle">A string representing a cycle of key presses.</param>
    /// <returns>A char representing the converted character.</returns>
    /// <exception cref="ArgumentException">Thrown when the cycle is null or empty.</exception>
    private static char ProcessCycle(string cycle)
    {   
        // Check if cycle is null or empty
        if (string.IsNullOrEmpty(cycle))
        {
            throw new ArgumentException("Cycle cannot be null or empty.");
        }

        // The first character in the cycle determines which key was pressed
        char key = cycle[0];

        // String to grab the characters based off each case
        string characters = String.Empty;

        // Determine which characters are associated with the key
        switch (key)
        {
            case '0':
                characters = " ";
                break;
            case '1':
                characters = "&'(";
                break;
            case '2':
                characters = "ABC";
                break;
            case '3':
                characters = "DEF";
                break;
            case '4':
                characters = "GHI";
                break;
            case '5':
                characters = "JKL";
                break;
            case '6':
                characters = "MNO";
                break;
            case '7':
                characters = "PQRS";
                break;
            case '8':
                characters = "TUV";
                break;
            case '9':
                characters = "WXYZ";
                break;
            default:
                throw new ArgumentException("Invalid key pressed.");
        }

        // Calculate the index based on the amount of times a button is pressed
        int index = (cycle.Length - 1) % characters.Length;

        // Return the character at the calculated index
        return characters[index];
    }
}