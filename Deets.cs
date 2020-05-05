using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Deets
{
    class deets
    {

        private string name;
        private string hobb;
        private string year;

        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public string Hobb
        {
            get
            {
                return hobb;
            }
            set 
            {
                hobb = value;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public deets()
        {
            name = "default";
            hobb = "default";
            year = "default";

        }
        public deets(string _name, string _hobb, string _year)
        {
      
            name = _name;
            hobb = _hobb;
            year = _year;

        }

    
        public static string GetUserInfo(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public static List<deets> GetListOfMovies()
        {
            List<deets> peeps = new List<deets> {
            new deets("Bill", "Juggling", "1994"),
            new deets("Eric", "Photography", "1995"),
            new deets("Ted", "Movies", "1993"),
          
            };
            return peeps;
        }
        public void PrintPeepInfo(string input, int i)
        {
            if (input.Contains(hobb))
            {
                Console.WriteLine($"{name}'s hobby is {hobb} ");
                Console.WriteLine($"{name} was born in {year} ");
                i = 2;

            }


        }
        public static void SearchHobby(List<deets> peeps)
        {
            int valid = 0;
            while (valid == 0)
            {
                string hobby = deets.GetUserInfo("Which hobby would you like to inquire about? ");

                Console.WriteLine();
                Console.WriteLine();

                foreach (deets hobbies in peeps)
                {

                    if (hobbies.Hobb == (hobby))
                    {
                        Console.WriteLine($"{hobbies.Name}'s favorite hobby is {hobbies.Hobb}!" +
                            $"they were born on {hobbies.Year}. You should go ask them if you can join!");
                        Console.WriteLine();
                        valid = valid + 1;

                    }


                }
                if (valid == 0)
                {
                    Console.WriteLine("Invalid entry! Please try again.");
                }
            }
        }

        public static List<deets> PartyAdd(List<deets> peeps)
        {
            Console.WriteLine("Enter new name here");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new hobby here");
            string hobb = Console.ReadLine();
            Console.WriteLine("Enter new birthyear here");
            string year = Console.ReadLine();
            peeps.Add(new deets { Name = name, Hobb = hobb, Year = year});
            return peeps;
        }

        public static void ListPeeps(List<deets> peeps)
        {
           
            Console.WriteLine();
           
            foreach (deets namez in peeps)
            {
               
                string chart = String.Format("{0,-11}{1,-13}{2,-12}\n",
                            namez.Name, namez.Hobb, namez.year);
                
                    Console.WriteLine(chart);

            }
            Console.WriteLine();
        }

        public bool ValidCheck(int i, bool validcheck)
        {
            if (i == 1)
            {
                validcheck = false;
            }
            else
            {
                validcheck = true;
            }
            return false;
        }
    }



}

