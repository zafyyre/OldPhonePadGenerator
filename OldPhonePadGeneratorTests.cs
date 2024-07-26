using System;

// Unit Tests
public class OldPhonePadGeneratorTests
{
    public static void RunTests()
    {
        TestOldPhonePad("33#", "E");
        TestOldPhonePad("227*#", "B");
        TestOldPhonePad("4433555 555666#", "HELLO");
        TestOldPhonePad("8 88777444666*664#", "TURING");
        TestOldPhonePad("777788733777222 255544433377724 444555444777784442223399744425554443666222444666887777#", "SUPERCALIFRAGILISTICEXPIALIDOCIOUS");
        TestOldPhonePad("444777666 660777766633389277733077788555337777#", "IRON SOFTWARE RULES");
        TestOldPhonePad("7555332777733044 444777330633#", "PLEASE HIRE ME");
    }

    private static void TestOldPhonePad(string input, string expected)
    {
        string result = OldPhonePadGenerator.OldPhonePad(input);
        if (result == expected)
        {
            Console.WriteLine($"\nTest Passed for input: {input}. Result: {result}");
        }
        else
        {
            Console.WriteLine($"\nTest Failed for input: {input}. Expected: {expected}, but got: {result}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        OldPhonePadGeneratorTests.RunTests();
    }
}
