using System;

public class Kata
{
   public static int GetAge(string inputString)
   {
      return (int) Char.GetNumericValue(inputString[0]);
   }
}