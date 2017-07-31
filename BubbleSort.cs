using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BubbleSortProject
{
  class Program
  {
    // perform bubble sort on an array
    static int[] BubbleSort(int[] array, int endIndex)
    {
      if(endIndex == 0)
      {
        return array;
      }

      for(int j = 0; j < endIndex; j++)
      {
        if(array[j] > array[j + 1])
        {
          int temp = array[j];
          array[j] = array[j + 1];
          array[j + 1] = temp;
        }
      }
      return BubbleSort(array, endIndex - 1);
    }

    static void Main(string[] args)
    {
      int[] myArray = { 26, 54, 93, 17, 77, 31, 44, 55, 20 };
      myArray = BubbleSort(myArray, 8);
      foreach(int num in myArray)
      {
        Console.WriteLine(num);
      }
    }
  }
}
