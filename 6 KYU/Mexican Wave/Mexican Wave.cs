using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
      public List<string> wave(string str)
      {
        var wave = new List<string>(str.Length);
		var ToCharArr = new char[str.Length];
			
        for(int i = 0; i <= str.Length-1;i++)
		{
		    ToCharArr =str.ToCharArray();
            
			if(ToCharArr[i] != ' ')
			{
				ToCharArr[i] = Char.ToUpper(ToCharArr[i]);
				String s = new String(ToCharArr);
			    wave.Add(s);	 
			}	 
		}	 
           return wave;
      }
    
    }
}