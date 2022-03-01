using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Genetic_experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            string synthResult = "";
            StringBuilder formatedResult = new StringBuilder();
            char? current;
            int count;
            Regex regex = new Regex("([a-z]|[A-Z])+");

            try
            {
                Console.WriteLine("Please, enter the sythesis result: ");
                synthResult = Console.ReadLine();
                if (!regex.IsMatch(synthResult))
                {
                    Console.WriteLine("Synthesis result has wrong format.");
                    return;
                };

                current = synthResult[0];
                count = 1;
                for (int i = 1; i < synthResult.Length; i++)
                {
                    if (synthResult[i] == current)
                    {
                        count++;
                    }
                    else
                    {
                        formatedResult.Append(current + count.ToString());
                        current = synthResult[i];
                        count = 1;
                    }
                }
                formatedResult.Append(current + count.ToString());

                Console.WriteLine();
                Console.WriteLine("Formated result: " + formatedResult.ToString());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured: " + ex.Message);
            }
            finally
            {
                Console.Write("Press any key to stop: ");
                Console.ReadLine();
            }
        }
    }
}
