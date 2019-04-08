using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var Countries = new Dictionary<string, string>()
            {
                { "Bulgaria", "Sofia" },
                { "Macedonia", "Skopje" },
                { "Serbia", "Belgrade" },
                { "Greece", "Athens" },
                { "Kosovo", "Pristina" },
            };

            while (true)
            {
                Console.WriteLine("Select [1] for adding new country and city. \nSelect [2] for checking any existing country and city.");
                int select;
                bool boolSelect = int.TryParse(Console.ReadLine(), out select);

                if (select == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the new country: ");
                        var countryNew = Console.ReadLine();

                        Console.WriteLine("Enter the city of the new country: ");
                        var cityNew = Console.ReadLine();

                        Countries.Add(countryNew, cityNew);

                        while (true)
                        {
                            Console.WriteLine("Do you want to add another country and city? [Yes] or [No]");
                            var respond = Console.ReadLine();

                            if ((respond == "Yes") || (respond == "yes"))
                            {
                                break;
                            }

                            else if ((respond == "No") || (respond == "no"))
                            {
                                Console.WriteLine("Ok. Here is your list of countries: \n");

                                foreach (var item in Countries)
                                {
                                    Console.WriteLine(item);
                                }

                                Console.ReadLine();
                                return;
                            }

                            else
                            {
                                Console.WriteLine("Invalid inputs.\nPress Enter to continue...");
                                Console.ReadLine();
                                continue;
                            }
                        }
                    }
                }
                else if (select == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter a country:");
                        var country = Console.ReadLine();

                        if (Countries.ContainsKey(country))
                        {
                            Console.WriteLine($"The capital of {country} is {Countries[country]}");
                        }
                        else
                        {
                            Console.WriteLine($"The country of {country} is not in the database");
                        }

                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("Please select [1] or [2].\n");
                    continue;
                }
            }
        }
    }
}
