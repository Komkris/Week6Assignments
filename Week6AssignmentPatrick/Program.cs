using System;
using System.Collections.Generic; //needed to use list (and Dictionary?)

namespace Blish6CursedEdition
{
    class Program
    {
        static void Main(string[] args)
        {

            //Only call methods within Main method.

            //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name)
            //Depending on the number of names provided, display a message based on the above pattern.
            //[!]You should use a List when solving this one[!]
            Problem1();

            //Write a program that asks the user to enter a sentence. Display each unique letter in the sentence, and how many times each one appeared.
            //[!]You should use a Dictionary when solving this one[!]
            Problem2();
        }

        static void Problem1()
        {
            //create string list and string holder
            List<string> friendNames = new List<string>();
            string thatFriend = "bruh";

            //create boolean loop
            bool stop = false;


            Console.WriteLine("\nPlease enter the names of your friends. \nWhen you are done, press enter without inputting anything to continue.");

            while (stop == false)
            {
                thatFriend = Console.ReadLine();
                if (string.IsNullOrEmpty(thatFriend))                           // if user gives no inputs, end loop
                {
                    stop = true;
                }
                else                                                            //else, add input as a string to the the string list
                {
                    friendNames.Add(thatFriend);
                }
            }

            //check the length of the list and output accordingly
            if (friendNames.Count == 0)
            {
                //-If no one likes your post, it doesn't display anything.
            }
            else if (friendNames.Count == 1) //-If only one person likes your post, it displays: [Friend's Name] likes your post.
            {
                Console.WriteLine(friendNames[0] + " likes your post.");
            }
            else if (friendNames.Count == 2)//-If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            {
                Console.WriteLine(friendNames[0] + " and " + friendNames[1] + " likes your post.");
            }
            else if (friendNames.Count > 2) //-If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            {
                Console.WriteLine(friendNames[0] + ", " + friendNames[1] + " and " + (friendNames.Count - 2) + " others like your post.");
            }
            else
            {
                Console.WriteLine("[ERROR]: there is a flaw in the creation of the list and/or it's contents.");
            }

        }

        static void Problem2()
        {
            //create Dictionary with a char ID.
            Dictionary<char, int> countLetter = new Dictionary<char, int>();

            //create string variable
            string hold = "the cake is a lie";

            //request user to input a string
            Console.WriteLine("\nThis Method will count each letter you input.\nPlease enter a word or sentance\n");

            //get input
            hold = Console.ReadLine();

            // go through each char in string, force each char to be lower cased to avoid splitting a word or sentence up by capitilzation 
            foreach (char c in hold)
            {
                if (c == ' ')                                           // if char is a empty space:
                {
                    //ignore empty spaces, do not add them to the dictionary
                }
                else if (countLetter.ContainsKey(Char.ToLower(c)))      // if a char is already put into the dictionary as a key:
                {
                    countLetter[Char.ToLower(c)] += 1;                      //increase the value of that key by 1
                }
                else                                                    // if a char is not already put into the dictionary as a key:
                {
                    countLetter.Add(Char.ToLower(c), 1);                    //add a new key to the dictionary with a starting value of 1
                }
            }

            //skip a line in the output
            Console.WriteLine("\n");

            //output each char key and it's int value to the user
            foreach (KeyValuePair<char, int> pairing in countLetter)
            {
                Console.WriteLine(pairing.Key + " | " + pairing.Value);
            }

        }
    }
}
