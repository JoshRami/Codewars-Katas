using System;
public class Kata
{
    public static bool Narcissistic(int value)
    {
        var sum = 0;
        var Str = value.ToString();
        if(value < 10)
            return true;
    
        for(int i = 0; i < Str.Length; i++)
        {
            sum += (int) Math.Pow((int)Char.GetNumericValue((Str[i])),Str.Length);
        }
    
        return sum.ToString() == Str ? true: false;
  }
}