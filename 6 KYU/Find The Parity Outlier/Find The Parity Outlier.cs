using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    var isOdd = 0;
    var outlier = 0;
    
    //Check if the outlier will be odd or  even 
    foreach(var i in integers)
    {
      if(i % 2 == 0)
        isOdd++;
    }
    
    if(isOdd > 1)
    {
      foreach(var i in integers)
      {
         if(i % 2 != 0)
          outlier = i;
      }
       
    }
    else
    {
      foreach(var i in integers)
      {
         if(i % 2 == 0)
          outlier = i;
      }  
      
    }
    
    return outlier; 
  }
}