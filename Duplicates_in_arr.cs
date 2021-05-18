using System;
using System.Collections.Generic;
namespace Demo {
   public class Program {
      public static void Main(string[] args) {
     
         int[] arr = {
            87,
            55,
            23,
            87,
            45,
            23,
            98
         };
         var dict = new Dictionary < int, int > ();
         foreach(var count in arr) {
            if (dict.ContainsKey(count))
            dict[count]++;
            else
            dict[count] = 1;
         }
         foreach(var val in dict)
         Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);
      }
   }
}