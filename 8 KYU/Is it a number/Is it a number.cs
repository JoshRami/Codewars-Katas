using System;

public class CodeWars
{
  public static bool IsDigit(string s) 
  {
    return int.TryParse(s, out var int_num) | double.TryParse(s, out var double_num);
  }
}