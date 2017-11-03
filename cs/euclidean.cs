using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EuclideanProject
{
  class Program
  {
    // Find the Greatest Common Divisor of two integers
    static int GCD(int a, int b)
    {
      if(a != 0 && b == 0)
      {
        return a;
      }
      else if(b != 0 && a == 0) {
        return b;
      }
      else {
        if(a >= b) {
          int quotient = a / b;
          int remainder = a % b;
          return GCD(b, remainder);
        }
        else
        {
          int quotient = b / a;
          int remainder = b % a;
          return GCD(b, remainder);
        }
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine(GCD(25, 10));
    }
  }
}
