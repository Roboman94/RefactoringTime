using Deets;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab9Refactoring
{

    class Program
    {
       
        static void Main(string[] args)
        {

            List<deets> peeps = deets.GetListOfMovies();
          
            Console.WriteLine("Welcome to people search engine!");
            int cont = 1;
          
            while (cont == 1)
            {
                deets.ListPeeps(peeps);
                Console.WriteLine("Would you like to add a student or search for a hobby?");
                Console.WriteLine("(add) or (hobby)");
                string entry = Console.ReadLine();


                if (entry.Contains("hobby"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Contained hobbies are: ");
                    foreach (deets namez in peeps)
                    {

                        Console.Write($"{namez.Hobb} ");

                    }
                    Console.WriteLine();
                    deets.SearchHobby(peeps);

                }

                else if (entry.Contains("add"))
                {
                   deets.PartyAdd(peeps);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again ");
                }

            }
        }
    }
}
