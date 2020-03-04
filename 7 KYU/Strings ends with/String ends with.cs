public class Kata
{
  public static bool Solution(string str, string ending)
  { 
    string compare = string.Empty;
    
    if(ending.Length > str.Length)
        return false;
    
    for(int i = str.Length-ending.Length ;i < str.Length; i++)
    {
        compare += str[i];
    }     
    return compare.Equals(ending)? true: false;
  }
}