using System;

public static class Kata 
{
    public static int TrailingZeros(int n)
    { 
        int zeros = 0;
        while(n >= 5)
        {
            n /= 5;
            zeros += n;
        } 
        return zeros;
  }
}