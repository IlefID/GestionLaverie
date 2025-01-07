using GestionLaverie.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorLaverie
{
    public class Program
    {
        private static List<Proprietaire> proprietorsList = new List<Proprietaire>();
        public static async Task Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Available tasks:");
                Console.WriteLine("1. Retrieve all proprietors .");
                Console.WriteLine("2. Display all proprietors .");
                Console.WriteLine("3. Toggle machine state.");
                Console.WriteLine("0. Exit.");
                Console.Write("Choose number: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await FetchProprietorsWithDetails();
                        break;
                    case "2":
                        Console.WriteLine("Hi hi");
                        break;
                    case "3":
                        Console.WriteLine("hello hello");
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static async Task FetchProprietorsWithDetails()
        {
            try
            {
                using HttpClient client = new HttpClient();

                string apiUrl = "https://localhost:7268/api/Configuration/proprietaires";

                Console.WriteLine("Fetching data from the API...");
                List<Proprietaire> proprietors = await client.GetFromJsonAsync<List<Proprietaire>>(apiUrl);

                if (proprietors == null || proprietors.Count == 0)
                {
                    Console.WriteLine("No proprietors found.");
                }
                else
                {
                    proprietorsList = proprietors;
                    Console.WriteLine("Proprietors have been successfully retrieved.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during the API call: {ex.Message}");
            }
        }
    }
}
