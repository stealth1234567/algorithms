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
    public static void BubbleSort(int[] arr)
    {
      int length = arr.Length;
      for(int i = 1; i < length; i++) {
        for(int j = 0; j < length - i; j++) {
          if(arr[j] > arr[j+1]) {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
          }
        }
      }
    }

    public static void Main(string[] args)
    {
      int[] array = { 70, 62, 25, 57, 91, 82, 11, 21, 14, 39 };
      BubbleSort(array);
      foreach(int element in array) {
        Console.WriteLine(element);
      }
    }
  }
}
