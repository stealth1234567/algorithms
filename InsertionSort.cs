using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SololearnProject1
{
  class Program
  {
    static int[] InsertionSort(int[] array, int startIndex)
    {
      if(array.Length == 1 || startIndex >= array.Length)
      {
        return array;
      }

      for(int i = startIndex; i > 0; i--)
      {
        if(array[i] < array[i - 1])
        {
          int temp = array[i - 1];
          array[i - 1] = array[i];
          array[i] = temp;
        }
      }
      return InsertionSort(array, startIndex + 1);
    }

    static void Main(string[] args)
    {
      int[] myArray = { 2, 1, 10, 15, 5, 8, 8, 22, 0 };
      myArray = InsertionSort(myArray, 1);

      foreach(int item in myArray) {
        Console.WriteLine(item);
      }
    }
  }
}
