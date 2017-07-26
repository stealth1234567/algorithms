using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinarySearchProject
{
  class Program
  {
    // perform binary search for a particular number in an array
    static int BinarySearch(int[] array, int item, int firstIndex, int lastIndex) {
      int middleIndex = (firstIndex + lastIndex) / 2;
      int middleItem = array[middleIndex];

      if(firstIndex > lastIndex)
      {
        return -1;
      }

      if(item == middleItem)
      {
        return middleIndex;
      }
      else if(item > middleItem)
      {
        return BinarySearch(array, item, middleIndex+1, lastIndex);
      }
      else if(item < middleItem)
      {
        return BinarySearch(array, item, firstIndex, middleIndex-1);
      }
      return -1;
    }

    static void Main(string[] args)
    {
      int[] myArray = new int[10000];
      int num = 1;

      // populate the array
      for(int i = 0; i < myArray.Length; i++)
      {
        myArray[i] = num;
        num++;
      }

      // -- SPEED TEST -- //
      var watch = System.Diagnostics.Stopwatch.StartNew();
      
      Console.WriteLine(BinarySearch(myArray, 9146, 0, 9999));
      
      watch.Stop();
      var elapsedMs = watch.ElapsedMilliseconds;

      Console.WriteLine("My Binary Search: " + elapsedMs);
    }
  }
}
