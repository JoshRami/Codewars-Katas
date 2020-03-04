using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var arr = numbers.Split(' ');
    return Max(arr)+ " " +Min(arr);
  }
  
  public static string Max(string[] arr)
  {
    int max = int.MinValue;
    for(int i = 0; i < arr.Length; i++)
    {
        if(int.Parse(arr[i]) > max)
            max = int.Parse(arr[i]);
    } 
    return max.ToString();
  }
  
   public static string Min(string[] arr)
   {
    int min = Int.MaxValue;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(int.Parse(arr[i]) < min)
            min = int.Parse(arr[i]);
    }
    return min.ToString();
   }
  
}