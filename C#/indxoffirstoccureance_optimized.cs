/*
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "aaaaa";
            string n = "bba";

            int result = StrStr(h,n);
            Console.WriteLine(result);
        }

        public static int StrStr(string haystack, string needle) {
            if (string.IsNullOrEmpty(needle))
            return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;

                        // Compare characters
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }

                        // If we matched entire needle
                if (j == needle.Length)
                    return i;
            }

            return -1;
        }
    }
}
