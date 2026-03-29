internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                throw new DivideByZeroException("kuku kuku kuku kuku");
            }

            int c = a / b;
            Console.WriteLine($"The result of {a} divided by {b} is: {c}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input was not a valid number. Please enter a valid integer.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Error details: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block will always execute, regardless of whether an exception was thrown or caught.");
            Console.WriteLine("Program has ended. Bye Bye!");
        }
    }
}