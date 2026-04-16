
/* Description of the problem:
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
*/

/// Brutt force Solution

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
    {
      string word1 = "cdf";
      string word2 = "a";

      string result = MergeAlternately(word1,word2);
      Console.WriteLine(result);
    }

        public static string MergeAlternately(string word1, string word2) {
          string result = string.Empty;

          char[] word1Array = word1!=string.Empty? word1.ToCharArray() : Array.Empty<char>();
          char[] word2Array = word2!=string.Empty?word2.ToCharArray() : Array.Empty<char>();

          int currIndex = 0;
          if(word1.Length > word2.Length ) {
            
            for(int i = 0; i<word2.Length; i++) //word1 is longer or equal
            {
              result+=word1Array[i];
              result+=word2Array[i];
              currIndex=i;
            }
            result+=word1.Substring(currIndex+1);
          } else if(word1.Length < word2.Length ) {
            for(int i = 0; i<word1.Length; i++) //word2 is longer
              {
                result+=word1Array[i];
                result+=word2Array[i];
                currIndex=i;
              }
              result+=word2.Substring(currIndex+1);
          } else
          {
             for(int i = 0; i<word1.Length; i++) //word2 == to word1
              {
                result+=word1Array[i];
                result+=word2Array[i];
              }
          }

          return result;        
      } 
    }
}
