using System;
using System.Collections.Generic;

public class Accumul 
{
    public static String Accum(string s) 
    {
        string result = string.Empty;
        s = s.ToUpper();

        for (int i = 0; i < s.Length; i++)
        {
            result += s[i];
            for (int j = 0; j < i; j++)
            {
                result += Char.ToLower(s[i]);       
            }
            if(i != s.Length-1)
                result += "-";
        }
    return result;
    }
}