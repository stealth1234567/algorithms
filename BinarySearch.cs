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
    public static int binarySearch(int[] arr, int key, int start, int end)
    {
      if(start <= end) {
        int middle = (start + end) / 2;

        if(arr[middle] == key) {
          return middle;
        }
        else if(arr[middle] < key) {
          return binarySearch(arr, key, middle+1, end);
        }
        else {
          return binarySearch(arr, key, start, middle-1);
        }
      }
      return -1;
    }

    public static void Main(string[] args)
    {
      int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int end = array.Length - 1;
      Console.WriteLine(binarySearch(array, 4, 0, end));
    }
  }
}
