using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            int cohort = 34;

            // reassigning variables
            name = "Jisie";
            cohort = 35;
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            // string interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}!";

            bool isTheBest = cohort == 35;

            // conditionals
            if ( isTheBest )
            {
                Console.WriteLine("Ah, the best around");
            }
            else if ( name == "Jissie")
            {
                Console.WriteLine("Well, not in the right cohort. But She's p");
            }
            else
            {
                Console.WriteLine("You may... want to rethink you decision");
            }

            // loops
            // for loops 
            int[] cohorts = new int[]{ 34, 35, 36, 37 };

            for( int i = 0; i < cohorts.Length; i++ )
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            foreach ( int item in cohorts )
            {
                Console.WriteLine($"Cohort {item}");
            }

            // while loops
            while (true)
            {
                Console.WriteLine("I'm stuck in a forever loop!!!");
                break;
            }

            while ( cohort > 0 )
            {
                Console.WriteLine(cohort);
                cohort--;
            }

            Console.WriteLine(greeting2);
        }
    }
}
