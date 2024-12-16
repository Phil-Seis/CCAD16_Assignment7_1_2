/*
 * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
 * If a string is longer than the other, append the additional letters onto the end of the merged string.
 * Return the merged string.
*/
using System;

namespace CCAD16_Assignment7_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hi";
            string word2 = "World";

            Console.WriteLine($"The two words that you chose are '{word1}' and '{word2}'");

            string mergedWord = MergeStrings(word1, word2);
            Console.WriteLine($"The merged string is: {mergedWord}");
        }

        public static string MergeStrings(string word1, string word2)
        {

            int maxLength = 0;

            //determine longer string for iterative purposes
            if (word1.Length > word2.Length)
            {
                maxLength = word1.Length;
            }
            else
            {
                maxLength = word2.Length;
            }

            // result array
            char[] result = new char[word1.Length + word2.Length];
            int index = 0;

            // for loop to merge characters
            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    result[index++] = word1[i];
                }

                if (i < word2.Length)
                {
                    result[index++] = word2[i];
                }
            }

            return new string(result); // Convert the character array to a string and return
        }
    }
}