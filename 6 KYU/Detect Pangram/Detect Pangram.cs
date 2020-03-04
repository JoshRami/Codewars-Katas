using System;
public static class Kata
{
  public static bool IsPangram(string str)
  { 
    str = str.ToUpper(); 
    for (int i = (int) 'A'; i <= (int) 'Z'; i++)
    {
        if(str.Contains(Convert.ToChar(i)) == false)
            return false;
    }   
    return true;
  }
}