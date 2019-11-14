using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and assigning a variable in c#
            string name = "Adam";
            string lastName = "Mugnano";
            int cohort = 34;
            int theBestCohort = 35;


            //reassigning a variable
            name = "Fortunato";
            cohort = 35;


            //String concatenation
            string greeting = "Hello " + name + " " + lastName + ". " + "Welcome to cohort " + cohort;


            //String interpolation
            string greeting2 = $"Hello {name} {lastName}. Welcome to Cohort {cohort}";


            //Booleans & Conditionals
            bool isTheBest = cohort == theBestCohort;

            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around!");
            }
            else if (name == "Fortunato")
            {
                Console.WriteLine("Well, not the right Cohort. But you have a good name");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decision");
            }


            //Loops

            //For loop
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            //For Each loop
            foreach (int taco in cohorts)
            {
                Console.WriteLine($"Cohort {taco}");
            }

            //While Loop
            while (cohort > 30)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            Console.WriteLine(greeting2);
        }
    }
}
