using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab11
{
    // Monarchy class (inherits State class)
    class Monarchy : State
    {
        // Name of current rulling clan
        protected string currentRullingClanName; 

        // currentRulingClanNam property
        public string CurrentRullingClanName
        {
            get
            {
                return currentRullingClanName;
            }
            set
            {
                currentRullingClanName = value;
            }
        }

        // Constructor without parameters
        public Monarchy() : base() 
        {
            CurrentRullingClanName = "";
        }
        // Constructor with parameters
        public Monarchy(string Name, string lName, int Pop, int Age, string Cont,
            string curr):base(Name, lName, Pop, Age, Cont) 
        {
            CurrentRullingClanName = curr;
        }

        // Redefinition of the Show method
        public override void Show() 
        {
            Console.WriteLine(" Monarchical state's name: {0}\n Monarch's name: {1}\n Monarchical state's population: {2}\n " +
                "Monarchical state's age: {3}\n Continent: {4}\n " +
                "Current rulling clan: {5}\n", 
                Name, LeaderName, Population, Age, Continent, CurrentRullingClanName);
        }
    }
}
