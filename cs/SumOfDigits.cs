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
    static int sumOfDigits(int num)
    {
      if(num < 10) {
        return num;
      }
      int remainder = num % 10;
      int quotient = num / 10;

      return remainder + sumOfDigits(quotient);
    }

    static void Main(string[] args)
    {
      int number = 13489;
      Console.WriteLine(sumOfDigits(number));
    }
  }
}
