using System;
public static class Kata
{
  public static string Maskify(string cc)
  {
    var to_char = cc.ToCharArray();
    string masked = String.Empty;
    
    for(int i = 0; i < to_char.Length-4; i ++)
    {
      to_char[i] = '#';
    }    
    foreach(var i in to_char)
    {
      masked += i;
    }
    return masked;
  } 
}