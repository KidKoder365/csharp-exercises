using System;
using System.Collections.Generic;

namespace CountingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();
            string Paragragh = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin.Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat.Donec sit amet suscipit metus, non lobortis massa.Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            foreach (char letter in Paragragh)
            {
                // If dictionary contains Letter, then set value to 1
                if (myDict.ContainsKey(letter))
                {
                    myDict[letter] += 1;

                }
                // If Dictionary already has existing key, then add 1 to the Value
                else
                {
                    myDict.Add(letter, 1);

                }

            }
            foreach (KeyValuePair<char, int> pair in myDict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);

            }

        }
    }
}
