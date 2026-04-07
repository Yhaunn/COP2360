using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contractor
{
     // Contractor Class Members with default Accessor and Mutator functions
    public string Name { get; set; }
    public int Number { get; set; }
    public string StartingDate { get; set; }

    // Constructor
    public Contractor(string name, int number, string startingDate) {
        Name = Name;
        Number = number;
        StartingDate = startingDate;  
    }
}
public class SubContractor : Contractor
{
    public int Shift { get; set; } // 1 == Day, 2 == Night
    public double PayRate { get; set; } // Hourly
    public SubContractor(string name, int number, string startingDate, int shift, double payRate):  base(name, number, startingDate) 
    {
        Shift = shift;
        PayRate = payRate; 
    }

    public float ComputePay(int hours)
    {
        // Need to type cast because hours is an integer and PayRate is a double
        return (float) PayRate * hours * (Shift == 2 ? 1.03f : 1f) ;
    }
}
namespace Module_10_Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            // Find the best container for sub contractor objects
            List<SubContractor> SubContractors = new List<SubContractor>();

            while (running)
            {
                Console.WriteLine("Creating Sub-Contractor");
                Console.WriteLine("Enter Sub-Contractor Details");

                Console.WriteLine("Name: ");
                string Name = Console.ReadLine();

                Console.WriteLine("Number: ");

                // Probably add some kind of error handling to this
                int Number = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Starting Date: ");
                string StartingDate = Console.ReadLine();
                
                Console.WriteLine("Working Shift: 1 = day / 2 = night");
                int Shift = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pay Rate (Hourly): ");
                double PayRate = System.Convert.ToDouble(Console.ReadLine());

                // Add the new Contractor with the given information
                SubContractors.Add(new SubContractor(Name, Number, StartingDate, Shift, PayRate));

                Console.WriteLine("Add Subtractor? (y/n): ");
                running = Console.ReadLine() == "y";

            }

            Console.ReadLine();
        }
    }
}
