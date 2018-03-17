using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"Choose one of the options:
1. Demostrate the result of the 1st task
2. Demostrate the result of the 2nd task
3. Exit");
                int choice = ChooseInput(3);

                switch (choice)
                {
                    case 1:
                        FirstTask();
                        break;
                    case 2:
                        SecondTask();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void FirstTask()
        {
            // State class.
            State state1 = new State(); // Without parameters;
            State state2 = new State("Australia", "Elizabeth II", 24067700, 117, "Australia"); // With parameters

            // Republic class.
            Republic republic1 = new Republic();
            Republic republic2 = new Republic("The Republic of the Congo", "Denis Sassou Nguesso", 5125821, 58, "Africa", 7, 72, 6);

            // Monarchy class.
            Monarchy monarchy1 = new Monarchy();
            Monarchy monarchy2 = new Monarchy("Belgium", "Philippe", 11358357, 189, "Europe", "The House of Saxe-Coburg and Gotha");

            // Kingdom class.
            Kingdom kingdom1 = new Kingdom();
            Kingdom kingdom2 = new Kingdom("the Kingdom of Saudi Arabia", "Salman", 33000000, 87, "Asia", "The Sudairi Seven");

            // Array of states.
            State[] stateArr = new State[8]; 
            stateArr[0] = state1;
            stateArr[1] = state2;
            stateArr[2] = republic1;
            stateArr[3] = republic2;
            stateArr[4] = monarchy1;
            stateArr[5] = monarchy2;
            stateArr[6] = kingdom1;
            stateArr[7] = kingdom2;

            // Showing the elements.
            Console.Clear();
            Console.WriteLine("THE RESULT OF THE 1ST TASK:");
            foreach (State s in stateArr) 
                s.Show();

            Console.WriteLine("Press ENTER to back to the main menu");
            Console.ReadLine();
        }

        public static void SecondTask()
        {

            Console.Clear();
            Console.WriteLine("THE RESULT OF THE 2ND TASK:");
            // Getting initial data
            State[] states = SecondTaskData();
            foreach (State s in states)
                s.Show();

            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine(@"Choose one of the options:
1. Get all the monarchs from the wanted continent
2. Get the continent population
3. Get the continent average president term length
4. Back to the main menu");

                choice = ChooseInput(4);
                switch (choice)
                {
                    case 1:
                        string continent = ContinentsInput();
                        string monarchList = GetContinentMonarchs(states, continent);
                        Console.WriteLine("All the monarchs from " + continent + " : " + monarchList);
                        break;
                    case 2:
                        continent = ContinentsInput();
                        long population = GetContinentPopulation(states, continent);
                        Console.WriteLine("Population of " + continent + " : " + population + " people");
                        break;
                    case 3:
                        continent = ContinentsInput();
                        double averTerm = GetAveragePresTerm(states, continent);
                        Console.WriteLine("Average president term length in " + continent + " : " + averTerm + " years");
                        break;
                    case 4:
                        break;
                }
            } while (choice != 4);
        }

        // Second task data
        public static State[] SecondTaskData()
        {
            // Republic class.
            Republic republicEmpty = new Republic();
            Republic republicCongo = new Republic("The Republic of the Congo", "Denis Sassou Nguesso", 5125821, 58, "Africa", 7, 72, 6);
            Republic republicCzech = new Republic("The Czech Republic", "Miloš Zeman", 10610947, 25, "Europe", 10, 200, 4);
            Republic republicTurkey = new Republic("The Republic of Turkey", "Recep Tayyip Erdoğan", 80810525, 95, "Asia", 5, 550, 4);
            Republic republicArgentina = new Republic("The Argentine Republic", "Mauricio Macri", 43847430, 102, "America", 4, 329, 2);
            Republic republicNauru = new Republic("The Republic of Nauru", "Baron Waqa", 10084, 50, "Oceania", 3, 19, 3);

            // Monarchy class.
            Monarchy monarchyEmpty = new Monarchy();
            Monarchy monarchyBelgium = new Monarchy("Belgium", "Philippe", 11358357, 189, "Europe", "The House of Saxe-Coburg and Gotha");
            Monarchy monarchyAustralia = new Monarchy("Australia", "Elizabeth II", 24067700, 117, "Oceania", "House of Windsor");
            Monarchy monarchyJamaica = new Monarchy("Jamaica", "Elizabeth II", 43847430, 56, "America", "House of Windsor");

            // Kingdom class.
            Kingdom kingdomEmpty = new Kingdom();
            Kingdom kingdomSaudiArabia = new Kingdom("The Kingdom of Saudi Arabia", "Salman", 33000000, 87, "Asia", "The Sudairi Seven");
            Kingdom kingdomMarocco = new Kingdom("The Kingdom of Morocco", "Mohammed VI", 33848242, 62, "Africa", "The Alaouite dynasty");

            // State array.
            State[] states = new State[13];

            states[0] = republicEmpty;    states[6] = monarchyEmpty;     states[10] = kingdomEmpty;
            states[1] = republicCongo;    states[7] = monarchyBelgium;   states[11] = kingdomSaudiArabia;
            states[2] = republicCzech;    states[8] = monarchyAustralia; states[12] = kingdomMarocco;
            states[3] = republicTurkey;   states[9] = monarchyJamaica;
            states[4] = republicArgentina;
            states[5] = republicNauru;

            return states;
        }

        // Get all the monarchs from the wanted continent (1 FOR THE 2ND TASK)
        public static string GetContinentMonarchs(State[] states, string continent)
        {
            // The list of the continent's monarchs
            string monarchsList = "";

            foreach (State s in states)
                // If it's not empty, either monarchy or kingdom, from the wanted continent
                if(s != null && (s is Monarchy || s is Kingdom) && s.Continent == continent)
                {
                    // If the name is not in the list yet
                    if (!monarchsList.Contains(s.LeaderName))
                        monarchsList += s.LeaderName + " ";
                }

            return monarchsList;
        }

        // Get the continent population (2 FOR THE 2ND TASK)
        public static long GetContinentPopulation(State[] states, string continent)
        {
            // Buffer that stores all the poplulations
            long pop = 0;

            foreach (State s in states)
                // If it's not empty and from the wanted continent
                if (s != null && s.Continent == continent)
                    pop += s.Population;

            return pop;
        }

        // Get the continent average president term length (3 FOR THE 2ND TASK)
        public static double GetAveragePresTerm(State[] states, string continent)
        {
            // Buffer that stores the average term length
            double aver = 0;
            // Stores that number of states from wanted continent
            int count = 0;

            foreach (State s in states)
                // If it's not empty, republic and from the wanted continent
                if(s!=null && s is Republic && s.Continent == continent)
                {
                    Republic buf = s as Republic;
                    aver += buf.PresidentTerm;
                    count++;
                }

            aver /= (double)count;
            return aver;
        }


        

        // Continents input
        public static string ContinentsInput()
        {
            string[] continents = { "Asia", "Africa", "America", "Oceania" };

            Console.WriteLine();
            Console.WriteLine(@"Choose one of the continents:
1. Asia
2. Africa
3. America
4. Oceania");

            int choice = ChooseInput(4);

            Console.WriteLine();

            return continents[choice - 1];
        }

        // Choice input
        public static int ChooseInput(int size)
        {
            bool ok;
            int choice;
            do
            {
                Console.Write("Enter the number of the chosen option: ");
                ok = Int32.TryParse(Console.ReadLine(), out choice);
                if (!ok || choice < 1 || choice > size)
                    Console.WriteLine("Input error! Perhaps you didn't enter a number from 1 to {0}", size);
            } while (!ok || choice < 1 || choice > size);

            return choice;
        }
    }
}
