public class Kata
{
  public static string GetMiddle(string s)
  {
    var middle = string.Empty;
    
    if(s.Length < 1)
      return s;
    
    if(s.Length % 2 == 0)
      middle =  s[(s.Length / 2)-1] + s[(s.Length / 2)].ToString();
    else 
      middle = s[s.Length / 2].ToString(); 
      
      return middle;
  }
}