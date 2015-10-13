using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey What's Your Name?");
            string name = Console.ReadLine();
            for(int i=0; i<name.Length; i++)
            {
                bool isVowel = "halfnorsemix".IndexOf(name[i].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                if(isVowel)
                {
                    Console.WriteLine("Give me an ... " + name[i]);
                }
                else
                {
                    Console.WriteLine("Give me a ..." + name[i]);
                }
                 
            }
            Console.WriteLine("Goooooo " + name + "!");


        }
    }
}
