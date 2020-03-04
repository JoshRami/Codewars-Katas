using System;

public static class Kata
{
  public static int ToBinary(int n)
  {
    string binary = String.Empty;
    if(n == 0)
      return 0;
   
    while(n > 0)
    {
      if(n % 2 == 0)
        binary += "0";
      else
        binary += "1";     
      n /= 2;
    }
   return int.Parse(ReverseString(binary));   
  }
  
  public static string ReverseString(string s)
  {
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }


