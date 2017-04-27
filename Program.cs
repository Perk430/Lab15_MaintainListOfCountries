using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesApp
    {
        static void Main(string[] args)
        {
            bool run = true;//My Boolean variable to keep the program "running" as long as the user wants to "run" it.

            Console.WriteLine("Welcome to the Countries Maintenance Application!\n");//Welcoming the user.
            Console.WriteLine("Enter the number of the choice you would like to do?: \n");//Asking for and listing options for user

            do //Using a "Do-while" loop to ensure the program runs at least once.
            {
                Console.WriteLine("1 - See the list of countries \n");
                Console.WriteLine("2 - Add a country \n");
                Console.WriteLine("3 - Exit \n");

                int choice = int.Parse(Console.ReadLine());//Validating the user enters one of the numeric options above.

                if (choice == 1)// Read from file listing countries
                {
                    CountriesTextFiles.ReadFromFile();
                }

                else if (choice == 2)// Write to file to add a country or countries

                {
                    Console.WriteLine("What country would you like to add to the list? \n");
                    string input = Console.ReadLine();
                    CountriesTextFiles.WriteToFile(input);//Adding the country entered by the user to the list of countries in the text file.
                    Console.WriteLine("This country has been saved!\n");
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Buh-bye!");
                    return;
                }
            }
              while (run == true);
        }
    }
}
