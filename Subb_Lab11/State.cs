using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab11
{
    class State // State class
    {
        // State name
        protected string name;
        // Leader's name
        protected string leaderName;
        // State population
        protected int population;
        // State age in years
        protected int age;
        // State's continent
        protected string continent; 

        // name property
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
        // leaderName property
        public string LeaderName
        {
            get
            {
                return leaderName;
            }
            set
            {
                leaderName = value;
            }
        }
        // population property
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                if (value > -1)
                    population = value;
                else
                    //Console.WriteLine("The population of a state can't be negative!");
                    population = 0;
            }
        }
        // age property
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > -1)
                    age = value;
                else
                    //Console.WriteLine("The age of a state can't be negative!");
                    age = 0;
            }
        }
        // continent property
        public string Continent
        {
            get
            {
                return continent;
            }
            set
            {
                continent = value;
            }
        }

        // Constructor without parameters
        public State() 
        {
            Name = "";
            LeaderName = "";
            Population = 0;
            Age = 0;
            Continent = "";
        }
        // Constructor with parameters
        public State(string Name, string lName, int Pop, int Age, string Cont) 
        {
            this.Name = Name;
            this.LeaderName = lName;
            this.Population = Pop;
            this.Age = Age;
            this.Continent = Cont;
        }

        // Method that shows an object of the State class
        virtual public void Show() 
        {
            Console.WriteLine(" State's name: {0}\n Leader's name: {1}\n State's population: {2}\n State's age: {3}\n Continent: {4}\n",
                Name, LeaderName, Population, Age, Continent);
        }
    }
}
