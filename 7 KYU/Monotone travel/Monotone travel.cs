using System;

public class Kata
{
  public static bool IsMonotone(int[] arr)
  {
    bool IsRising = true;
    
    if(arr.Length == 0 || arr == null)
       return IsRising;
      
    for(int i = 0; i < arr.Length-1; i++)
    {
      if(arr[i] > arr[++i])
        return false;  
    }
    return IsRising;      
  }
}