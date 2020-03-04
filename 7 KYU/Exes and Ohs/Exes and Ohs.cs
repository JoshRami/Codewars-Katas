using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int Ohs = 0;
    int Exes = 0;
    input = input.ToLower(); 
    foreach(var i in input)
    { 
        if(i == 'o')
            Ohs++;
        else if (i == 'x')
            Exes++;
    }
    return Exes == Ohs ? true: false;
  }
}