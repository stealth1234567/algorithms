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
      if(endIndex > 0)
      {
        for(int i = 0; i < endIndex; i++)
        {
          if(array[i] > array[i + 1]) 
          {
            Console.WriteLine("SWAP " + array[i] + " with " + array[i+1] + "\n");
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
          }
        }
        endIndex = endIndex - 1;
        BubbleSort(array, endIndex);
      }
      return array;
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
