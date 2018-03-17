using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subb_Lab11
{
    // Republic class (inherits State class)
    class Republic :State 
    {
        // Length of president term in years
        protected int presidentTerm;
        // How many members in parlament
        protected int parlamentMembersNumber;
        // Length of parlament members term
        protected int parlamentTerm; 

        // presidentTerm property
        public int PresidentTerm
        {
            get
            {
                return presidentTerm;
            }
            set
            {
                if (value > 0)
                    presidentTerm = value;
                else
                    //Console.WriteLine("The length of a president's term can't be lesser that 1 year!");
                    presidentTerm = 0;
            }
        }
        // parlamentMembersNumber property
        public int ParlamentMembersNumber
        {
            get
            {
                return parlamentMembersNumber;
            }
            set
            {
                if (value > 0)
                    parlamentMembersNumber = value;
                else
                    //Console.WriteLine("The number of parlament's members can't be lesser than 1 member!");
                    parlamentMembersNumber = 0;
            }
        }
        // parlamentTerm property
        public int ParlamentTerm
        {
            get
            {
                return parlamentTerm;
            }
            set
            {
                if (value > 0)
                    parlamentTerm = value;
                else
                    //Console.WriteLine("The length of a parlament's member term can't be lesser that 1 year!");
                    parlamentTerm = 0;
            }
        }

        // Constructor without parameters
        public Republic() : base() 
        {
            PresidentTerm = 0;
            ParlamentMembersNumber = 0;
            ParlamentTerm = 0;
        }

        // Constructor with parameters
        public Republic(string stateName, string presName, int popul, int age, string cont, 
            int presTerm, int parCount, int parTerm):base(stateName, presName, popul,age, cont) 
        {
            PresidentTerm = presTerm;
            ParlamentMembersNumber = parCount;
            ParlamentTerm = parTerm;
        }

        // Redefinition of the Show method
        public override void Show() 
        {
            Console.WriteLine(" Republic's name: {0}\n President's name: {1}\n Republic's population: {2}\n Republic's age: {3}\n Continent: {4}\n " +
                "Length of the President term: {5}\n Number of the parlament members: {6}\n Length of the parlament members term: {7}\n", 
                Name, LeaderName, Population, Age, Continent, PresidentTerm, ParlamentMembersNumber, ParlamentTerm);
        }
    }
}
