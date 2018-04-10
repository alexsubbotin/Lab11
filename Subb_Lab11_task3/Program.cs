using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Subb_Lab11_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Republic class.
            Republic republic = new Republic("The Republic of the Congo", "Denis Sassou Nguesso", 5125821, 58, "Africa", 7, 72, 6);

            // Monarchy class.
            Monarchy monarchy = new Monarchy("Belgium", "Philippe", 11358357, 189, "Europe", "The House of Saxe-Coburg and Gotha");

            // Kingdom class.
            Kingdom kingdom = new Kingdom("The Kingdom of Saudi Arabia", "Salman", 33000000, 87, "Asia", "The Sudairi Seven");

            // Array of objects of classes that use IComparable interface
            IComparable[] comparable = new IComparable[3];
            comparable[0] = republic;
            comparable[1] = monarchy;
            comparable[2] = kingdom;

            // Recreation of the array but with the AbstrState class
            AbstrState[] abstrState = new AbstrState[3];
            for (int i = 0; i < comparable.Length; i++)
                abstrState[i] = (AbstrState)comparable[i];

            Console.WriteLine("THE RESULT OF THE 3RD TASK:");
            // Showing the array
            Console.WriteLine("CREATED ARRAY:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            // Sorting the array
            Array.Sort(abstrState, new ComparePopulation());

            // Showing the sorted array
            Console.WriteLine("ARRAY AFTER BEING SORTED BY POPULATION:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            Array.Sort(abstrState, new CompareName());
            Console.WriteLine("ARRAY AFTER BEING SORTED BY NAME:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            Array.Sort(abstrState, new CompareLeaderName());
            Console.WriteLine("ARRAY AFTER BEING SORTED BY LEADER NAME:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            Array.Sort(abstrState, new CompareAge());
            Console.WriteLine("ARRAY AFTER BEING SORTED BY AGE:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            Array.Sort(abstrState, new CompareContinent());
            Console.WriteLine("ARRAY AFTER BEING SORTED BY CONTINENT:");
            foreach (AbstrState a in abstrState)
            {
                a.Show();
            }

            // Binary search demonstration
            DemostrateBinarySearch(abstrState);


            // Shallow clone
            Republic shallowClone = republic.ShallowCopy();
            // Real clone
            Republic clone = (Republic)republic.Clone();

            Console.WriteLine("Shallow clone of the Republic object:");
            shallowClone.Show();
            Console.WriteLine("Clone of the Republic object:");
            clone.Show();

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }

        // Binary search demonstration
        public static void DemostrateBinarySearch(AbstrState[] abstrState)
        {
            bool ok;
            int pop;
            do {
                // Input of the wanted population
                Console.Write("Enter the population: ");

                ok = Int32.TryParse(Console.ReadLine(), out pop);
                if (!ok || pop < 1)
                    Console.WriteLine("Input error! Perhaps you didn't enter a natural number");
            } while (!ok || pop < 1);
            
            // Creating a buffer element to compare with (monarchy is just the easiest, that's why I choose it)
            Monarchy buffer = new Monarchy("", "", pop, 0, "", "");

            // Binary search by population
            int index = Array.BinarySearch(abstrState, buffer, new ComparePopulation());
            if (index == -1)
                Console.WriteLine("State with the entered population doesn't exist in the array\n");
            else
            {
                Console.WriteLine("Found state's index: " + index + "\n");
                abstrState[index].Show();
            }
        }
    }
}
