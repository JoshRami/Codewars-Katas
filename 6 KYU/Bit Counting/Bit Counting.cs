using System;

public class Kata
{
  public static int CountBits(int n)
  {
     return Ntimes(Convert.ToString(n, 2));  
  }
  public static int Ntimes(string bi)
  {
    int ntime = 0; 
    foreach(var i in bi)
    {
      if(i == '1')
          ntime++;
    }
     
    return ntime;
  }
}