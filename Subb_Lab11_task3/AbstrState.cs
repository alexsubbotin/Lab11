using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Subb_Lab11_task3
{
    // Abstract State class that uses standart IComparable interface
    abstract class AbstrState: IComparable
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
        public AbstrState()
        {
            Name = "";
            LeaderName = "";
            Population = 0;
            Age = 0;
            Continent = "";
        }
        // Constructor with parameters
        public AbstrState(string Name, string lName, int Pop, int Age, string Cont)
        {
            this.Name = Name;
            this.LeaderName = lName;
            this.Population = Pop;
            this.Age = Age;
            this.Continent = Cont;
        }

        // Abstract method that shows an object of the class that inherits the AbstrState class (each class have to redefine it)
        abstract public void Show();
        
            
        

        // Redefinition of the CompareTo method from the IComparable interface
        public int CompareTo(object s)
        {
            AbstrState newS = s as AbstrState;
            int result = new int();
            if (this.Population == newS.Population)
                result = 0;
            if (this.Population > newS.Population)
                result = 1;
            if (this.Population < newS.Population)
                result = -1;
            return result;
        }
    }
    // Class to sort by population
    public class ComparePopulation : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            AbstrState s1 = (AbstrState)ob1;
            AbstrState s2 = (AbstrState)ob2;
            return s1.CompareTo(s2);
        }
    }

    // Class to sort by name
    public class CompareName : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            AbstrState s1 = (AbstrState)ob1;
            AbstrState s2 = (AbstrState)ob2;

            return String.Compare(s1.Name, s2.Name);
        }
    }

    // Class to sort by leader's name
    public class CompareLeaderName : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            AbstrState s1 = (AbstrState)ob1;
            AbstrState s2 = (AbstrState)ob2;

            return String.Compare(s1.LeaderName, s2.LeaderName);
        }
    }

    // Class to sort by age
    public class CompareAge : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            AbstrState s1 = (AbstrState)ob1;
            AbstrState s2 = (AbstrState)ob2;

            int result = new int();
            if (s1.Age == s2.Age)
                result = 0;
            if (s1.Age > s2.Age)
                result = 1;
            if (s1.Age < s2.Age)
                result = -1;
            return result;
        }
    }

    // Class to sort by continent
    public class CompareContinent : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            AbstrState s1 = (AbstrState)ob1;
            AbstrState s2 = (AbstrState)ob2;

            return String.Compare(s1.Continent, s2.Continent);
        }
    }
}
