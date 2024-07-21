using System;

class Program 
{
  static void Main(string[] args)
  {
    // Prompt the user to enter the two numbers required
    Console.WriteLine("Enter the first number: ");
    string input = Console.ReadLine();

    Console.WriteLine("Enter the second number: ");
    string input2= Console.ReadLine();

    try
    {
      // Convert into Int32
      int num1 = Convert.ToInt32(input);
      int num2 = Convert.ToInt32(input2);

      // Divide both int
      int result = Divide(num1, num2);
      Console.WriteLine($"{input} divided by {input2} is {result}.");
    }
    catch (FormatException ex) 
    {
      Console.WriteLine("One or more of the inputs are not a valid number!");
      Console.WriteLine($"Error: ${ex.Message}");
    }
    catch (DivideByZeroException ex) 
    {
      Console.WriteLine("Divding by Zero is not allowed!");
      Console.WriteLine($"Error: ${ex.Message}");
    }
    catch (OverflowException ex)
    {
      Console.WriteLine("One or more of the inputs exceeds the value range!");
      Console.WriteLine($"Error: ${ex.Message}");
    }
    catch (Exception ex)
    {
      Console.WriteLine("An unexpected error has occurred");
      Console.WriteLine($"Error: ${ex.Message}");
    } 
  }

  // Divide the appropriate values
  static int Divide(int a, int b) 
  {
    return a / b;
  }
}
