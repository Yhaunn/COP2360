using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Literal Dictionary

//Create a Switch Statement: Implement a switch statement that allows the user to perform the following tasks:

//a.Populate the Dictionary: Add keys and values determined by your group.

//b. Display Dictionary Contents: Show the contents of the dictionary using any of the three enumeration methods covered in Module 7.

//c. Remove a Key: Remove a specified key from the dictionary.

//d. Add a New Key and Value: Insert a new key- value pair into the dictionary.

//e. Add a Value to an Existing Key: Append a new value to an existing key.

//f. Sort the Keys: Sort the keys in the dictionary.

namespace Module_7_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            
            bool running = true;
           
            while (running)
            {
                Console.WriteLine("1. Populate Dictionary"); 
                Console.WriteLine("2. Display Contents");
                Console.WriteLine("3. Remove Key");
                Console.WriteLine("4. Add new Key-Value Pair");
                Console.WriteLine("5. Add Value to Key");
                Console.WriteLine("6. Sort Dictionary and Display");
                Console.WriteLine("7. Exit\n");

                string option = Console.ReadLine();
                switch (option)
                {
                    // Populate the Dictionary with Pre-determined entries
                    case "1":
                        dictionary["Arm"] =
                            new List<string>
                            {
                                "Noun; A limb of the human body.",
                                "Noun; A weapon or device used for a specific purpose."
                            };
                        dictionary["Beat"] =
                            new List<string>
                            {
                                "Verb; To strike repeatedly",
                                "Verb; To defeat or surpass someone or something",
                                "Adjective; Completely exhausted."
                            };
                        dictionary["Ball"] =
                           new List<string>
                           {
                                "Noun; A round object used in sports.",
                                "Noun; A formal social event."
                           };
                        Console.WriteLine("\nPopulated Dictionary with Default Values");
                        break;
                    // Display the Dictionary's Contents using KeyValuePair
                    case "2":
                        Console.WriteLine("\nViewing Dictionary Entries: \n");

                        // using KeyValuePair to iterate
                        foreach (KeyValuePair<string, List<string>> entry in dictionary)
                        {
                            Console.WriteLine($"{entry.Key}:\n\t{string.Join("\n\t", entry.Value)}");
                        }
                        Console.WriteLine("\n");
                        break;
                    // Remove Key
                    case "3":

                        Console.WriteLine("\nEnter Word to Remove from Dictionary:");

                        // Dictionary.Remove returns true if it succeeds
                        if (dictionary.Remove(Console.ReadLine()))
                            Console.WriteLine("\nWord removed successfully.");
                        else
                            Console.WriteLine("\nWord not found in Dictionary. \n");

                        break;
                    // Add Completely New Key and Value
                    case "4":
                        Console.WriteLine("\nEnter New Word: ");
                        string newKey = Console.ReadLine();

                        // Default dictionary methods, ContainsKey and Add make this really easy to do

                        if (dictionary.ContainsKey(newKey)) {
                            Console.WriteLine($"\nWord {newKey} already Exists in Dictionary: ");
                            break;
                        }
                        Console.WriteLine("Enter Value: ");

                        dictionary.Add(newKey, new List<string> { Console.ReadLine() });

                        Console.WriteLine($"New Word: {newKey} and definition Sucessfully Added ");

                        break;
                    // Add new Value to Key (Definition to Word)
                    case "5":
                        Console.WriteLine("Enter Existing Key: ");
                        string key = Console.ReadLine();

                        if (dictionary.ContainsKey(key))
                        {   
                            // newline because the definition could be pretty long, making it easier to read
                            Console.WriteLine("Add new Definition:\n");

                            dictionary[key].Add(Console.ReadLine());

                            Console.WriteLine($"Added new Definition to Word: {key}");
                        }
                        else
                        {
                            Console.WriteLine($"Word: {key}, not found in Dictionary");
                        }
                        break;
                    // Sort the Keys alphabetically, Unordered Dictionaries can't be ordered so we'll make a temporary sorted structure and display it
                    case "6":
                        Console.WriteLine("\n");

                        // OrderBy returns KeyValuePair
                        foreach (var entry in dictionary.OrderBy(k => k.Key))
                        {
                            Console.WriteLine($"{entry.Key}:\n\t{string.Join("\n\t", entry.Value)}");
                        }
                        Console.WriteLine("\nDictionary Sorted\n");
                        break;
                    case "7":
                        running = false;
                        break;
                }
            }
        }
    }
}
