using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RecursiveSumProject
{
  class Program
  {
    static int SumArray(int[] array, int startIndex)
    {
      // startIndex < array.Length
      if(array.Length == 0 || startIndex >= array.Length)
      {
        return 0;
      }
      return array[startIndex] + SumArray(array, startIndex + 1);
    }

    static void Main(string[] args)
    {
      int[] myArray = { 1, 2, 3 };
      int startIndex = 0;
      Console.WriteLine(SumArray(myArray, startIndex));
    }
  }
}
