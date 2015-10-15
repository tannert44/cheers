using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey What's Your Name?");

            string name = Console.ReadLine();
            
            Console.WriteLine("Hey, " + name + " When is your Birthday? (MM/DD)");

            string birthday = Console.ReadLine();
            
            for(int i=0; i<name.Length; i++)
            {
                bool isVowel = "halfnorsemix".IndexOf(name[i].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                if(isVowel)
                {
                    Console.WriteLine("Give me an ... " + Char.ToLower(name[i]));
                }
                else
                {
                    Console.WriteLine("Give me a ..." + Char.ToLower(name[i]));
                }
                 
            }

            DateTime monthAndDay = DateTime.Parse(birthday).AddYears(1);

            DateTime today = DateTime.Now;

            TimeSpan diff = monthAndDay.Subtract(today);

            int daysAway = diff.Days;
            daysAway++;
            if(daysAway == 366)
            {
                Console.WriteLine("Happy Birthday " + name + "!");
            }
            else
            {
                if(daysAway > 365)
                {
                    daysAway = daysAway - 366;

                    if(daysAway == 1)
                    {
                        Console.WriteLine(name + " your birthday is " + daysAway + " day away");
                    }
                    else
                    {
                        Console.WriteLine(name + " your birthday is " + daysAway + " days away");
                    }
                }
                else 
                {
                    Console.WriteLine(name + " your birthday is " + daysAway + " days away");
                }
                
            }

            Console.WriteLine(name.ToUpper() + " is GRAND!");


        }
    }
}
