using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace InsertionSortProject
{
  class Program
  {
    public static void InsertionSort(int[] array) {
      // loop through from 1 to end
      for(int i = 1; i < array.Length; i++) {
        int currentElement = array[i];
        int j = i - 1;
        while(j >= 0 && (array[j] > currentElement)) {
          array[j + 1] = array[j];
          j--;
        }
        array[j + 1] = currentElement;
      }
      return array;
    }
    

    public static void Main(string[] args) {
      int[] myArray = { 24, 3, 20, 18, 13 };

      InsertionSort(myArray);

      foreach(int element in myArray) {
        Console.WriteLine(element);
      }
    }
  }
}
