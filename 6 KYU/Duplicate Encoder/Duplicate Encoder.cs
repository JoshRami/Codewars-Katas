using System;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToUpper();
    string encode = string.Empty;
    int count = 0;
    
    for(int i = 0; i < word.Length;i++)
    {
       for(int j = 0; j < word.Length; j++)
       {
          if(word[i] == word[j])
             count++;
       }  
        if(count == 1)
            encode += "(";
        else
            encode += ")";
            
         count = 0;
    }
     return encode;
  }
}