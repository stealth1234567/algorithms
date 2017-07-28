using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SelectionSortProject
{
  class Program
  {
    // perform binary search for a particular number in an array
    static int[] SelectionSort(int[] array) {
      // for each position in array
      // compare with others to find smallest index
      // if there's a smaller number, assign index of smallest value to smallestIndex variable
      // swap current element with element at smallest position smallest
      for(int i = 0; i < array.Length; i++)
      {
        int smallestIndex = i;
        for(int j = i+1; j < array.Length; j++)
        {
          // find index of smallest
          if(array[j] < array[smallestIndex]) {
            smallestIndex = j;
          }
        }
        // swap values
        int temp = array[i];
        array[i] = array[smallestIndex];
        array[smallestIndex] = temp;
      }
      return array;
    }

    static void Main(string[] args)
    {
      int[] myArray = { 26, 54, 93, 17, 77, 31, 44, 55, 20 };
      myArray = SelectionSort(myArray);
      foreach(int num in myArray)
      {
        Console.WriteLine(num);
      }
    }
  }
}
