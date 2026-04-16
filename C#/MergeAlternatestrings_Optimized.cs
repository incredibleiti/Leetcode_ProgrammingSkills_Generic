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
          int limitOfLoop = word1.Length>word2.Length? word2.Length : word1.Length;
          string remainingString = word1.Length>word2.Length? word1.Substring(limitOfLoop) : word2.Substring(limitOfLoop);

          for(int i =0; i<limitOfLoop; i++)
          {
            result+=word1[i];
            result+=word2[i];
          }
          return result +remainingString;        
      } 
    }
}
