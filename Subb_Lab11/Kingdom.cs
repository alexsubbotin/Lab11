using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab11
{
    // Kingdom class (inherits Monarchy class)
    class Kingdom :Monarchy
    {
        // Constructor without parameters
        public Kingdom() : base() { }

        // Constructor with parameters
        public Kingdom(string Name, string lName, int Pop, int Age, string Cont,
           string curr):base(Name, lName, Pop, Age, Cont, curr) { }

        // Redefinition of the Show method
        public override void Show() 
        {
            Console.WriteLine(" Kingdom's name: {0}\n King's or Queen's name: {1}\n Kingdom's population: {2}\n kingdom's age: {3}\n Continent: {4}\n " +
                "Current rulling clan: {5}\n",
                Name, LeaderName, Population, Age, Continent, CurrentRullingClanName);
        }
    }
}
