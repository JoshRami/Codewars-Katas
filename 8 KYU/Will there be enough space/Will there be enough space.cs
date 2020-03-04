using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
     var enough = on + wait <= cap ? 0: (on + wait)- cap; 
     return enough;
  } 
}