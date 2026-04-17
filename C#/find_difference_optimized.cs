using System;

namespace HelloWorld
{
    class Program
    {
      static void Main(string[] args)
      {
        string s = "test";
        string t = "twest";

        char result = FindTheDifference(s,t);
        Console.WriteLine(result);
      }

      public static char FindTheDifference(string s, string t) {
        int sSum=0;
        int tSum=0;
        foreach(char c in s)
      {
        sSum+=c;
      }

       foreach(char c in t)
      {
        tSum+=c;
      }

      return (char)(tSum-sSum);
     }
    }
}
