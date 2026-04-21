/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false
*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";

            bool result = IsAnagram(s,t);
            Console.WriteLine(result);
        }

        public static bool IsAnagram(string s, string t) {

            if(s.Length ==0|| t.Length==0)
            {
                return false;
            }

            char[] sortedS = s.ToCharArray().OrderBy(x=>x).ToArray();
            char[] sortedT = t.ToCharArray().OrderBy(x=>x).ToArray();

            string sorted_s = new string(sortedS);
            string sorted_t = new string(sortedT);

            
            return sorted_s.Equals(sorted_t);
        
        }
    }
}
