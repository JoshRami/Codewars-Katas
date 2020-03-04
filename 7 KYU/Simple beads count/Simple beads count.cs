using System;

public static class Kata
{
  public static int CountRedBeads(int n)
  {
     return n > 0 ? 2 * (n - 1) : 0;
  }
}