using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string SpinWords(string sentence)
    {
		var words = sentence.Split(' ');	
		for(int i = 0; i < words.Length; i++)
	 	{
			 if(words[i].Length >= 5)
			    words[i] = ReverseWord(words[i]);				
		}
		return(string.Join(" ", words));
    }
    public static string ReverseWord(string word)
	{
		string reverse = string.Empty;
		for(int i = word.Length-1; i >= 0; i--)
		{
			reverse += word[i];
		}
		return reverse;
	}
}