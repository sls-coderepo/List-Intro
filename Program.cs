using System;
using System.Collections.Generic;

namespace ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a new list variable
            List<int> cohorts = new List<int>();
            cohorts.Add(34);
            cohorts.Add(35);
            cohorts.Add(36);
            cohorts.Add(37);

            //Another way to can initialize this list
            List<string> classes = new List<string>()
            {
                "Cohort 34",
                "Cohort 35",
                "Cohort 36",
                "Cohort 37"
            };
            classes.Remove("Cohort 34");
            classes.Add("Cohort 38");

            foreach (int nssClass in cohorts)
            {
                if (nssClass == 35)
                {
                    Console.WriteLine($"The Best Cohort: {nssClass}");
                }
                else
                {
                    Console.WriteLine($"A Perfectly Fine Cohort: {nssClass}");
                }

            }

        }
    }
}