using System;

public class Printer 
{
    public static string PrinterError(String s) 
    {
      int to_int = 0;
      int error = 0;
      int m = (int)('m');
 
      foreach (var letter in s)
      {
        to_int = (int)(letter);
        if (to_int > m )
        error++;                
      }
      
      string result = error + "/" + s.Length;            
      
      return result;
    }
}