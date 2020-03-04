using System;

public static class Kata
{
  public static string Swap(string s)
  {
    var letter = new Char[s.Length];
	letter = s.ToCharArray();
		
    for(int i = 0; i < letter.Length; i++)
    {
        if(letter[i]  == 'a' | letter[i]  == 'e' | letter[i]  == 'i'| letter[i]  == 'o' | letter[i]  == 'u')
            letter[i] = Char.ToUpper(letter[i]);
    }
    string res = new string(letter);
	return res;
  }
}