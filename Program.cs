/*
 * author: Adam Marshall
 * date: 03/03/2023
 * class: GAME-1343
 * project: Week 6 Assignment - Lists and Dictionaries
 */

using System;
using System.Collections.Generic;

namespace Week6Assignment
{
    public class Solutions
    {
        public static void List()
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name:");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                else
                    list.Add(input);

            }

            switch (list.Count)
            {
                case 0:
                    Console.WriteLine("Nobody likes your post");
                    break;

                case 1:
                    Console.WriteLine("{0} likes your post", list[0]);
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} liked your post", list[0], list[1]);
                    break;

                default:
                    Console.WriteLine("{0} and {1} and {2} other people liked your post", list[0], list[1], (list.Count - 2));
                    break;
            }
        }

        public static void Dictionary()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            Console.WriteLine("\nEnter a sentence: ");
            string str = Console.ReadLine();

            foreach (char ch in str.Replace(" ", string.Empty))
            {
                if(dictionary.ContainsKey(ch))
                {
                    dictionary[ch] = dictionary[ch] + 1;
                }
                else
                {
                    dictionary.Add(ch, 1);
                }
            }

            foreach(var item in dictionary.Keys)
            {
                Console.WriteLine(item + " | " + dictionary[item]);
            }
            Console.ReadKey();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Solutions.List();
            Solutions.Dictionary();
        }
    }
}