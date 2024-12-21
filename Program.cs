using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app__Handling_incorrect_number_format_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try { 
                    Console.Write("Enter a number: "); 
                    double number = Convert.ToDouble(Console.ReadLine()); 
                    Console.WriteLine($"You entered: {number}"); 
                } 
                catch (FormatException) { 
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Error: Please enter a valid number."); 
                    Console.ResetColor(); 
                } 
                finally { 
                    Console.WriteLine("Attempt to process the input completed."); 
                } 
                // Запит на повторне введення
                Console.WriteLine("Do you want to try again? (yes/no):"); 
                string response = Console.ReadLine().ToLower(); 
                if (response != "yes" && response != "y") 
                { 
                    break; 
                } 
            }
        }
    }
}
