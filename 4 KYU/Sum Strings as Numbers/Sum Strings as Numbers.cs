using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger BigA, BigB;
     
        if (BigInteger.TryParse(a, out BigA) == false) 
            return b; 
     
        if (BigInteger.TryParse(b, out BigB) == false) 
            return a;
         
      BigInteger sum = BigA + BigB;
      return sum.ToString();
    }
}