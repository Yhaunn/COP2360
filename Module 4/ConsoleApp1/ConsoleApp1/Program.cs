using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number (Dividend).");
            string inp1 = Console.ReadLine();

            Console.WriteLine("Input second number (Divisor).");
            string inp2 = Console.ReadLine();

            try
            {
                int dividend = Convert.ToInt32(inp1);
                int divisor = Convert.ToInt32(inp2);

                int quotient = Divide(dividend, divisor);
                int remainder = CalculateRemainder(dividend, divisor);

                Console.WriteLine($"{dividend} divided by {divisor} is {quotient}, with a remainder of {remainder}");
            }
            catch (OverflowException ex)
            {
                // Console.WriteLine("Erorr: Number entered is too large to be converted into a 32-bit integer. ");
                OutputExceptionInfo(ex);
            }
            catch (FormatException ex)
            {
                // Console.WriteLine("Error: Number entered is of an invalid format.");
                OutputExceptionInfo(ex);
            }
            catch (DivideByZeroException ex)
            {
               //  Console.WriteLine("Error: Cannot divide by zero.");
                OutputExceptionInfo(ex);
            }
            catch (Exception ex)
            {
                // Console.WriteLine("An unexpected error has occured.");
                OutputExceptionInfo(ex);
            }
            finally
            {
                Console.WriteLine("Press any key to exit program...");
                Console.ReadKey();

                Environment.Exit(0);
            }
        }

        static int Divide(int a, int b) => a / b;
        static int CalculateRemainder(int a, int b) => a % b;

        static void OutputExceptionInfo(Exception ex)
        {
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            Console.WriteLine($"Data: {ex.Data}");
        }
    }
}
    