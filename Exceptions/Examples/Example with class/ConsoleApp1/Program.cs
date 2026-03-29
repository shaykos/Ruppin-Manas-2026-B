using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");
            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}